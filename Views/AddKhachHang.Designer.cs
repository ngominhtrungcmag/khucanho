namespace KhuCanHo
{
    partial class AddKhachHang
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
            this.cmnd_themKhachHang = new System.Windows.Forms.TextBox();
            this.tenKhachHang_themKhachHang = new System.Windows.Forms.TextBox();
            this.maKhachHang_themKhachHang = new System.Windows.Forms.TextBox();
            this.button_thoat_AddKhachHang = new System.Windows.Forms.Button();
            this.button_them_AddKhachHang = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quaQuan_themKhachHang = new System.Windows.Forms.TextBox();
            this.soDienThoai_themKhachHang = new System.Windows.Forms.TextBox();
            this.checkBox_nam = new System.Windows.Forms.CheckBox();
            this.checkBox_nu = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmnd_themKhachHang
            // 
            this.cmnd_themKhachHang.Location = new System.Drawing.Point(167, 260);
            this.cmnd_themKhachHang.Name = "cmnd_themKhachHang";
            this.cmnd_themKhachHang.Size = new System.Drawing.Size(130, 20);
            this.cmnd_themKhachHang.TabIndex = 38;
            // 
            // tenKhachHang_themKhachHang
            // 
            this.tenKhachHang_themKhachHang.Location = new System.Drawing.Point(167, 119);
            this.tenKhachHang_themKhachHang.Name = "tenKhachHang_themKhachHang";
            this.tenKhachHang_themKhachHang.Size = new System.Drawing.Size(130, 20);
            this.tenKhachHang_themKhachHang.TabIndex = 36;
            this.tenKhachHang_themKhachHang.TextChanged += new System.EventHandler(this.tenKhachHang_themKhachHang_TextChanged);
            // 
            // maKhachHang_themKhachHang
            // 
            this.maKhachHang_themKhachHang.Location = new System.Drawing.Point(167, 85);
            this.maKhachHang_themKhachHang.Name = "maKhachHang_themKhachHang";
            this.maKhachHang_themKhachHang.Size = new System.Drawing.Size(130, 20);
            this.maKhachHang_themKhachHang.TabIndex = 35;
            this.maKhachHang_themKhachHang.TextChanged += new System.EventHandler(this.maKhachHang_themKhachHang_TextChanged);
            // 
            // button_thoat_AddKhachHang
            // 
            this.button_thoat_AddKhachHang.Location = new System.Drawing.Point(207, 352);
            this.button_thoat_AddKhachHang.Name = "button_thoat_AddKhachHang";
            this.button_thoat_AddKhachHang.Size = new System.Drawing.Size(90, 35);
            this.button_thoat_AddKhachHang.TabIndex = 34;
            this.button_thoat_AddKhachHang.Text = "Thoát";
            this.button_thoat_AddKhachHang.UseVisualStyleBackColor = true;
            this.button_thoat_AddKhachHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_thoat_AddKhachHang_MouseClick);
            // 
            // button_them_AddKhachHang
            // 
            this.button_them_AddKhachHang.Location = new System.Drawing.Point(93, 352);
            this.button_them_AddKhachHang.Name = "button_them_AddKhachHang";
            this.button_them_AddKhachHang.Size = new System.Drawing.Size(90, 35);
            this.button_them_AddKhachHang.TabIndex = 33;
            this.button_them_AddKhachHang.Text = "Thêm";
            this.button_them_AddKhachHang.UseVisualStyleBackColor = true;
            this.button_them_AddKhachHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_them_AddKhachHang_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "CMND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Quê quán";
            // 
            // quaQuan_themKhachHang
            // 
            this.quaQuan_themKhachHang.Location = new System.Drawing.Point(167, 293);
            this.quaQuan_themKhachHang.Name = "quaQuan_themKhachHang";
            this.quaQuan_themKhachHang.Size = new System.Drawing.Size(130, 20);
            this.quaQuan_themKhachHang.TabIndex = 41;
            // 
            // soDienThoai_themKhachHang
            // 
            this.soDienThoai_themKhachHang.Location = new System.Drawing.Point(167, 226);
            this.soDienThoai_themKhachHang.Name = "soDienThoai_themKhachHang";
            this.soDienThoai_themKhachHang.Size = new System.Drawing.Size(130, 20);
            this.soDienThoai_themKhachHang.TabIndex = 42;
            this.soDienThoai_themKhachHang.TextChanged += new System.EventHandler(this.soDienThoai_themKhachHang_TextChanged);
            // 
            // checkBox_nam
            // 
            this.checkBox_nam.AutoSize = true;
            this.checkBox_nam.Location = new System.Drawing.Point(167, 194);
            this.checkBox_nam.Name = "checkBox_nam";
            this.checkBox_nam.Size = new System.Drawing.Size(48, 17);
            this.checkBox_nam.TabIndex = 43;
            this.checkBox_nam.Text = "Nam";
            this.checkBox_nam.UseVisualStyleBackColor = true;
            this.checkBox_nam.CheckedChanged += new System.EventHandler(this.checkBox_nam_CheckedChanged);
            // 
            // checkBox_nu
            // 
            this.checkBox_nu.AutoSize = true;
            this.checkBox_nu.Location = new System.Drawing.Point(227, 194);
            this.checkBox_nu.Name = "checkBox_nu";
            this.checkBox_nu.Size = new System.Drawing.Size(40, 17);
            this.checkBox_nu.TabIndex = 44;
            this.checkBox_nu.Text = "Nữ";
            this.checkBox_nu.UseVisualStyleBackColor = true;
            this.checkBox_nu.CheckedChanged += new System.EventHandler(this.checkBox_nu_CheckedChanged);
            // 
            // dateTimePicker_ngaySinh
            // 
            this.dateTimePicker_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaySinh.Location = new System.Drawing.Point(167, 154);
            this.dateTimePicker_ngaySinh.Name = "dateTimePicker_ngaySinh";
            this.dateTimePicker_ngaySinh.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker_ngaySinh.TabIndex = 45;
            this.dateTimePicker_ngaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker_ngaySinh_ValueChanged);
            // 
            // AddKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.dateTimePicker_ngaySinh);
            this.Controls.Add(this.checkBox_nu);
            this.Controls.Add(this.checkBox_nam);
            this.Controls.Add(this.soDienThoai_themKhachHang);
            this.Controls.Add(this.quaQuan_themKhachHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmnd_themKhachHang);
            this.Controls.Add(this.tenKhachHang_themKhachHang);
            this.Controls.Add(this.maKhachHang_themKhachHang);
            this.Controls.Add(this.button_thoat_AddKhachHang);
            this.Controls.Add(this.button_them_AddKhachHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddKhachHang";
            this.Load += new System.EventHandler(this.AddKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cmnd_themKhachHang;
        private System.Windows.Forms.TextBox tenKhachHang_themKhachHang;
        private System.Windows.Forms.TextBox maKhachHang_themKhachHang;
        private System.Windows.Forms.Button button_thoat_AddKhachHang;
        private System.Windows.Forms.Button button_them_AddKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quaQuan_themKhachHang;
        private System.Windows.Forms.TextBox soDienThoai_themKhachHang;
        private System.Windows.Forms.CheckBox checkBox_nam;
        private System.Windows.Forms.CheckBox checkBox_nu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaySinh;
    }
}