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
                FilmsManageDbContext context = new FilmsManageDbContext();
                var film = context.Ghes.ToList();

                // N?u k?t n?i th�nh c�ng v� truy v?n ???c d? li?u
                MessageBox.Show("K?t n?i c? s? d? li?u th�nh c�ng!", "Th�ng b�o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // N?u x?y ra l?i, hi?n th? th�ng b�o l?i
                MessageBox.Show("K?t n?i c? s? d? li?u th?t b?i: " + ex.Message, "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
