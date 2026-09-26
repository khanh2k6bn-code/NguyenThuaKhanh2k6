namespace bai4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                // 1. Xóa tất cả các thông báo lỗi cũ trên Form
                errorProvider1.Clear();

                bool hasError = false;

                // 2. Kiểm tra ô Họ tên có bị để trống hay không
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Vui lòng nhập họ và tên học viên!");
                    hasError = true;
                }

                // 3. Nếu không có lỗi thì thông báo thành công
                if (!hasError)
                {
                    MessageBox.Show("Đăng ký thông tin học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
