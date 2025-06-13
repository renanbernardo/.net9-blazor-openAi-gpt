using BlazorGPT.Options;
using Microsoft.Extensions.Options;
using OpenAI.Chat;

namespace BlazorGPT.Services.OpenAi;

public class OpenAiChatService
{
    private readonly ChatClient _chatClient; 

    public OpenAiChatService(IOptions<OpenAiOptions> options, ChatClient chatClient) 
    {
        _chatClient = chatClient; 
    }
}
