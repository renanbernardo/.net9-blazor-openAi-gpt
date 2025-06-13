using BlazorGPT.Options;
using Microsoft.Extensions.Options;
using OpenAI.Chat;

namespace BlazorGPT.Services.OpenAi;

public class OpenAiChatService
{
    private readonly string _apiKey;
    private readonly ChatClient _chatClient;

    public OpenAiChatService(IOptions<OpenAiOptions> options)
    {
        _apiKey = options.Value.ApiKey;
        _chatClient = new ChatClient(model: "gpt-4o", apiKey: _apiKey);
    }
}
