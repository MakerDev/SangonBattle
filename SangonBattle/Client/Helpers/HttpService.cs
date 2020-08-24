using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SangonBattle.Client.Helpers
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions _defaultJsonOptions =>
            new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseWrapper<T>> GetAsync<T>(string url)
        {
            var responseHttp = await _httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await Deserialize<T>(responseHttp, _defaultJsonOptions);
                return new HttpResponseWrapper<T>(response, true, responseHttp);
            }

            return new HttpResponseWrapper<T>(default, false, responseHttp);
        }


        public async Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, encoding: Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, stringContent);

            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
        }

        public async Task<HttpResponseWrapper<TResponse>> PostAsync<T, TResponse>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, encoding: Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var responseDeserailized = await Deserialize<TResponse>(response, _defaultJsonOptions);
                return new HttpResponseWrapper<TResponse>(responseDeserailized, true, response);
            }

            return new HttpResponseWrapper<TResponse>(default, false, response);
        }

        public async Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, encoding: Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(url, stringContent);

            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
        }

        private async Task<T> Deserialize<T>(HttpResponseMessage httpResponseMessage, JsonSerializerOptions options)
        {
            var responseString = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, options);
        }

        public async Task<HttpResponseWrapper<object>> DeleteAsync(string url)
        {
            var responseHttp = await _httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, responseHttp.IsSuccessStatusCode, responseHttp);
        }
    }
}
