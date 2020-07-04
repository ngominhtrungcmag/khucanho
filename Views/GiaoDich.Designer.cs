namespace KhuCanHo
{
    partial class GiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_timKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_xoa_giaoDich = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_sua_GiaoDich = new System.Windows.Forms.Button();
            this.button_them_GiaoDich = new System.Windows.Forms.Button();
            this.dataGridView_GiaoDich = new System.Windows.Forms.DataGridView();
            this.maHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_timKiem = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.comboBox_timKiem);
            this.panel1.Controls.Add(this.textBox_timKiem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_xoa_giaoDich);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_sua_GiaoDich);
            this.panel1.Controls.Add(this.button_them_GiaoDich);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 100);
            this.panel1.TabIndex = 7;
            // 
            // textBox_timKiem
            // 
            this.textBox_timKiem.Location = new System.Drawing.Point(705, 69);
            this.textBox_timKiem.Name = "textBox_timKiem";
            this.textBox_timKiem.Size = new System.Drawing.Size(134, 20);
            this.textBox_timKiem.TabIndex = 10;
            this.textBox_timKiem.TextChanged += new System.EventHandler(this.textBox_timKiem_GiaoDich_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BackgroundImage = global::KhuCanHo.Properties.Resources.round_local_atm_white_48dp1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(18, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 70);
            this.panel2.TabIndex = 1;
            // 
            // button_xoa_giaoDich
            // 
            this.button_xoa_giaoDich.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_xoa_giaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa_giaoDich.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_xoa_giaoDich.Location = new System.Drawing.Point(614, 64);
            this.button_xoa_giaoDich.Name = "button_xoa_giaoDich";
            this.button_xoa_giaoDich.Size = new System.Drawing.Size(75, 25);
            this.button_xoa_giaoDich.TabIndex = 8;
            this.button_xoa_giaoDich.Text = "Xoá";
            this.button_xoa_giaoDich.UseVisualStyleBackColor = false;
            this.button_xoa_giaoDich.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_xoa_giaoDich_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(92, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao dịch";
            // 
            // button_sua_GiaoDich
            // 
            this.button_sua_GiaoDich.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_sua_GiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua_GiaoDich.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_sua_GiaoDich.Location = new System.Drawing.Point(531, 65);
            this.button_sua_GiaoDich.Name = "button_sua_GiaoDich";
            this.button_sua_GiaoDich.Size = new System.Drawing.Size(75, 25);
            this.button_sua_GiaoDich.TabIndex = 7;
            this.button_sua_GiaoDich.Text = "Sửa";
            this.button_sua_GiaoDich.UseVisualStyleBackColor = false;
            this.button_sua_GiaoDich.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_sua_GiaoDich_MouseClick);
            // 
            // button_them_GiaoDich
            // 
            this.button_them_GiaoDich.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_them_GiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_GiaoDich.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_them_GiaoDich.Location = new System.Drawing.Point(446, 65);
            this.button_them_GiaoDich.Name = "button_them_GiaoDich";
            this.button_them_GiaoDich.Size = new System.Drawing.Size(75, 25);
            this.button_them_GiaoDich.TabIndex = 2;
            this.button_them_GiaoDich.Text = "Thêm";
            this.button_them_GiaoDich.UseVisualStyleBackColor = false;
            this.button_them_GiaoDich.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_them_GiaoDich_MouseClick);
            // 
            // dataGridView_GiaoDich
            // 
            this.dataGridView_GiaoDich.AllowUserToAddRows = false;
            this.dataGridView_GiaoDich.AllowUserToDeleteRows = false;
            this.dataGridView_GiaoDich.AllowUserToOrderColumns = true;
            this.dataGridView_GiaoDich.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_GiaoDich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_GiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GiaoDich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHopDong,
            this.maKhachHang,
            this.maNhanVien,
            this.maCanHo,
            this.ngayGiaoDich});
            this.dataGridView_GiaoDich.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_GiaoDich.Location = new System.Drawing.Point(1, 109);
            this.dataGridView_GiaoDich.MultiSelect = false;
            this.dataGridView_GiaoDich.Name = "dataGridView_GiaoDich";
            this.dataGridView_GiaoDich.ReadOnly = true;
            this.dataGridView_GiaoDich.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_GiaoDich.RowHeadersVisible = false;
            this.dataGridView_GiaoDich.Size = new System.Drawing.Size(977, 358);
            this.dataGridView_GiaoDich.TabIndex = 8;
            this.dataGridView_GiaoDich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GiaoDich_CellClick);
            this.dataGridView_GiaoDich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GiaoDich_CellContentClick);
            // 
            // maHopDong
            // 
            this.maHopDong.DataPropertyName = "maHopDong";
            this.maHopDong.HeaderText = "Mã hợp đồng";
            this.maHopDong.Name = "maHopDong";
            this.maHopDong.ReadOnly = true;
            this.maHopDong.Width = 200;
            // 
            // maKhachHang
            // 
            this.maKhachHang.DataPropertyName = "maKhachHang";
            this.maKhachHang.HeaderText = "Mã Khách Hàng";
            this.maKhachHang.Name = "maKhachHang";
            this.maKhachHang.ReadOnly = true;
            this.maKhachHang.Width = 200;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Width = 200;
            // 
            // maCanHo
            // 
            this.maCanHo.DataPropertyName = "maCanHo";
            this.maCanHo.HeaderText = "Mã căn hộ";
            this.maCanHo.Name = "maCanHo";
            this.maCanHo.ReadOnly = true;
            this.maCanHo.Width = 200;
            // 
            // ngayGiaoDich
            // 
            this.ngayGiaoDich.DataPropertyName = "ngayGiaoDich";
            this.ngayGiaoDich.HeaderText = "Ngày giao dịch";
            this.ngayGiaoDich.Name = "ngayGiaoDich";
            this.ngayGiaoDich.ReadOnly = true;
            this.ngayGiaoDich.Width = 200;
            // 
            // comboBox_timKiem
            // 
            this.comboBox_timKiem.AutoCompleteCustomSource.AddRange(new string[] {
            "Mã hợp đồng",
            "Mã khách hàng",
            "Mã nhân viên",
            "Mã căn hộ",
            "Ngày giao dịch"});
            this.comboBox_timKiem.FormattingEnabled = true;
            this.comboBox_timKiem.Location = new System.Drawing.Point(845, 69);
            this.comboBox_timKiem.Name = "comboBox_timKiem";
            this.comboBox_timKiem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_timKiem.TabIndex = 11;
            // 
            // GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView_GiaoDich);
            this.Controls.Add(this.panel1);
            this.Name = "GiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giao dịch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiaoDich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_xoa_giaoDich;
        private System.Windows.Forms.Button button_sua_GiaoDich;
        private System.Windows.Forms.Button button_them_GiaoDich;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_GiaoDich;
        private System.Windows.Forms.TextBox textBox_timKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGiaoDich;
        private System.Windows.Forms.ComboBox comboBox_timKiem;
    }
}