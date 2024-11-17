using FilmsManage.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.Services
{
    public class DangPhimSV
    {
        private readonly HttpClient _client;

        public DangPhimSV(string baseUrl)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            HttpResponseMessage response = await _client.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            T? result = await response.Content.ReadFromJsonAsync<T>();
            return result ?? throw new InvalidOperationException("Received null content from the API.");
        }
        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync(endpoint, content);
            string responseData = await response.Content.ReadAsStringAsync();

            // In thông tin chi tiết về phản hồi của API
            Debug.WriteLine("Response Status Code: " + response.StatusCode);
            Debug.WriteLine("Response Data: " + responseData);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(responseData) ?? throw new InvalidOperationException("Received null content from the API.");
            }
            else
            {
                var errorResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseData);
                string errorMessage = errorResponse != null && errorResponse.ContainsKey("message")
                    ? errorResponse["message"]
                    : "Đã xảy ra lỗi không xác định.";

                Debug.WriteLine("Error Message: " + errorMessage);
                throw new HttpRequestException($"Request failed with message: {errorMessage}");
            }
        }


        public async Task<T> PutAsync<T>(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PutAsync(endpoint, content);

            // Đọc nội dung trả về từ API dưới dạng chuỗi
            string responseData = await response.Content.ReadAsStringAsync();
            Debug.WriteLine("Response Data: " + responseData); // In ra nội dung trả về từ API

            if (response.IsSuccessStatusCode)
            {
                // Deserialize thành ApiResponse hoặc kiểu tương ứng nếu bạn chỉ cần thông điệp
                if (typeof(T) == typeof(string))
                {
                    return (T)(object)responseData;
                }
                return JsonConvert.DeserializeObject<T>(responseData) ?? throw new InvalidOperationException("Received null content from the API.");
            }
            else
            {
                // Nếu có lỗi, parse thông báo lỗi
                var errorResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseData);
                string errorMessage = errorResponse != null && errorResponse.ContainsKey("message")
                    ? errorResponse["message"]
                    : "Đã xảy ra lỗi không xác định.";

                throw new HttpRequestException($"Request failed with message: {errorMessage}");
            }
        }





        public async Task<bool> DeleteAsync(string endpoint)
        {
            HttpResponseMessage response = await _client.DeleteAsync(endpoint);
            return response.IsSuccessStatusCode;
        }
    }
}
