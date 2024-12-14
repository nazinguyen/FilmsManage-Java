using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FilmsAPI.Models;
using FilmsManage.Models;



namespace FilmsManage.Helper
{
    public class TokenStorage
    {
        private static readonly string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "nhanvien.json");

        // Lưu đối tượng LoginResponse vào file
        public static void SaveLoginResponse(LoginResponse response)
        {
            string json = JsonConvert.SerializeObject(response); // Chuyển đổi đối tượng thành chuỗi JSON
            File.WriteAllText(FilePath, json); // Ghi chuỗi JSON vào file
        }

        // Lấy đối tượng LoginResponse từ file
        public static LoginResponse GetLoginResponse()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath); // Đọc chuỗi JSON từ file
                return JsonConvert.DeserializeObject<LoginResponse>(json); // Chuyển chuỗi JSON thành đối tượng LoginResponse
            }
            return null; // Trả về null nếu file không tồn tại
        }

        // Xóa thông tin đăng nhập (đăng xuất)
        public static void DeleteLoginResponse()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath); // Xóa file chứa thông tin đăng nhập
            }
        }

    }
}
