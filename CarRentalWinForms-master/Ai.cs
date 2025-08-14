using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
namespace WinFormsApp1
{
    public partial class Ai : Form
    {
        Kernel kernel;
        OpenAIPromptExecutionSettings openAIPromptExecutionSettings;
        private string userInput = null;
        public Ai()
        {
            InitializeComponent();
            // Populate values from your OpenAI deployment
            var modelId = "openai/gpt-4.1";
            var endpoint = new Uri("https://models.github.ai/inference");
            var apiKey = "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";

            // Create a kernel with Azure OpenAI chat completion
            var builder = Kernel.CreateBuilder().AddOpenAIChatCompletion(modelId, endpoint, apiKey);

            // Add enterprise components
            //builder.Services.AddLogging(services => services.AddConsole().SetMinimumLevel(LogLevel.Trace));

            // Build the kernel
            kernel = builder.Build();

            // Add a plugin (the LightsPlugin class is defined below)
            kernel.Plugins.AddFromType<Car>("car");
            //kernel.Plugins.AddFromType<FileManager>("fileManager");


            // Enable planning
            openAIPromptExecutionSettings = new()
            {
                FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
            };
        }
        async public void aiChat()
        {
            var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
            var history = new ChatHistory();
                        
            // Add user input
            history.AddUserMessage(userInput);

            // Get the response from the AI
            var result = await chatCompletionService.GetChatMessageContentAsync(
                history,
                executionSettings: openAIPromptExecutionSettings,
                kernel: kernel);

            textBox2.Text = result.ToString();  

            // Add the message from the agent to the chat history
            history.AddMessage(result.Role, result.Content ?? string.Empty);

        }

        private void Ai_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInput = textBox1.Text;            
            if (userInput != null)
            {
                aiChat();
            }
            userInput = null;
            textBox1.Text = "";
        }
    }
}
