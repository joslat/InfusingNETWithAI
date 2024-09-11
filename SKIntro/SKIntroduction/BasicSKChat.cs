using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace SKIntroduction;

public static class BasicSKChat
{
    public static async Task Execute()
    {
        var modelDeploymentName = "gpt-4o";
        var azureOpenAIEndpoint = Environment.GetEnvironmentVariable("AzureOpenAI_Endpoint");
        var azureOpenAIApiKey = Environment.GetEnvironmentVariable("AzureOpenAI_ApiKey");

        Kernel kernel = Kernel.CreateBuilder()
            .AddAzureOpenAIChatCompletion(
                modelDeploymentName,
                azureOpenAIEndpoint,
                azureOpenAIApiKey)
            .Build();
        kernel.ImportPluginFromType<WhatDateIsIt>();

        var chatService = kernel.GetRequiredService<IChatCompletionService>();
        ChatHistory chatHistory = new();

        var executionSettings = new OpenAIPromptExecutionSettings
        {
            ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions
        };

        bool exitnow = false;
        while (exitnow == false)
        {
            Console.WriteLine("Enter your question or type 'exit' to quit:");
            var userInput = Console.ReadLine();
            if (userInput == "exit")
            {
                Console.WriteLine($"Banana!!");
                exitnow = true;
            }
            else
            {
                chatHistory.AddUserMessage(userInput);

                var response = await chatService.GetChatMessageContentAsync(
                    chatHistory,
                    executionSettings,
                    kernel);

                Console.WriteLine(response.ToString());
                chatHistory.Add(response);
            }
        }
    }
}