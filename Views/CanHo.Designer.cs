namespace KhuCanHo
{
    partial class CanHo
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
            this.comboBox_timKiem = new System.Windows.Forms.ComboBox();
            this.textBox_timCanHo = new System.Windows.Forms.TextBox();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua_CanHo = new System.Windows.Forms.Button();
            this.button_them_CanHo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_canHo = new System.Windows.Forms.DataGridView();
            this.maCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_canHo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.comboBox_timKiem);
            this.panel1.Controls.Add(this.textBox_timCanHo);
            this.panel1.Controls.Add(this.button_xoa);
            this.panel1.Controls.Add(this.button_sua_CanHo);
            this.panel1.Controls.Add(this.button_them_CanHo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 3;
            // 
            // comboBox_timKiem
            // 
            this.comboBox_timKiem.AllowDrop = true;
            this.comboBox_timKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_timKiem.FormattingEnabled = true;
            this.comboBox_timKiem.Items.AddRange(new object[] {
            "Mã khu căn hộ",
            "Mã căn hộ",
            "Diện tích",
            "Giá bán",
            "Trạng thái",
            "Số phòng"});
            this.comboBox_timKiem.Location = new System.Drawing.Point(804, 65);
            this.comboBox_timKiem.Name = "comboBox_timKiem";
            this.comboBox_timKiem.Size = new System.Drawing.Size(140, 21);
            this.comboBox_timKiem.TabIndex = 11;
            // 
            // textBox_timCanHo
            // 
            this.textBox_timCanHo.Location = new System.Drawing.Point(641, 64);
            this.textBox_timCanHo.Multiline = true;
            this.textBox_timCanHo.Name = "textBox_timCanHo";
            this.textBox_timCanHo.Size = new System.Drawing.Size(157, 25);
            this.textBox_timCanHo.TabIndex = 10;
            this.textBox_timCanHo.TextChanged += new System.EventHandler(this.textBox_timCanHo_TextChanged);
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_xoa.Location = new System.Drawing.Point(538, 64);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 25);
            this.button_xoa.TabIndex = 8;
            this.button_xoa.Text = "Xoá";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_xoa_MouseClick);
            // 
            // button_sua_CanHo
            // 
            this.button_sua_CanHo.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_sua_CanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua_CanHo.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_sua_CanHo.Location = new System.Drawing.Point(458, 64);
            this.button_sua_CanHo.Name = "button_sua_CanHo";
            this.button_sua_CanHo.Size = new System.Drawing.Size(75, 25);
            this.button_sua_CanHo.TabIndex = 7;
            this.button_sua_CanHo.Text = "Sửa";
            this.button_sua_CanHo.UseVisualStyleBackColor = false;
            this.button_sua_CanHo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_sua_CanHo_MouseClick);
            // 
            // button_them_CanHo
            // 
            this.button_them_CanHo.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_them_CanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_CanHo.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_them_CanHo.Location = new System.Drawing.Point(377, 65);
            this.button_them_CanHo.Name = "button_them_CanHo";
            this.button_them_CanHo.Size = new System.Drawing.Size(75, 25);
            this.button_them_CanHo.TabIndex = 2;
            this.button_them_CanHo.Text = "Thêm";
            this.button_them_CanHo.UseVisualStyleBackColor = false;
            this.button_them_CanHo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_them_CanHo_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BackgroundImage = global::KhuCanHo.Properties.Resources.round_house_white_48dp1;
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
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Căn hộ";
            // 
            // dataGridView_canHo
            // 
            this.dataGridView_canHo.AllowUserToAddRows = false;
            this.dataGridView_canHo.AllowUserToDeleteRows = false;
            this.dataGridView_canHo.AllowUserToOrderColumns = true;
            this.dataGridView_canHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_canHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCanHo,
            this.maKhu,
            this.dienTich,
            this.giaBan,
            this.trangThai,
            this.soPhong});
            this.dataGridView_canHo.Location = new System.Drawing.Point(82, 128);
            this.dataGridView_canHo.Name = "dataGridView_canHo";
            this.dataGridView_canHo.ReadOnly = true;
            this.dataGridView_canHo.RowHeadersVisible = false;
            this.dataGridView_canHo.Size = new System.Drawing.Size(833, 333);
            this.dataGridView_canHo.TabIndex = 4;
            this.dataGridView_canHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_canHo_CellClick);
            this.dataGridView_canHo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_canHo_CellContentClick);
            // 
            // maCanHo
            // 
            this.maCanHo.DataPropertyName = "maCanHo";
            this.maCanHo.HeaderText = "Mã căn hộ";
            this.maCanHo.Name = "maCanHo";
            this.maCanHo.ReadOnly = true;
            this.maCanHo.Width = 150;
            // 
            // maKhu
            // 
            this.maKhu.DataPropertyName = "maKhu";
            this.maKhu.HeaderText = "Mã khu";
            this.maKhu.Name = "maKhu";
            this.maKhu.ReadOnly = true;
            this.maKhu.Width = 150;
            // 
            // dienTich
            // 
            this.dienTich.DataPropertyName = "dienTich";
            this.dienTich.HeaderText = "Diện tích";
            this.dienTich.Name = "dienTich";
            this.dienTich.ReadOnly = true;
            this.dienTich.Width = 150;
            // 
            // giaBan
            // 
            this.giaBan.DataPropertyName = "giaBan";
            this.giaBan.HeaderText = "Giá bán";
            this.giaBan.Name = "giaBan";
            this.giaBan.ReadOnly = true;
            this.giaBan.Width = 150;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // soPhong
            // 
            this.soPhong.DataPropertyName = "soPhong";
            this.soPhong.HeaderText = "Số phòng";
            this.soPhong.Name = "soPhong";
            this.soPhong.ReadOnly = true;
            // 
            // CanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView_canHo);
            this.Controls.Add(this.panel1);
            this.Name = "CanHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Căn hộ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_canHo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_them_CanHo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua_CanHo;
        private System.Windows.Forms.TextBox textBox_timCanHo;
        private System.Windows.Forms.DataGridView dataGridView_canHo;
        private System.Windows.Forms.ComboBox comboBox_timKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhong;
    }
}