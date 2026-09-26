namespace bai4._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picAvatar = new PictureBox();
            btnChooseAvatar = new Button();
            label1 = new Label();
            txtName = new TextBox();
            btnExportCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(98, 111);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(150, 150);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            picAvatar.Click += pictureBox1_Click;
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Location = new Point(82, 282);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(188, 34);
            btnChooseAvatar.TabIndex = 1;
            btnChooseAvatar.Text = "Chọn ảnh Avatar";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 134);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "Họ và tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(482, 128);
            txtName.Name = "txtName";
            txtName.Size = new Size(261, 31);
            txtName.TabIndex = 3;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Location = new Point(444, 282);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(188, 34);
            btnExportCSV.TabIndex = 4;
            btnExportCSV.Text = "Xuất file CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 508);
            Controls.Add(btnExportCSV);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnChooseAvatar);
            Controls.Add(picAvatar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvatar;
        private Button btnChooseAvatar;
        private Label label1;
        private TextBox txtName;
        private Button btnExportCSV;
    }
}
