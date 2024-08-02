using MaterialSkin.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.Content.Objects;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace changeResolution1
{
    public partial class MonitorInfoSerachForm : MaterialForm
    {
        private IWebDriver driver;

        public MonitorInfoSerachForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("lenovo");
            comboBox1.Items.Add("dell");
        }





        public async Task<string> GetEdidInfoAsync()
        {
            StringBuilder edidInfo = new StringBuilder();

            try
            {
                await Task.Run(() =>
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");

                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        var instanceName = queryObj["InstanceName"].ToString();
                        var yearOfManufacture = queryObj["YearOfManufacture"].ToString();
                        var weekOfManufacture = queryObj["WeekOfManufacture"].ToString();
                        var serialNumberID = queryObj["SerialNumberID"];
                        var userFriendlyName = queryObj["UserFriendlyName"];
                        var manufacturerName = queryObj["ManufacturerName"];
                        var productCodeID = queryObj["ProductCodeID"];

                        edidInfo.AppendLine("Instance Name: " + instanceName + "\n");
                        edidInfo.AppendLine("Year Of Manufacture: " + yearOfManufacture + "\n");
                        edidInfo.AppendLine("Week Of Manufacture: " + weekOfManufacture + "\n");

                        if (serialNumberID is ushort[] serialNumber)
                        {
                            edidInfo.AppendLine("Serial Number: " + string.Join("", serialNumber.Select(s => ((char)s).ToString())) + "\n");
                        }

                        if (userFriendlyName is ushort[] name)
                        {
                            edidInfo.AppendLine("User Friendly Name: " + string.Join("", name.Select(s => ((char)s).ToString())) + "\n");
                        }

                        if (manufacturerName is ushort[] manufacturer)
                        {
                            edidInfo.AppendLine("Manufacturer Name: " + string.Join("", manufacturer.Select(s => ((char)s).ToString())) + "\n");
                        }

                        if (productCodeID is ushort[] productCode)
                        {
                            edidInfo.AppendLine("Product Code ID: " + string.Join("", productCode.Select(p => p.ToString("X"))) + "\n");
                        }

                        edidInfo.AppendLine("\n");
                    }
                });
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }

            return edidInfo.ToString();
        }

        private int ExtractYearOfManufacture(string edidInfo)
        {
            // Extract the year of manufacture from the EDID info string
            string[] lines = edidInfo.Split(new[] { "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (line.StartsWith("Year Of Manufacture:"))
                {
                    return int.Parse(line.Replace("Year Of Manufacture:", "").Trim());
                }
            }
            return -1;
        }

        private string ExtractServiceTag(string edidInfo)
        {
            // Extract the service tag from the EDID info string
            string[] lines = edidInfo.Split(new[] { "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (line.StartsWith("Serial Number:"))
                {
                    return line.Replace("Serial Number:", "").Trim();
                }
            }
            return null;
        }

        private string ExtractModel(string edidInfo)
        {
            // Extract the model from the EDID info string
            string[] lines = edidInfo.Split(new[] { "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (line.StartsWith("User Friendly Name:"))
                {
                    return line.Replace("User Friendly Name:", "").Trim();
                }
            }
            return null;
        }

        private async Task FetchAndDisplayProductInfoByServiceTag(string serviceTag)
        {
            driver.Navigate().GoToUrl("https://www.dell.com/support/home/en-us");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

            // Найдем поле ввода по его ID и классу
            var serialNumberInput = wait.Until(drv => drv.FindElement(By.CssSelector("input#homemfe-dropdown-input.dds__dropdown__input-field")));

            // Используем Actions для ввода текста в поле
            Actions actions = new Actions(driver);
            actions.MoveToElement(serialNumberInput).Click().SendKeys(serviceTag).Perform();

            // Подтверждаем ввод, так как на сайте может быть авто-комплит
            serialNumberInput.SendKeys(OpenQA.Selenium.Keys.Enter);

            // Найдем кнопку поиска и нажмем ее
            var searchButton = wait.Until(drv => drv.FindElement(By.CssSelector("button#btnSubmit.dds__button--md")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", searchButton);

            // Ожидаем загрузки результатов
            wait.Until(drv => drv.FindElement(By.CssSelector("div.system-overview-header")));
            wait.Until(drv => drv.FindElement(By.CssSelector("h1.system-title")));


            var documentationTab = wait.Until(drv => drv.FindElement(By.CssSelector("a#docs.nav-link.text-break")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", documentationTab);

            string pageSource = driver.PageSource;
            var productInfo = ParseProductInfo(pageSource);

            if (productInfo != null)
            {
                DisplayProductInfo(productInfo);
            }
            else
            {
                modelLabel.Text = "Product information not found.";
            }
        }



        private async Task FetchAndDisplayProductInfoByModel(string model)
        {
            try
            {
                /* driver.Navigate().GoToUrl("https://www.dell.com/support/home/en-us");

                 WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                 wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

                 // Найдем поле ввода по его ID и классу
                 var modelInput = wait.Until(drv => drv.FindElement(By.CssSelector("input#homemfe-dropdown-input.dds__dropdown__input-field")));
                 Actions actions = new Actions(driver);
                 actions.MoveToElement(modelInput).Click().SendKeys(model).Perform();

                 // Подтверждаем ввод, так как на сайте может быть авто-комплит
                 modelInput.SendKeys(OpenQA.Selenium.Keys.Enter);


                 // Найдем кнопку поиска и нажмем ее
                 var searchButton = wait.Until(drv => drv.FindElement(By.CssSelector("button#btnSubmit.dds__button dds__button--md")));
                 ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", searchButton);
     */
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

                driver.Navigate().GoToUrl("https://dl.dell.com/manuals/all-products/esuprt_electronics_accessories/esuprt_electronics_accessories_monitors/");

                // Ищем нужный PDF файл по модели и английскому языку
                var pdfLink = wait.Until(drv => drv.FindElement(By.XPath($"//a[contains(@href, \"dell-{model.ToLower()}_\") and contains(@href, \"User's-Guide\") and contains(@href, \"en-us\")]")));
                string pdfUrl = pdfLink.GetAttribute("href");
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", pdfLink);

                ////////////////////////////////////////
                driver.Navigate().GoToUrl("https://www.dell.com/support/home/en-us");


                wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

                // Найдем поле ввода по его ID и классу
                var serialNumberInput = wait.Until(drv => drv.FindElement(By.CssSelector("input#homemfe-dropdown-input.dds__dropdown__input-field")));

                // Используем Actions для ввода текста в поле
                Actions actions = new Actions(driver);
                actions.MoveToElement(serialNumberInput).Click().SendKeys(model).Perform();

                // Подтверждаем ввод, так как на сайте может быть авто-комплит
                serialNumberInput.SendKeys(OpenQA.Selenium.Keys.Enter);

                // Найдем кнопку поиска и нажмем ее
                var searchButton = wait.Until(drv => drv.FindElement(By.CssSelector("button#btnSubmit.dds__button--md")));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", searchButton);

                // Ожидаем загрузки результатов
                wait.Until(drv => drv.FindElement(By.CssSelector("div.system-overview-header")));
                wait.Until(drv => drv.FindElement(By.CssSelector("h1.system-title")));

                var imageElement = wait.Until(drv => drv.FindElement(By.CssSelector("img#imgV1PDBSysDescription")));
                string imageUrl = imageElement.GetAttribute("src");

                // Загрузим изображение в PictureBox
                var image = await LoadImageFromUrlAsync(imageUrl);
                if (image != null)
                {
                    pictureBox1.Image = image;
                }

                var pdfText = await ExtractPdfTextAsync(pdfUrl);

                if (pdfText != null)
                {
                    modelLabel.Text = model;
                    machineTypeModelLabel.Text = pdfText;
                }
                else
                {
                    modelLabel.Text = "Product features not found in PDF.";
                }
            }
            catch (Exception ex)
            {
                modelLabel.Text = $"Error: {ex.Message}";
            }
            finally
            {
                driver.Quit();
            }
        }
        private async Task<Image> LoadImageFromUrlAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        return Image.FromStream(stream);
                    }
                }
                else
                {
                    return null;
                }
            }
        }
        private ProductInfo ParseProductInfo(string html)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var productInfo = new ProductInfo();

            productInfo.ImageUrl = doc.DocumentNode.SelectSingleNode("//div[@class='system-overview-header']//img")?.GetAttributeValue("src", "");
            productInfo.Model = doc.DocumentNode.SelectSingleNode("//h1[@class='system-title']")?.InnerText.Trim();
            productInfo.MachineTypeModel = doc.DocumentNode.SelectSingleNode("//div[@class='system-model']")?.InnerText.Trim();
            var otherInfoNodes = doc.DocumentNode.SelectNodes("//div[@class='system-overview']");
            if (otherInfoNodes != null)
            {
                foreach (var infoNode in otherInfoNodes)
                {
                    productInfo.OtherInfo.Add(infoNode.InnerText.Trim());
                }
            }

            return productInfo;
        }

        private void DisplayProductInfo(ProductInfo productInfo)
        {
            modelLabel.Text = productInfo.Model;
            machineTypeModelLabel.Text = productInfo.MachineTypeModel;
            if (!string.IsNullOrEmpty(productInfo.ImageUrl))
            {
                pictureBox1.Load(productInfo.ImageUrl);
            }
            infoLabel.Text = string.Join(Environment.NewLine, productInfo.OtherInfo);
        }

        private async Task<string> ExtractPdfTextAsync(string pdfUrl)
        {
            StringBuilder textBuilder = new StringBuilder();
            Debug.WriteLine("Extracted PDF 2222: ");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/pdf"));

                    using (HttpResponseMessage response = await client.GetAsync(pdfUrl))
                    using (Stream pdfStream = await response.Content.ReadAsStreamAsync())
                    {
                        using (PdfDocument document = PdfReader.Open(pdfStream, PdfDocumentOpenMode.ReadOnly))
                        {
                            for (int pageNumber = 0; pageNumber < document.PageCount; pageNumber++)
                            {
                                PdfPage page = document.Pages[pageNumber];
                                CObject content = ContentReader.ReadContent(page);
                                ExtractText(content, textBuilder);
                            }

                            Console.WriteLine(textBuilder.ToString());

                            return ExtractProductFeaturesFromPdf(textBuilder.ToString());
                        }
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("HTTP Request error: " + ex.Message);
                Debug.WriteLine("HTTP Request error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error extracting PDF text: " + ex.Message);
                Debug.WriteLine("Error extracting PDF text: " + ex.Message);
            }
            return null;
        }



        static void ExtractText(CObject cObject, StringBuilder textBuilder)
        {
            if (cObject is COperator)
            {
                COperator cOperator = cObject as COperator;
                if (cOperator.OpCode.Name == OpCodeName.Tj.ToString() ||
                    cOperator.OpCode.Name == OpCodeName.TJ.ToString())
                {
                    textBuilder.Append("\n");
                    foreach (CObject cOperand in cOperator.Operands)
                    {

                        if (cOperand is CSequence)
                        {
                            foreach (CObject item in (cOperand as CSequence))
                            {
                                if (item is CString)
                                {
                                    textBuilder.Append((item as CString).Value);
                                }

                            }

                        }
                        else if (cOperand is CString)
                        {
                            textBuilder.Append((cOperand as CString).Value);
                        }

                    }
                    // textBuilder.Append("\n");
                }
            }
            else if (cObject is CArray)
            {
                foreach (CObject item in (cObject as CArray))
                {
                    ExtractText(item, textBuilder);
                }
            }
            else if (cObject is CSequence)
            {
                foreach (CObject item in (cObject as CSequence))
                {
                    ExtractText(item, textBuilder);
                }
            }
        }
        static string CleanText(string input)
        {
            string cleaned = Regex.Replace(input, @"[^\u0000-\u007F]+", string.Empty);

            // Удаляем символы начала строки и лишние пробелы
            cleaned = cleaned.Replace("v", "").Trim();

            // Удаляем лишние пробелы и символы перевода строки
            cleaned = Regex.Replace(cleaned, @"\s+", " ");

            // Форматируем для улучшения читабельности
            cleaned = cleaned.Replace(". ", ".\n");

            return cleaned;
        }
        private string ExtractProductFeaturesFromPdf(string pdfText)
        {
            string cleanText = "";
            Debug.WriteLine("Extracted PDF Text:\n" + pdfText);

            // Используем регулярные выражения для поиска нужных частей текста
            string pattern = @"Product Features\nThe.*?\nIdentifying Parts and Controls";
            Match match = Regex.Match(pdfText, pattern, RegexOptions.Singleline);

            if (match.Success)
            {
                string extractedText = match.Value;
                // Очистка текста от нечитаемых символов
                cleanText = CleanText(extractedText);
                Debug.WriteLine("RESULT:\n" + cleanText);
            }
            else
            {
                Debug.WriteLine("Product Features not found in PDF.");
            }
            return cleanText;
        }

        static string ExtractTextFromContent(CObject content)
        {
            StringBuilder text = new StringBuilder();

            if (content is COperator)
            {
                var op = content as COperator;

                if (op.OpCode.Name == OpCodeName.Tj.ToString() || op.OpCode.Name == OpCodeName.TJ.ToString())
                {
                    foreach (CObject cObject in op.Operands)
                    {
                        if (cObject is CString)
                        {
                            var str = cObject as CString;
                            text.Append(str.Value);
                        }
                    }
                }
            }
            else if (content is CSequence)
            {
                var seq = content as CSequence;

                foreach (CObject cObject in seq)
                {
                    text.Append(ExtractTextFromContent(cObject));
                }
            }

            return text.ToString();
        }
        public class ProductInfo
        {
            public string Model { get; set; }
            public string MachineTypeModel { get; set; }
            public string ImageUrl { get; set; }
            public List<string> OtherInfo { get; set; } = new List<string>();
        }

        private void MonitorInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            driver.Quit();
        }

        private async void searchButton_Click_1(object sender, EventArgs e)
        {
            modelLabel.Text = "Loading...";
            machineTypeModelLabel.Text = "Loading...";
            pictureBox1.Image = null;
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            // options.AddArgument("--headless");
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(service, options);
            string serialNumber = serialNumberTextBox.Text;

            string edidInfo = await GetEdidInfoAsync();
            int yearOfManufacture = ExtractYearOfManufacture(edidInfo);
            await FetchAndDisplayProductInfoByModel(serialNumber); ///delete
           /* if (yearOfManufacture >= 2016)
            {
                string serviceTag = ExtractServiceTag(edidInfo);
                MessageBox.Show("bb");
                await FetchAndDisplayProductInfoByServiceTag(serialNumber);
                
            }
            else
            {
                MessageBox.Show("aa");
                string model = ExtractModel(edidInfo);
                await FetchAndDisplayProductInfoByModel(serialNumber);
            }*/
        }
    }
}

