using BlazorGPT.Options;
using BlazorGPT.Services.OpenAi;
using Microsoft.Extensions.Options;
using OpenAI.Chat;

namespace BlazorGPT.Extensions;

public static class DependenciesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<ChatClient>(sp =>
        {
            var options = sp.GetRequiredService<IOptions<OpenAiOptions>>().Value;
            if (string.IsNullOrWhiteSpace(options.ApiKey))
            {
                throw new InvalidOperationException("OpenAI API key is not configured.");
            }
            return new ChatClient(model: options.ModelChatClient, apiKey: options.ApiKey);
        });
        services.AddScoped<IOpenAiChatService, OpenAiChatService>();
    }

    public static void AddConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<OpenAiOptions>(configuration.GetSection("OpenAI"));
    }
}