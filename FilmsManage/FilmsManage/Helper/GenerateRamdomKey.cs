using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsManage.Helper
{
    public class GenerateRamdomKey
    {
        public static string GenerateRamdomKeyFunc(int length = 5)
        {
            var pattern = @"btttjafkwbskdjjsbdfsDNHD!@#";
            var sb = new StringBuilder();
            var rd = new Random(length);
            for (int i = 0; i < length; i++)
            {
                sb.Append(pattern[rd.Next(0, pattern.Length)]);
            }
            return sb.ToString();
        }

		public static string GetLastWord(string fullName)
		{
			if (string.IsNullOrWhiteSpace(fullName))
				return string.Empty;

			var words = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			return words.Last(); // Lấy từ cuối cùng
		}

	}
}
