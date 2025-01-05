using FilmsManage.Helper;
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



        // Thêm token vào mỗi request
        private void AddToken(RestRequest request)
        {
            var loginResponse = TokenStorage.GetLoginResponse(); // Lấy thông tin đăng nhập
            if (loginResponse != null && !string.IsNullOrEmpty(loginResponse.Token))
            {
                Debug.WriteLine(loginResponse.Token);

                request.AddHeader("Authorization", $"Bearer {loginResponse.Token}"); // Thêm token vào header
            }
        }

        // GET

        public async Task<T> GetByObjectAsync<T>(string endpoint, object data)
        {
            var request = new RestRequest(endpoint, Method.Get);

            // Thêm dữ liệu vào query parameters
            if (data != null)
            {
                foreach (var property in data.GetType().GetProperties())
                {
                    var value = property.GetValue(data);
                    if (value != null)
                    {
                        request.AddQueryParameter(property.Name, value.ToString());
                    }
                }
            }

            // Thêm token vào request
            AddToken(request);

            // Gửi request
            var response = await _client.ExecuteAsync(request);

            // Xử lý kết quả trả về
            if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
            {
                try
                {
                    return JsonConvert.DeserializeObject<T>(response.Content)
                           ?? throw new InvalidOperationException("Received null or invalid content from the API.");
                }
                catch (JsonException ex)
                {
                    throw new InvalidOperationException($"Failed to deserialize response content: {ex.Message}");
                }
            }

            // Xử lý lỗi nếu request thất bại
            var errorMessage = string.IsNullOrEmpty(response.Content)
                ? "Đã xảy ra lỗi không xác định."
                : ExtractErrorMessage(response.Content);

            throw new HttpRequestException($"Request failed with status code {response.StatusCode}: {errorMessage}");
        }

        // Phương thức trích xuất thông báo lỗi từ JSON
        private string ExtractErrorMessage(string content)
        {
            try
            {
                var errorResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
                return errorResponse != null && errorResponse.ContainsKey("message")
                    ? errorResponse["message"]
                    : "Đã xảy ra lỗi không xác định.";
            }
            catch
            {
                return "Đã xảy ra lỗi không xác định.";
            }
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);
            AddToken(request); // Thêm token vào request
            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful && response.Content != null)
            {
                Console.WriteLine(response.Content); // In ra dữ liệu nhận được từ API

                return JsonConvert.DeserializeObject<T>(response.Content) ?? throw new InvalidOperationException("Received null content from the API.");
            }

            throw new HttpRequestException($"Request failed with status: {response.StatusCode}, message: {response.ErrorMessage}");
        }


        //GET WITH ID
        public async Task<T> GetAsync<T>(string endpoint, int id)
        {
            var request = new RestRequest($"{endpoint}/{id}", Method.Get);
            AddToken(request); // Thêm token vào request
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
            AddToken(request); // Thêm token vào request
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
            AddToken(request); // Thêm token vào request
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

        // DELETE
        public async Task<bool> DeleteAsync(string endpoint, object body = null)
        {
            var request = new RestRequest(endpoint, Method.Delete);
            AddToken(request); // Thêm token vào request

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }
        public async Task<T> DeleteByIdAsync<T>(string endpoint)
        {
            // Tạo request với phương thức DELETE
            var request = new RestRequest(endpoint, Method.Delete);

            // Thêm token vào request
            AddToken(request);

            try
            {
                // Thực hiện request
                var response = await _client.ExecuteAsync(request);

                // Kiểm tra nếu phản hồi thành công
                if (response.IsSuccessful)
                {
                    // Nếu T là kiểu string, trả về nội dung phản hồi
                    if (typeof(T) == typeof(string))
                        return (T)(object)response.Content;

                    // Nếu T không phải string, cố gắng parse nội dung
                    return JsonConvert.DeserializeObject<T>(response.Content);
                }

                // Nếu không thành công, ném ngoại lệ với thông tin lỗi
                throw new Exception($"Error: {response.StatusCode} - {response.Content}");
            }
            catch (Exception ex)
            {
                // Ghi log nếu cần hoặc ném ngoại lệ ra ngoài
                throw new Exception($"Lỗi khi gọi API: {ex.Message}", ex);
            }
        }


    }
}
