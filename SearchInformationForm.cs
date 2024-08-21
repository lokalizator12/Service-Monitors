using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.Content.Objects;
using PdfSharp.Pdf.IO;
using ServiceMonitorEVK.Main;
using static System.Diagnostics.Debug;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using Keys = OpenQA.Selenium.Keys;

namespace ServiceMonitorEVK
{
    public partial class SearchInformationForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private IWebDriver driver;
        private readonly Form1 form1;

        public SearchInformationForm()
        {
            InitializeComponent();
        }

        public SearchInformationForm(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            InitizializeCustomForm();
        }

        private void CheckTheme()
        {
            materialSkinManager.Theme = form1.materialSwitch1.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey900 : Primary.BlueGrey800,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey800 : Primary.BlueGrey900,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey700 : Primary.BlueGrey500,
                Accent.Red400,
                TextShade.WHITE);

            infoDisplayTextBox.BackColor = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                ? Color.FromArgb(0x21, 0x21, 0x21)
                : Color.FromArgb(0x37, 0x47, 0x4F);
        }

        public void InitizializeCustomForm()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            CheckTheme();
            DrawerAutoShow = true;
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            modelLabel1.Text = @"Loading...";
            infoDisplayTextBox.Text = "";
            pictureBox1.Image = null;
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(service, options);
            await FetchAndDisplayProductInfo(manufacturerComboBox1.Text);
        }

        private async Task FetchAndDisplayProductInfo(string manufacturer)
        {
            var model = modelTextBox.Text;
            var serialNumber = serialNumberTextBox.Text;
            try
            {
                switch (manufacturer.ToLower())
                {
                    case "lenovo":
                        await FetchLenovoProductInfo(serialNumber);
                        break;
                    case "dell":
                        await FetchDellProductInfo(model);
                        break;
                    // Add more cases for other manufacturers here
                    default:
                        modelLabel1.Text = @"Manufacturer not supported.";
                        return;
                }
            }
            catch (Exception ex)
            {
                modelLabel1.Text = $@"Error: {ex.Message}";
            }
            finally
            {
                Console.WriteLine(@"Closing WebDriver...");
                driver.Quit();
            }
        }

        private Task FetchLenovoProductInfo(string serialNumber)
        {
            driver.Navigate().GoToUrl("https://pcsupport.lenovo.com/pl/pl");

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(drv =>
                ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

            var serialNumberInput = wait.Until(drv => drv.FindElement(By.CssSelector("input[type='text']")));
            serialNumberInput.SendKeys(serialNumber);

            var searchButton = wait.Until(drv => drv.FindElement(By.CssSelector("span.icon-search")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", searchButton);

            wait.Until(drv => drv.FindElement(By.CssSelector("div.prod-img-area")));
            wait.Until(drv => drv.FindElement(By.CssSelector("h2.new-product-name")));

            var pageSource = driver.PageSource;
            var productInfo = ParseProductInfo(pageSource, "lenovo");

            if (productInfo != null)
                DisplayProductInfo(productInfo);
            else
                modelLabel1.Text = "Product information not found.";
            return Task.CompletedTask;
        }

        private async Task FetchDellProductInfo(string model)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(drv =>
                    ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

                await driver.Navigate()
                    .GoToUrlAsync(
                        "https://dl.dell.com/manuals/all-products/esuprt_electronics_accessories/esuprt_electronics_accessories_monitors/");

                // Ищем нужный PDF файл по модели и английскому языку
                var pdfLink = wait.Until(drv =>
                    drv.FindElement(By.XPath(
                        $"//a[contains(@href, \"dell-{model.ToLower()}\") and contains(@href, \"User's-Guide\") and contains(@href, \"en-us\")]")));
                var pdfUrl = pdfLink.GetAttribute("href");
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", pdfLink);

                ////////////////////////////////////////
                await driver.Navigate().GoToUrlAsync("https://www.dell.com/support/home/en-us");


                wait.Until(drv =>
                    ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

                // Найдем поле ввода по его ID и классу
                var serialNumberInput = wait.Until(drv =>
                    drv.FindElement(By.CssSelector("input#homemfe-dropdown-input.dds__dropdown__input-field")));

                // Используем Actions для ввода текста в поле
                var actions = new Actions(driver);
                actions.MoveToElement(serialNumberInput).Click().SendKeys("DELL " + model).Perform();

                // Подтверждаем ввод, так как на сайте может быть авто-комплит
                serialNumberInput.SendKeys(Keys.Enter);



                var imageElement = wait.Until(drv => drv.FindElement(By.CssSelector("img#imgV1PDBSysDescription")));
                var imageUrl = imageElement.GetAttribute("src"); 
                pictureBox1.LoadAsync(imageUrl);
                var pdfText = await ExtractPdfTextAsync(pdfUrl);

                if (pdfText != null)
                {
                    modelLabel1.Text = model;
                    infoDisplayTextBox.Text = pdfText;
                }
                else
                {
                    modelLabel1.Text = @"Product features not found in PDF.";
                }
            }
            catch (Exception ex)
            {
                modelLabel1.Text = $@"Error: {ex.Message}";
            }
            finally
            {
                driver.Quit();
            }
        }

        [Obsolete("Obsolete")]
        private async Task<string> ExtractPdfTextAsync(string pdfUrl)
        {
            var textBuilder = new StringBuilder();
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(
                        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/pdf"));

                    using (var response = await client.GetAsync(pdfUrl))
                    using (var pdfStream = await response.Content.ReadAsStreamAsync())
                    {
                        using (var document = PdfReader.Open(pdfStream, PdfDocumentOpenMode.ReadOnly))
                        {
                            for (var pageNumber = 0; pageNumber < document.PageCount; pageNumber++)
                            {
                                var page = document.Pages[pageNumber];
                                CObject content = ContentReader.ReadContent(page);
                                ExtractText(content, textBuilder);
                            }


                            return ExtractProductFeaturesFromPdf(textBuilder.ToString());
                        }
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("HTTP Request error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error extracting PDF text: " + ex.Message);
            }

            return null;
        }

        private string ExtractProductFeaturesFromPdf(string pdfText)
        {
            var cleanText = "";

            WriteLine("Extracted PDF Text:\n" + pdfText);
            var pattern = @"Product Features\nThe.*?Identifying Parts and Controls";
            WriteLine("Extracted pattern:\n" + pattern);

            var match = Regex.Match(pdfText, pattern, RegexOptions.Singleline);
            if (!match.Success)
            {
                pattern = @"Product Features\nThe.*?About your monitor";
                match = Regex.Match(pdfText, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                WriteLine("Extracted pattern:\n" + pattern);
                WriteLine("Extracted match:\n" + match);
            }

            if (match.Success)
            {
                var extractedText = match.Value;
                cleanText = CleanText(extractedText);
                WriteLine("RESULT:\n" + cleanText);
            }
            else
            {
                WriteLine("Product Features not found in PDF.");
            }

            return cleanText;
        }

        private static string CleanText(string input)
        {
            var cleaned = Regex.Replace(input, @"[^\u0000-\u007F]+", string.Empty);
            cleaned = cleaned.Replace("v", "").Trim();
            cleaned = Regex.Replace(cleaned, @"\s+", " ");
            cleaned = cleaned.Replace(". ", ".\n");
            return cleaned;
        }

        private static void ExtractText(CObject cObject, StringBuilder textBuilder)
        {
            if (cObject is COperator)
            {
                var cOperator = cObject as COperator;
                if (cOperator.OpCode.Name == OpCodeName.Tj.ToString() ||
                    cOperator.OpCode.Name == OpCodeName.TJ.ToString())
                {
                    textBuilder.Append("\n");
                    foreach (var cOperand in cOperator.Operands)
                        switch (cOperand)
                        {
                            case CSequence operand:
                            {
                                foreach (var item in operand)
                                    if (item is CString)
                                        textBuilder.Append((item as CString).Value);
                                break;
                            }
                            case CString cString:
                                textBuilder.Append(cString.Value);
                                break;
                        }
                }
            }
            else if (cObject is CArray)
            {
                foreach (var item in cObject as CArray) ExtractText(item, textBuilder);
            }
            else if (cObject is CSequence)
            {
                foreach (var item in cObject as CSequence) ExtractText(item, textBuilder);
            }
        }


        private ProductInfo ParseProductInfo(string html, string manufacturer)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var productInfo = new ProductInfo();

            if (manufacturer.ToLower() == "lenovo")
            {
                productInfo.ImageUrl = doc.DocumentNode.SelectSingleNode("//div[@class='prod-img-area']//img")
                    ?.GetAttributeValue("src", "");
                productInfo.Model = doc.DocumentNode.SelectSingleNode("//h2[@class='new-product-name']")?.InnerText
                    .Trim();
                productInfo.MachineTypeModel = doc.DocumentNode
                    .SelectSingleNode("//div[@class='new-other-info-list'][1]")?.InnerText.Trim();
                var otherInfoNodes = doc.DocumentNode.SelectNodes("//div[@class='new-other-info-list']");
                if (otherInfoNodes != null)
                    foreach (var infoNode in otherInfoNodes)
                        productInfo.OtherInfo.Add(infoNode.InnerText.Trim());
            }
            else if (manufacturer.ToLower() == "dell")
            {
                productInfo.ImageUrl = doc.DocumentNode.SelectSingleNode("//div[@class='system-overview-header']//img")
                    ?.GetAttributeValue("src", "");
                productInfo.Model = doc.DocumentNode.SelectSingleNode("//h1[@label='product-name']")?.InnerText.Trim();
                productInfo.MachineTypeModel = "";
                productInfo.OtherInfo.Add("");
            }


            return productInfo;
        }

        private void DisplayProductInfo(ProductInfo productInfo)
        {
            modelLabel1.Text = productInfo.Model;
            infoDisplayTextBox.Text = productInfo.MachineTypeModel;
            if (!string.IsNullOrEmpty(productInfo.ImageUrl)) pictureBox1.Load(productInfo.ImageUrl);
            infoLabel1.Text = string.Join(Environment.NewLine, productInfo.OtherInfo);
        }


        private void BrightnessContrastForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            driver?.Quit();
        }

        private void manufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPositionsInfo();
        }


        private void FillPositionsInfo()
        {
            var selectedManufacturer = manufacturerComboBox1.SelectedItem.ToString();

            searchButton1.Enabled = false;
            serialNumberTextBox.Enabled = false;
            modelTextBox.Enabled = false;

            serialNumberTextBox.Clear();
            modelTextBox.Clear();

            switch (selectedManufacturer)
            {
                case "Lenovo":
                    serialNumberTextBox.Enabled = true;
                    break;
                case "Dell":
                    modelTextBox.Enabled = true;
                    break;
            }
        }

        private void modelTextBox_TextChanged(object sender, EventArgs e)
        {
            EnablingElements();
        }

        private void serialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            EnablingElements();
        }

        private void EnablingElements()
        {
            if ((serialNumberTextBox.Enabled && serialNumberTextBox.Text.Length >= 3) ||
                (modelTextBox.Enabled && modelTextBox.Text.Length >= 3))
                searchButton1.Enabled = true;
            else
                searchButton1.Enabled = false;
        }

        public class ProductInfo
        {
            public string Model { get; set; }
            public string MachineTypeModel { get; set; }
            public string ImageUrl { get; set; }
            public List<string> OtherInfo { get; set; } = new List<string>();
        }
    }
}