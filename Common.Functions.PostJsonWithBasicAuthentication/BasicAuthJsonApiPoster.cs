using System.Net.Http;
using System.Threading.Tasks;

namespace Common.Functions.PostJsonWithBasicAuthentication
{
    public static class BasicAuthJsonApiPoster
    {
        public static async Task<HttpResponseMessage> Post(ApiRequest request, BasicAuthenticationCredentials credentials)
        {
            using (var client = new HttpClient { BaseAddress = request.BaseAddress })
            {
                client.DefaultRequestHeaders.Authorization = credentials.Header;
                return await client.SendAsync(request.Message);
            }
        }
    }
}
