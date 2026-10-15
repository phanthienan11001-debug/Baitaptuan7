using QLSV.BLL;
using QLSV.DAL;

namespace QLSV.UI
{
    public partial class Form1 : Form
    {
        private readonly StudentBLL _studentBLL = new StudentBLL();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Sẵn sàng. Đang tải dữ liệu...";
            await TaiDanhSach();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        private async Task TaiDanhSach()
        {
            try
            {
                lblTrangThai.Text = "Đang tải dữ liệu...";
                button1.Enabled = false;

                var danhSach = await _studentBLL.LayDanhSachSinhVienAsync();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSach;

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["Id"]!.HeaderText = "Mã SV";
                    dataGridView1.Columns["FullName"]!.HeaderText = "Họ và tên";
                    dataGridView1.Columns["Grade"]!.HeaderText = "Điểm";
                }

                lblTrangThai.Text = $"Đã tải {danhSach.Count} sinh viên.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTrangThai.Text = "Tải dữ liệu thất bại.";
            }
            finally
            {
                button1.Enabled = true;
            }
        }
    }
}