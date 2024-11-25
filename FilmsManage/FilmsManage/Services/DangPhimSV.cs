using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;

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
            Debug.WriteLine(request.ToString()); // In yêu cầu gửi đi

            var response = await _client.ExecuteAsync(request);
            Debug.WriteLine("Response status: " + response.StatusCode); // In trạng thái HTTP

            // Kiểm tra nếu phản hồi thành công và có nội dung
            if (response.IsSuccessful && response.Content != null)
            {
                Debug.WriteLine("Response Content: " + response.Content); // In nội dung trả về từ API

                if (typeof(T) == typeof(string))
                {
                    return (T)(object)response.Content;
                }

                try
                {
                    return JsonConvert.DeserializeObject<T>(response.Content) ??
                           throw new InvalidOperationException("Received null content from the API.");
                }
                catch (JsonException ex)
                {
                    // Nếu có lỗi phân tích cú pháp JSON
                    Debug.WriteLine("Error parsing JSON: " + ex.Message);
                    throw;
                }
            }

            // Xử lý khi yêu cầu không thành công
            var errorResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content ?? "");
            string errorMessage = errorResponse != null && errorResponse.ContainsKey("message")
                ? errorResponse["message"]
                : "Đã xảy ra lỗi không xác định.";

            throw new HttpRequestException($"Request failed with message: {errorMessage}");
        }

        // DELETE
        public async Task<bool> DeleteAsync(string endpoint, object body = null)
        {
            var request = new RestRequest(endpoint, Method.Delete);

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

    }
}
