using MaterialSkin;
using MaterialSkin.Controls;
using ServiceMonitorEVK.Source.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceMonitorEVK.Source.Utils;

namespace ServiceMonitorEVK.Source
{
    public partial class AiForm : MaterialForm
    {
        private readonly OpenAIService openAiService;
        public AiForm()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            InitializeComponent();
            UiUtil uiUtil = new UiUtil(this);
            uiUtil.InitializeTheme();
            openAiService = new OpenAIService();
        }



        private async void btnSend_Click_1(object sender, EventArgs e)
        {
            string userMessage = textPrompt.Text;

            if (string.IsNullOrEmpty(userMessage))
            {
                MessageBox.Show(@"Please enter a message.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtChatHistory.AppendText($"User: {userMessage}\n");

            textPrompt.Clear();

            try
            {
                var response = await openAiService.GetResponseAsync(userMessage, switchIsInfoMonitor.Checked);
                Console.WriteLine("11111");
                txtChatHistory.AppendText($"Assistant: {response}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Error: {ex.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
