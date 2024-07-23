using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using HtmlAgilityPack;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

namespace changeResolution1
{
    public partial class BrightnessContrastForm : Form
    {
        private IWebDriver driver;
        
        public BrightnessContrastForm()
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
            options.AddArgument("--headless");
            driver = new ChromeDriver(service, options); ;
            await FetchAndDisplayProductInfo(serialNumberTextBox.Text);

        }

        private async Task FetchAndDisplayProductInfo(string serialNumber)
        {
            try
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
                var productInfo = ParseProductInfo(pageSource);

                if (productInfo != null)
                {
                    modelLabel.Text = productInfo.Model;
                    machineTypeModelLabel.Text = productInfo.MachineTypeModel;
                    if (!string.IsNullOrEmpty(productInfo.ImageUrl))
                    {
                        pictureBox1.Load(productInfo.ImageUrl);
                    }
                    infoLabel.Text = string.Join(Environment.NewLine, productInfo.OtherInfo);
                }
                else
                {
                    modelLabel.Text = "Product information not found.";
                }
            }
            catch (Exception ex)
            {
                modelLabel.Text = $"Error: {ex.Message}";
            }
            finally
            {
                // Close WebDriver as soon as the information is displayed
                Console.WriteLine("Closing WebDriver...");
                driver.Quit();
            }
        }

        private ProductInfo ParseProductInfo(string html)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var productInfo = new ProductInfo
            {
                ImageUrl = doc.DocumentNode.SelectSingleNode("//div[@class='prod-img-area']//img")?.GetAttributeValue("src", ""),
                Model = doc.DocumentNode.SelectSingleNode("//h2[@class='new-product-name']")?.InnerText.Trim(),
                MachineTypeModel = doc.DocumentNode.SelectSingleNode("//div[@class='new-other-info-list'][1]")?.InnerText.Trim()
            };

            var otherInfoNodes = doc.DocumentNode.SelectNodes("//div[@class='new-other-info-list']");
            if (otherInfoNodes != null)
            {
                foreach (var infoNode in otherInfoNodes)
                {
                    productInfo.OtherInfo.Add(infoNode.InnerText.Trim());
                }
            }

            return productInfo;
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
            driver.Quit();
        }
    }
}
