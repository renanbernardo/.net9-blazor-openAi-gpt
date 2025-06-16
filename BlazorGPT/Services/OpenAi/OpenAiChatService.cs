using BlazorGPT.Interfaces.Services.OpenAi;
using OpenAI.Chat;

namespace BlazorGPT.Services.OpenAi;

public class OpenAiChatService : IOpenAiChatService
{
    private readonly ChatClient _chatClient; 

    public OpenAiChatService(ChatClient chatClient) 
    {
        _chatClient = chatClient; 
    }
}
