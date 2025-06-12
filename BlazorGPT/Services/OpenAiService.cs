using BlazorGPT.Options;
using Microsoft.Extensions.Options;

namespace BlazorGPT.Services
{
    public class OpenAiService
    {
        private readonly string _apiKey;

        public OpenAiService(IOptions<OpenAiOptions> options)
        {
            _apiKey = options.Value.ApiKey;
        }
    }
}
