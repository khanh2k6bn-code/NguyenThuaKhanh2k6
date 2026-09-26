using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace bai4._4
{
    public partial class Form1 : Form
    {
        private string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Nút Chọn ảnh Avatar
        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*";
                openFileDialog.Title = "Chọn ảnh Avatar";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    if (picAvatar != null)
                    {
                        picAvatar.ImageLocation = selectedImagePath;
                    }
                }
            }
        }

        // 2. Nút Xuất file CSV
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (txtName == null || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên trước khi xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.Title = "Chọn nơi lưu file CSV";
                saveFileDialog.FileName = "ThongTinNguoiDung.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder csvContent = new StringBuilder();
                        csvContent.AppendLine("HoTen,DuongDanAvatar");
                        csvContent.AppendLine($"\"{txtName.Text}\",\"{selectedImagePath}\"");

                        File.WriteAllText(saveFileDialog.FileName, csvContent.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất file CSV thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Hàm chống lỗi khi lỡ click vào PictureBox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnChooseAvatar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnExportCSV_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}