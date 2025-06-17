namespace BlazorGPT.Services.OpenAi;

internal class OpenAiOptions
{
    public string ApiKey { get; set; } = string.Empty;
    public string ModelChatClient { get; set; } = OpenAiModels.Gpt41Nano;
}
