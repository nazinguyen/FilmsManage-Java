using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.Services
{
    public class DangPhimSV
    {
        private readonly RestClient _client;

        public DangPhimSV(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        // GET
        public async Task<T> GetAsync<T>(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);
            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful && response.Content != null)
            {
                return JsonConvert.DeserializeObject<T>(response.Content) ?? throw new InvalidOperationException("Received null content from the API.");
            }

            throw new HttpRequestException($"Request failed with status: {response.StatusCode}, message: {response.ErrorMessage}");
        }


        //GET WITH ID
        public async Task<T> GetAsync<T>(string endpoint, int id)
        {
            var request = new RestRequest($"{endpoint}/{id}", Method.Get);
            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful && response.Content != null)
            {
                return JsonConvert.DeserializeObject<T>(response.Content) ?? throw new InvalidOperationException("Received null content from the API.");
            }

            throw new HttpRequestException($"Request failed with status: {response.StatusCode}, message: {response.ErrorMessage}");
        }


        // POST
        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var request = new RestRequest(endpoint, Method.Post);
            request.AddJsonBody(data);

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful && response.Content != null)
            {
                return JsonConvert.DeserializeObject<T>(response.Content) ?? throw new InvalidOperationException("Received null content from the API.");
            }

            var errorResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content ?? "");
            string errorMessage = errorResponse != null && errorResponse.ContainsKey("message")
                ? errorResponse["message"]
                : "Đã xảy ra lỗi không xác định.";

            throw new HttpRequestException($"Request failed with message: {errorMessage}");
        }

        // PUT
        public async Task<T> PutAsync<T>(string endpoint, object data)
        {
            var request = new RestRequest(endpoint, Method.Put);
            request.AddJsonBody(data);

            Debug.WriteLine("Request: " + request.ToString());

            var response = await _client.ExecuteAsync(request);
            Debug.WriteLine("Response status: " + response.StatusCode);

            if (response.IsSuccessful && !string.IsNullOrWhiteSpace(response.Content))
            {
                Debug.WriteLine("Response content: " + response.Content);

                if (typeof(T) == typeof(string))
                {
                    return (T)(object)response.Content;
                }

                try
                {
                    return JsonConvert.DeserializeObject<T>(response.Content) ??
                           throw new InvalidOperationException("Nội dung phản hồi rỗng.");
                }
                catch (JsonException ex)
                {
                    Debug.WriteLine("Lỗi JSON: " + ex.Message);
                    throw;
                }
            }

            // Xử lý lỗi từ API
            var errorResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content ?? "");
            string errorMessage = errorResponse?.GetValueOrDefault("message") ?? "Lỗi không xác định.";

            Debug.WriteLine("Error message: " + errorMessage);
            throw new HttpRequestException(errorMessage);
        }

        public async Task<bool> DeleteAsync(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Delete);
            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }
    }
}
