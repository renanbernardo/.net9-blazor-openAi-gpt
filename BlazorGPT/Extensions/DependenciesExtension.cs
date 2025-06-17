using BlazorGPT.Services.OpenAi;

namespace BlazorGPT.Extensions;

public static class DependenciesExtension
{
    public static void AddServices(this IServiceCollection services)
    {        
        services.AddScoped<IOpenAiChatService, OpenAiChatService>();
    }

    public static void AddConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<OpenAiOptions>(configuration.GetSection("OpenAI"));
    }
}