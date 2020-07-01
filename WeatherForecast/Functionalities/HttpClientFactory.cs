using System.Net.Http;
using System.Net.Http.Headers;

namespace Functionalities
{
    public static class HttpClientFactory
    {
        public static HttpClient CreateClient()
        {
            var ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return ApiClient;
        }
    }
}