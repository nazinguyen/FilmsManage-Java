using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using ClosedXML.Excel;

namespace FilmsManage.Services
{
    public class ExportSV
    {
        /// <summary>
        /// Xuất dữ liệu ra file Excel.
        /// </summary>
        /// <param name="dataTable">Dữ liệu cần xuất.</param>
        /// <param name="filePath">Đường dẫn file Excel sẽ lưu.</param>
        /// <returns>Trả về true nếu xuất thành công, ngược lại false.</returns>
        public bool ExportToExcel(DataTable dataTable, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Data");
                    worksheet.Cell(1, 1).InsertTable(dataTable);

                    // Lưu file
                    workbook.SaveAs(filePath);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xuất Excel: {ex.Message}");
                return false;
            }
        }
    }
}
