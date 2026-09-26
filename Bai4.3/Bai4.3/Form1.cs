using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bai4._3
{
    public partial class Form1 : Form
    {
        private BindingList<ProductModel> productList = new BindingList<ProductModel>();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            if (dgvProducts == null) return;

            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Mã SP"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Tên sản phẩm"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Đơn giá"
            });

            dgvProducts.DataSource = productList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId == null || txtName == null || txtPrice == null) return;

            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);

            productList.Add(new ProductModel
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Price = price
            });

            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtId.Focus();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            {
                // 1. Kiểm tra ô trống
                if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên sản phẩm!", "Cảnh báo");
                    return;
                }

                // 2. Chuyển đổi giá tiền
                decimal price = 0;
                decimal.TryParse(txtPrice.Text, out price);

                // 3. Thêm sản phẩm vào BindingList -> DataGridView tự động cập nhật
                productList.Add(new ProductModel
                {
                    Id = txtId.Text,
                    Name = txtName.Text,
                    Price = price
                });

                // 4. Xóa trắng ô nhập dữ liệu
                txtId.Clear();
                txtName.Clear();
                txtPrice.Clear();
                txtId.Focus();
            }

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}