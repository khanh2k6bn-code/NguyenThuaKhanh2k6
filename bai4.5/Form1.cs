using System;
using System.Windows.Forms;

namespace bai4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi click vào Menu "Mở Form Đăng Ký"
        private void mởFormĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo Form con
            FormRegister childForm = new FormRegister();

            // 2. Gán Form chính này (this) làm Form cha (MdiParent) cho Form con
            childForm.MdiParent = this;

            // 3. Hiển thị Form con lên (nằm gọn bên trong khung Form cha)
            childForm.Show();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mởFormĐăngKýToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // 1. Tạo mới Form con (FormRegister)
            FormRegister childForm = new FormRegister();

            // 2. Đặt FormMain này làm Form cha của nó
            childForm.MdiParent = this;

            // 3. Hiển thị Form con lên
            childForm.Show();
        }
    }
}