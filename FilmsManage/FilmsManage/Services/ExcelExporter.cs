

using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;

public class ExcelExporter
{

    public void ExportDataGridViewToExcel(DataGridView dataGridView)
    {
        // Khởi tạo SaveFileDialog để cho phép người dùng chọn vị trí và tên file
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            // Thiết lập các thuộc tính của SaveFileDialog
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;

            // Hiển thị hộp thoại lưu file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Tạo workbook mới
                using (var workbook = new XLWorkbook())
                {
                    // Tạo một worksheet mới trong workbook
                    var worksheet = workbook.AddWorksheet("Sheet1");

                    // Lấy tiêu đề cột từ DataGridView và ghi vào Excel
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dataGridView.Columns[col].HeaderText; // Đặt tiêu đề cột
                    }

                    // Lấy dữ liệu từ DataGridView và điền vào Excel
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        // Đảm bảo không lấy dữ liệu từ dòng mới (dòng trống cuối cùng)
                        if (!dataGridView.Rows[row].IsNewRow)
                        {
                            for (int col = 0; col < dataGridView.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col + 1).Value = dataGridView.Rows[row].Cells[col].Value?.ToString();
                            }
                        }
                    }

                    // Lưu workbook vào file Excel
                    workbook.SaveAs(filePath);
                }

                // Thông báo cho người dùng rằng dữ liệu đã được xuất thành công
                MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
        // Hàm xuất dữ liệu từ ListView ra file Excel
        public void ExportListViewToExcel(ListView listView)
        {
            // Khởi tạo SaveFileDialog để cho phép người dùng chọn vị trí và tên file
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Thiết lập các thuộc tính của SaveFileDialog
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.AddExtension = true;

                // Hiển thị hộp thoại lưu file
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Tạo workbook mới
                    using (var workbook = new XLWorkbook())
                    {
                        // Tạo một worksheet mới trong workbook
                        var worksheet = workbook.AddWorksheet("Sheet1");

                        // Lấy tiêu đề cột từ ListView và ghi vào Excel
                        for (int col = 0; col < listView.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = listView.Columns[col].Text; // Đặt tiêu đề cột
                        }

                        // Lấy dữ liệu từ ListView và điền vào Excel
                        for (int row = 0; row < listView.Items.Count; row++)
                        {
                            for (int col = 0; col < listView.Columns.Count; col++)
                            {
                                var item = listView.Items[row];
                                var cellValue = item.SubItems[col].Text;

                                // Kiểm tra xem giá trị có phải là DateTime không
                                if (DateTime.TryParse(cellValue, out DateTime dateValue))
                                {
                                    worksheet.Cell(row + 2, col + 1).Value = dateValue;

                                    // Áp dụng định dạng ngày/tháng/giờ cho ô chứa thời gian
                                    worksheet.Cell(row + 2, col + 1).Style.DateFormat.Format = "yyyy-mm-dd hh:mm:ss";
                                }
                                else
                                {
                                    worksheet.Cell(row + 2, col + 1).Value = cellValue; // Ghi giá trị chuỗi nếu không phải thời gian
                                }
                            }
                        }

                        // Lưu workbook vào file Excel
                        workbook.SaveAs(filePath);
                    }

                    // Thông báo cho người dùng rằng dữ liệu đã được xuất thành công
                    MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
}
