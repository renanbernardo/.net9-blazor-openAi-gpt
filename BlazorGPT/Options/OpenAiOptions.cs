namespace BlazorGPT.Options;

public class OpenAiOptions
{
    public string ApiKey { get; set; } = string.Empty;
    public string ModelChatClient { get; set; } = OpenAiModels.Gpt4o;
}
