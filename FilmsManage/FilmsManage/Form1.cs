using FilmsManage.Models.Entities;

namespace FilmsManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FilmManageContext context = new FilmManageContext();
                var film = context.Ghes.ToList();

                // N?u k?t n?i thành công và truy v?n ???c d? li?u
                MessageBox.Show("K?t n?i c? s? d? li?u thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // N?u x?y ra l?i, hi?n th? thông báo l?i
                MessageBox.Show("K?t n?i c? s? d? li?u th?t b?i: " + ex.Message, "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
