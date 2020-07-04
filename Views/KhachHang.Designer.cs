namespace KhuCanHo
{
    partial class KhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_timKiem = new System.Windows.Forms.TextBox();
            this.button_DelKhachHang = new System.Windows.Forms.Button();
            this.button_sua_KhachHang = new System.Windows.Forms.Button();
            this.button_them_KhachHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_KhachHang = new System.Windows.Forms.DataGridView();
            this.maKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_timKiem = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.comboBox_timKiem);
            this.panel1.Controls.Add(this.textBox_timKiem);
            this.panel1.Controls.Add(this.button_DelKhachHang);
            this.panel1.Controls.Add(this.button_sua_KhachHang);
            this.panel1.Controls.Add(this.button_them_KhachHang);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 100);
            this.panel1.TabIndex = 7;
            // 
            // textBox_timKiem
            // 
            this.textBox_timKiem.Location = new System.Drawing.Point(677, 65);
            this.textBox_timKiem.Name = "textBox_timKiem";
            this.textBox_timKiem.Size = new System.Drawing.Size(140, 20);
            this.textBox_timKiem.TabIndex = 9;
            this.textBox_timKiem.TextChanged += new System.EventHandler(this.textBox_timKiem_TextChanged);
            // 
            // button_DelKhachHang
            // 
            this.button_DelKhachHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_DelKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DelKhachHang.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_DelKhachHang.Location = new System.Drawing.Point(585, 62);
            this.button_DelKhachHang.Name = "button_DelKhachHang";
            this.button_DelKhachHang.Size = new System.Drawing.Size(75, 25);
            this.button_DelKhachHang.TabIndex = 8;
            this.button_DelKhachHang.Text = "Xoá";
            this.button_DelKhachHang.UseVisualStyleBackColor = false;
            this.button_DelKhachHang.Click += new System.EventHandler(this.button_DelKhachHang_Click);
            // 
            // button_sua_KhachHang
            // 
            this.button_sua_KhachHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_sua_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua_KhachHang.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_sua_KhachHang.Location = new System.Drawing.Point(503, 62);
            this.button_sua_KhachHang.Name = "button_sua_KhachHang";
            this.button_sua_KhachHang.Size = new System.Drawing.Size(75, 25);
            this.button_sua_KhachHang.TabIndex = 7;
            this.button_sua_KhachHang.Text = "Sửa";
            this.button_sua_KhachHang.UseVisualStyleBackColor = false;
            this.button_sua_KhachHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_sua_KhachHang_MouseClick);
            // 
            // button_them_KhachHang
            // 
            this.button_them_KhachHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_them_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_KhachHang.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_them_KhachHang.Location = new System.Drawing.Point(418, 63);
            this.button_them_KhachHang.Name = "button_them_KhachHang";
            this.button_them_KhachHang.Size = new System.Drawing.Size(75, 25);
            this.button_them_KhachHang.TabIndex = 2;
            this.button_them_KhachHang.Text = "Thêm";
            this.button_them_KhachHang.UseVisualStyleBackColor = false;
            this.button_them_KhachHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_them_KhachHang_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BackgroundImage = global::KhuCanHo.Properties.Resources.round_contact_phone_white_48dp1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(18, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 70);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(92, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_KhachHang);
            this.panel3.Location = new System.Drawing.Point(2, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 293);
            this.panel3.TabIndex = 8;
            // 
            // dataGridView_KhachHang
            // 
            this.dataGridView_KhachHang.AccessibleName = "dataGridView_KhachHang";
            this.dataGridView_KhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHang,
            this.tenKhachHang,
            this.ngaySinh,
            this.gioiTinh,
            this.soDienThoai,
            this.soCMND,
            this.queQuan});
            this.dataGridView_KhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView_KhachHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_KhachHang.MultiSelect = false;
            this.dataGridView_KhachHang.Name = "dataGridView_KhachHang";
            this.dataGridView_KhachHang.RowHeadersVisible = false;
            this.dataGridView_KhachHang.Size = new System.Drawing.Size(970, 287);
            this.dataGridView_KhachHang.TabIndex = 0;
            this.dataGridView_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KhachHang_CellClick);
            this.dataGridView_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KhachHang_CellContentClick);
            // 
            // maKhachHang
            // 
            this.maKhachHang.DataPropertyName = "maKhachHang";
            this.maKhachHang.HeaderText = "Mã Khách Hàng";
            this.maKhachHang.Name = "maKhachHang";
            this.maKhachHang.Width = 120;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "Tên Khách Hàng";
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.Width = 200;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.Name = "ngaySinh";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "Số Điện Thoại";
            this.soDienThoai.Name = "soDienThoai";
            // 
            // soCMND
            // 
            this.soCMND.DataPropertyName = "soCMND";
            this.soCMND.HeaderText = "Số CMND";
            this.soCMND.Name = "soCMND";
            this.soCMND.Width = 150;
            // 
            // queQuan
            // 
            this.queQuan.DataPropertyName = "queQuan";
            this.queQuan.HeaderText = "Quê Quán";
            this.queQuan.Name = "queQuan";
            this.queQuan.Width = 200;
            // 
            // comboBox_timKiem
            // 
            this.comboBox_timKiem.FormattingEnabled = true;
            this.comboBox_timKiem.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Ngày sinh",
            "Giới tính",
            "Số điện thoại",
            "Số CMND",
            "Quê quán"});
            this.comboBox_timKiem.Location = new System.Drawing.Point(823, 65);
            this.comboBox_timKiem.Name = "comboBox_timKiem";
            this.comboBox_timKiem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_timKiem.TabIndex = 10;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khách hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_DelKhachHang;
        private System.Windows.Forms.Button button_sua_KhachHang;
        private System.Windows.Forms.Button button_them_KhachHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuan;
        private System.Windows.Forms.TextBox textBox_timKiem;
        private System.Windows.Forms.ComboBox comboBox_timKiem;
    }
}