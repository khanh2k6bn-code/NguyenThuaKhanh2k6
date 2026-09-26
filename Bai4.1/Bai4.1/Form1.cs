using System;
using System.Windows.Forms;

namespace bai4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            // Ép kiểu sender về Button
            Button btn = sender as Button;

            if (btn != null)
            {
                // Xóa số 0 ban đầu nếu có
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "";
                }

                // Nối chữ số của nút vừa bấm vào ô TextBox
                textBox1.Text += btn.Text;
            }
        }
    }
}