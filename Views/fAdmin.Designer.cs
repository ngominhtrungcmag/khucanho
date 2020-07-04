namespace KhuCanHo.Views
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.load_acount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_DelAccount = new System.Windows.Forms.Button();
            this.button_EditAccount = new System.Windows.Forms.Button();
            this.button_addAccount = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGirdView_taiKhoan = new System.Windows.Forms.DataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdView_taiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.load_acount);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 565);
            this.panel1.TabIndex = 0;
            // 
            // load_acount
            // 
            this.load_acount.AccessibleName = "load_acount";
            this.load_acount.BackColor = System.Drawing.Color.Khaki;
            this.load_acount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.load_acount.Cursor = System.Windows.Forms.Cursors.Default;
            this.load_acount.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_acount.ForeColor = System.Drawing.Color.Black;
            this.load_acount.Location = new System.Drawing.Point(12, 11);
            this.load_acount.Name = "load_acount";
            this.load_acount.Size = new System.Drawing.Size(182, 69);
            this.load_acount.TabIndex = 0;
            this.load_acount.Text = "Tài khoản nhân viên";
            this.load_acount.UseVisualStyleBackColor = false;
            this.load_acount.Click += new System.EventHandler(this.load_acount_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.button_DelAccount);
            this.panel2.Controls.Add(this.button_EditAccount);
            this.panel2.Controls.Add(this.button_addAccount);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.dataGirdView_taiKhoan);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(213, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 565);
            this.panel2.TabIndex = 1;
            // 
            // button_DelAccount
            // 
            this.button_DelAccount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_DelAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DelAccount.FlatAppearance.BorderSize = 0;
            this.button_DelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DelAccount.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_DelAccount.Location = new System.Drawing.Point(598, 135);
            this.button_DelAccount.Name = "button_DelAccount";
            this.button_DelAccount.Size = new System.Drawing.Size(75, 25);
            this.button_DelAccount.TabIndex = 5;
            this.button_DelAccount.Text = "Xóa";
            this.button_DelAccount.UseVisualStyleBackColor = false;
            this.button_DelAccount.Click += new System.EventHandler(this.button_DelAccount_Click);
            // 
            // button_EditAccount
            // 
            this.button_EditAccount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_EditAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_EditAccount.FlatAppearance.BorderSize = 0;
            this.button_EditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditAccount.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_EditAccount.Location = new System.Drawing.Point(503, 135);
            this.button_EditAccount.Name = "button_EditAccount";
            this.button_EditAccount.Size = new System.Drawing.Size(75, 25);
            this.button_EditAccount.TabIndex = 4;
            this.button_EditAccount.Text = "Sửa";
            this.button_EditAccount.UseVisualStyleBackColor = false;
            this.button_EditAccount.Click += new System.EventHandler(this.button_EditAccount_Click);
            // 
            // button_addAccount
            // 
            this.button_addAccount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_addAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_addAccount.FlatAppearance.BorderSize = 0;
            this.button_addAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addAccount.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_addAccount.Location = new System.Drawing.Point(408, 135);
            this.button_addAccount.Name = "button_addAccount";
            this.button_addAccount.Size = new System.Drawing.Size(75, 25);
            this.button_addAccount.TabIndex = 3;
            this.button_addAccount.Text = "Thêm";
            this.button_addAccount.UseVisualStyleBackColor = false;
            this.button_addAccount.Click += new System.EventHandler(this.button_addAccount_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(363, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Tìm kiếm";
            // 
            // dataGirdView_taiKhoan
            // 
            this.dataGirdView_taiKhoan.AccessibleName = "dataGirdView_taiKhoan";
            this.dataGirdView_taiKhoan.AllowUserToAddRows = false;
            this.dataGirdView_taiKhoan.AllowUserToDeleteRows = false;
            this.dataGirdView_taiKhoan.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGirdView_taiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGirdView_taiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirdView_taiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.hoTen,
            this.ngaySinh,
            this.gioiTinh,
            this.soDienThoai,
            this.diaChi,
            this.soCMND,
            this.luongCung,
            this.vaiTro,
            this.maKhau});
            this.dataGirdView_taiKhoan.Location = new System.Drawing.Point(3, 176);
            this.dataGirdView_taiKhoan.Name = "dataGirdView_taiKhoan";
            this.dataGirdView_taiKhoan.ReadOnly = true;
            this.dataGirdView_taiKhoan.RowHeadersVisible = false;
            this.dataGirdView_taiKhoan.Size = new System.Drawing.Size(767, 389);
            this.dataGirdView_taiKhoan.TabIndex = 0;
            this.dataGirdView_taiKhoan.Click += new System.EventHandler(this.dataGirdView_taiKhoan_Click);
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ và tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 120;
            // 
            // soCMND
            // 
            this.soCMND.DataPropertyName = "soCMND";
            this.soCMND.HeaderText = "số CMND";
            this.soCMND.Name = "soCMND";
            this.soCMND.ReadOnly = true;
            this.soCMND.Width = 90;
            // 
            // luongCung
            // 
            this.luongCung.DataPropertyName = "luongCung";
            this.luongCung.HeaderText = "Lương";
            this.luongCung.Name = "luongCung";
            this.luongCung.ReadOnly = true;
            this.luongCung.Width = 55;
            // 
            // vaiTro
            // 
            this.vaiTro.DataPropertyName = "vaiTro";
            this.vaiTro.HeaderText = "Vai trò";
            this.vaiTro.Name = "vaiTro";
            this.vaiTro.ReadOnly = true;
            this.vaiTro.Visible = false;
            this.vaiTro.Width = 50;
            // 
            // maKhau
            // 
            this.maKhau.DataPropertyName = "maKhau";
            this.maKhau.HeaderText = "Mật khẩu";
            this.maKhau.Name = "maKhau";
            this.maKhau.ReadOnly = true;
            this.maKhau.Visible = false;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Space";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdView_taiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGirdView_taiKhoan;
        private System.Windows.Forms.Button load_acount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_DelAccount;
        private System.Windows.Forms.Button button_EditAccount;
        private System.Windows.Forms.Button button_addAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhau;
    }
}