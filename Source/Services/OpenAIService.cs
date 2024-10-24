using OpenAI_API;
using OpenAI_API.Chat;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace ServiceMonitorEVK.Source.Services
{
    public class OpenAIService
    {
        private readonly OpenAIAPI _api;

        public OpenAIService()
        {

            string encryptedApiKey = ConfigurationManager.AppSettings["OpenAI:ApiKey"];
            string encryptionIv = ConfigurationManager.AppSettings["Encryption:IV"];
            string encryptionKey = ConfigurationManager.AppSettings["Encryption:Key"];
            Console.WriteLine($"API Key: {encryptedApiKey}");
            Console.WriteLine($"Encryption IV: {encryptionIv}");
            Console.WriteLine($"Encryption Key: {encryptionKey}");
            if (string.IsNullOrEmpty(encryptedApiKey) || string.IsNullOrEmpty(encryptionIv) || string.IsNullOrEmpty(encryptionKey))
            {
                throw new InvalidOperationException("API key or encryption parameters are missing.");
            }
            string apiKey = DecryptApiKey(encryptedApiKey, encryptionKey, encryptionIv);
            Console.WriteLine($"Encryption apiKey: {apiKey}");
            APIAuthentication aPIAuthentication = new APIAuthentication(apiKey);
            _api = new OpenAIAPI(aPIAuthentication);
        }





        string DecryptApiKey(string cipherText, string key, string iv)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }




        public async Task<string> GetResponseAsync(string prompt, bool isInfoMonitors)
        {
            ChatRequest chatRequest;

            if (isInfoMonitors)
            {
                // When the switch is on, the query is specifically for monitor information
                chatRequest = new ChatRequest
                {
                    Model = "gpt-4o",
                    Messages = new[]
                    {
                        new ChatMessage(ChatMessageRole.System, """

                                                                You are an assistant that provides **detailed monitor specifications** in a structured format. For each query, use information **primarily from the official manufacturer sources** or technical specification sheets from authorized sources. If no official source is found, refer to other credible sources such as review websites.
                                                                
                                                                Return the following information in the specified format:
                                                                1. Panel type
                                                                2. Screen size in inches
                                                                3. Video input ports (separate each port with a semicolon `;`)
                                                                4. Screen resolution
                                                                5. Screen format (aspect ratio)
                                                                6. Brightness (in nits)
                                                                7. Response time (in ms)
                                                                8. Viewing angles (in degrees)
                                                                9. Refresh rate (in Hz) (if there's a range, use the highest value in Hz)
                                                                10. Weight (only double)
                                                                11. Dimensions with stand (in cm) (provide width, height, and depth, including the stand)
                                                                
                                                                For any missing data fields, use 'N/A' if information is unavailable. Ensure the response format follows the structure strictly.
                                                                
                                                                The response should be formatted as follows:
                                                                'PanelType, ScreenSize, InputPorts, Resolution, AspectRatio, Brightness, ResponseTime, ViewingAngles, RefreshRate, Weight, Dimensions'.
                                                                
                                                                Use `;` to separate multiple video input ports in the 'InputPorts' field.
                                                                
                                                                Example:
                                                                IPS, 23, VGA x1; HDMI x2, 1920x1080, 16:9, 250 nits, 5ms, 178/178, 60Hz, 3.5, 52x31x18
                                                                
                                                                No additional text.
                                                                No dot in ends.
                                                                
                                                                """)
{
                        },                        new ChatMessage(ChatMessageRole.User, prompt)
                    },
                    MaxTokens = 1000, // Limit the response length
                    Temperature = 0.0, // Make responses deterministic
                    NumChoicesPerMessage = 1
                };
            }
            else
            {
                // When the switch is off, handle general queries
                chatRequest = new ChatRequest
                {
                    Model = "gpt-4o-mini",
                    Messages = new[]
                    {
                        new ChatMessage(ChatMessageRole.System, "You are a helpful assistant."),
                        new ChatMessage(ChatMessageRole.User, prompt)
                    },
                    MaxTokens = 100, // Allow for longer responses
                    Temperature = 0.7, // Allow for some creativity in responses
                    NumChoicesPerMessage = 1
                };
            }

            var result = await _api.Chat.CreateChatCompletionAsync(chatRequest);

            return result.Choices[0].Message.Content.Trim();
        }

    }
}