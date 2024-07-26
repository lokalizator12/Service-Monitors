﻿using OpenQA.Selenium;
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
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class SearchInformationForm : Form
    {
        private IWebDriver driver;

        public SearchInformationForm()
        {
            InitializeComponent();
        }

        private void BrightnessContrastForm_Load(object sender, EventArgs e)
        {

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            modelLabel.Text = "Loading...";
            machineTypeModelLabel.Text = "";
            pictureBox1.Image = null;
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(service, options);
            await FetchAndDisplayProductInfo(manufacturerComboBox.Text);

        }

        private async Task FetchAndDisplayProductInfo(string manufacturer)
        {
            string model = modelTextBox.Text;
            string serialNumber = serialNumberTextBox.Text;
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
                        modelLabel.Text = "Manufacturer not supported.";
                        return;
                }
            }
            catch (Exception ex)
            {
                modelLabel.Text = $"Error: {ex.Message}";
            }
            finally
            {
                Console.WriteLine("Closing WebDriver...");
                driver.Quit();
            }
        }

        private async Task FetchLenovoProductInfo(string serialNumber)
        {
            driver.Navigate().GoToUrl("https://pcsupport.lenovo.com/pl/pl");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

            var serialNumberInput = wait.Until(drv => drv.FindElement(By.CssSelector("input[type='text']")));
            serialNumberInput.SendKeys(serialNumber);

            var searchButton = wait.Until(drv => drv.FindElement(By.CssSelector("span.icon-search")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", searchButton);

            wait.Until(drv => drv.FindElement(By.CssSelector("div.prod-img-area")));
            wait.Until(drv => drv.FindElement(By.CssSelector("h2.new-product-name")));

            string pageSource = driver.PageSource;
            var productInfo = ParseProductInfo(pageSource, "lenovo");

            if (productInfo != null)
            {
                DisplayProductInfo(productInfo);
            }
            else
            {
                modelLabel.Text = "Product information not found.";
            }
        }

        private async Task FetchDellProductInfo(string model)
        {
            try
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

                driver.Navigate().GoToUrl("https://dl.dell.com/manuals/all-products/esuprt_electronics_accessories/esuprt_electronics_accessories_monitors/");

                // Ищем нужный PDF файл по модели и английскому языку
                var pdfLink = wait.Until(drv => drv.FindElement(By.XPath($"//a[contains(@href, \"dell-{model.ToLower()}\") and contains(@href, \"User's-Guide\") and contains(@href, \"en-us\")]")));
                string pdfUrl = pdfLink.GetAttribute("href");
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", pdfLink);

                ////////////////////////////////////////
                driver.Navigate().GoToUrl("https://www.dell.com/support/home/en-us");


                wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));

                // Найдем поле ввода по его ID и классу
                var serialNumberInput = wait.Until(drv => drv.FindElement(By.CssSelector("input#homemfe-dropdown-input.dds__dropdown__input-field")));

                // Используем Actions для ввода текста в поле
                Actions actions = new Actions(driver);
                actions.MoveToElement(serialNumberInput).Click().SendKeys("DELL " + model).Perform();

                // Подтверждаем ввод, так как на сайте может быть авто-комплит
                serialNumberInput.SendKeys(OpenQA.Selenium.Keys.Enter);



                // Ожидаем загрузки результатов

                Console.WriteLine("1");

                var imageElement = wait.Until(drv => drv.FindElement(By.CssSelector("img#imgV1PDBSysDescription")));
                Console.WriteLine("2");
                string imageUrl = imageElement.GetAttribute("src");
                Console.WriteLine("3");
                pictureBox1.Load(imageUrl);
                Console.WriteLine("4");
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

        private string ExtractProductFeaturesFromPdf(string pdfText)
        {
            string cleanText = "";

            Debug.WriteLine("Extracted PDF Text:\n" + pdfText);
            string pattern = @"Product Features\nThe.*?Identifying Parts and Controls";
            Debug.WriteLine("Extracted pattern:\n" + pattern);

            Match match = Regex.Match(pdfText, pattern, RegexOptions.Singleline);
            if (!match.Success)
            {
                pattern = @"Product Features\nThe.*?About your monitor";
                match = Regex.Match(pdfText, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                Debug.WriteLine("Extracted pattern:\n" + pattern);
                Debug.WriteLine("Extracted match:\n" + match);
            }
            if (match.Success)
            {
                string extractedText = match.Value;
                cleanText = CleanText(extractedText);
                Debug.WriteLine("RESULT:\n" + cleanText);
            }
            else
            {
                Debug.WriteLine("Product Features not found in PDF.");
            }
            return cleanText;
        }
        static string CleanText(string input)
        {
            string cleaned = Regex.Replace(input, @"[^\u0000-\u007F]+", string.Empty);
            cleaned = cleaned.Replace("v", "").Trim();
            cleaned = Regex.Replace(cleaned, @"\s+", " ");
            cleaned = cleaned.Replace(". ", ".\n");
            return cleaned;
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


        private ProductInfo ParseProductInfo(string html, string manufacturer)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var productInfo = new ProductInfo();

            if (manufacturer.ToLower() == "lenovo")
            {
                productInfo.ImageUrl = doc.DocumentNode.SelectSingleNode("//div[@class='prod-img-area']//img")?.GetAttributeValue("src", "");
                productInfo.Model = doc.DocumentNode.SelectSingleNode("//h2[@class='new-product-name']")?.InnerText.Trim();
                productInfo.MachineTypeModel = doc.DocumentNode.SelectSingleNode("//div[@class='new-other-info-list'][1]")?.InnerText.Trim();
                var otherInfoNodes = doc.DocumentNode.SelectNodes("//div[@class='new-other-info-list']");
                if (otherInfoNodes != null)
                {
                    foreach (var infoNode in otherInfoNodes)
                    {
                        productInfo.OtherInfo.Add(infoNode.InnerText.Trim());
                    }
                }
            }
            else if (manufacturer.ToLower() == "dell")
            {
                productInfo.ImageUrl = doc.DocumentNode.SelectSingleNode("//div[@class='system-overview-header']//img")?.GetAttributeValue("src", "");
                productInfo.Model = doc.DocumentNode.SelectSingleNode("//h1[@label='product-name']")?.InnerText.Trim();
                productInfo.MachineTypeModel = "";
                productInfo.OtherInfo.Add("");
            }

            // Add parsing logic for other manufacturers here

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

        public class ProductInfo
        {
            public string Model { get; set; }
            public string MachineTypeModel { get; set; }
            public string ImageUrl { get; set; }
            public List<string> OtherInfo { get; set; } = new List<string>();
        }



        private void BrightnessContrastForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        private void manufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedManufacturer = manufacturerComboBox.SelectedItem.ToString();

            searchButton.Enabled = false;
            serialNumberTextBox.Enabled = false;
            modelTextBox.Enabled = false;

            serialNumberTextBox.Clear();
            modelTextBox.Clear();

            if (selectedManufacturer == "Lenovo")
            {
                serialNumberTextBox.Enabled = true;
            }
            else if (selectedManufacturer == "Dell")
            {
                modelTextBox.Enabled = true;
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
            {
                searchButton.Enabled = true;
            }
            else
            {
                searchButton.Enabled = false;
            }
        }









        /*


                 void Main1()
                {
                    try
                    {
                        string serviceTag = GetDellMonitorServiceTag();
                        if (!string.IsNullOrEmpty(serviceTag))
                        {
                            Console.WriteLine("Dell Monitor Service Tag: " + serviceTag);
                        }
                        else
                        {
                            Console.WriteLine("Service Tag not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

                static string GetDellMonitorServiceTag()
                {
                    string serviceTag = null;
                    ManagementScope scope = new ManagementScope(@"\\.\root\wmi");
                    ObjectQuery query = new ObjectQuery("SELECT * FROM WmiMonitorID");

                    using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
                    using (ManagementObjectCollection results = searcher.Get())
                    {
                        foreach (ManagementObject obj in results)
                        {
                            string manufacturerName = GetStringFromUInt16Array((ushort[])obj["ManufacturerName"]);
                            if (manufacturerName.ToLower().Contains("dell"))
                            {
                                serviceTag = GetStringFromUInt16Array((ushort[])obj["SerialNumberID"]);
                                break;
                            }
                        }
                    }

                    return serviceTag;
                }

                static string GetStringFromUInt16Array(ushort[] ushortArray)
                {
                    if (ushortArray == null)
                        return null;

                    char[] chars = new char[ushortArray.Length];
                    for (int i = 0; i < ushortArray.Length; i++)
                    {
                        chars[i] = (char)ushortArray[i];
                    }
                    return new string(chars).Trim();
                }
        */
    }

}