namespace KhuCanHo
{
    partial class DienNuocKhac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_xoa_DienNuoc = new System.Windows.Forms.Button();
            this.button_sua_DienNuoc = new System.Windows.Forms.Button();
            this.button_them_DienNuoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_dienNuoc = new System.Windows.Forms.DataGridView();
            this.maCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eChiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eChiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wChiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wChiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_timKiem = new System.Windows.Forms.TextBox();
            this.comboBox_timKiem = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dienNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.comboBox_timKiem);
            this.panel1.Controls.Add(this.textBox_timKiem);
            this.panel1.Controls.Add(this.button_xoa_DienNuoc);
            this.panel1.Controls.Add(this.button_sua_DienNuoc);
            this.panel1.Controls.Add(this.button_them_DienNuoc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 100);
            this.panel1.TabIndex = 5;
            // 
            // button_xoa_DienNuoc
            // 
            this.button_xoa_DienNuoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_xoa_DienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa_DienNuoc.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_xoa_DienNuoc.Location = new System.Drawing.Point(597, 65);
            this.button_xoa_DienNuoc.Name = "button_xoa_DienNuoc";
            this.button_xoa_DienNuoc.Size = new System.Drawing.Size(75, 23);
            this.button_xoa_DienNuoc.TabIndex = 8;
            this.button_xoa_DienNuoc.Text = "Xoá";
            this.button_xoa_DienNuoc.UseVisualStyleBackColor = false;
            this.button_xoa_DienNuoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_xoa_DienNuoc_MouseClick);
            // 
            // button_sua_DienNuoc
            // 
            this.button_sua_DienNuoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_sua_DienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua_DienNuoc.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_sua_DienNuoc.Location = new System.Drawing.Point(517, 65);
            this.button_sua_DienNuoc.Name = "button_sua_DienNuoc";
            this.button_sua_DienNuoc.Size = new System.Drawing.Size(75, 25);
            this.button_sua_DienNuoc.TabIndex = 7;
            this.button_sua_DienNuoc.Text = "Sửa";
            this.button_sua_DienNuoc.UseVisualStyleBackColor = false;
            this.button_sua_DienNuoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_sua_DienNuoc_MouseClick);
            // 
            // button_them_DienNuoc
            // 
            this.button_them_DienNuoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_them_DienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_DienNuoc.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_them_DienNuoc.Location = new System.Drawing.Point(436, 66);
            this.button_them_DienNuoc.Name = "button_them_DienNuoc";
            this.button_them_DienNuoc.Size = new System.Drawing.Size(75, 25);
            this.button_them_DienNuoc.TabIndex = 2;
            this.button_them_DienNuoc.Text = "Thêm";
            this.button_them_DienNuoc.UseVisualStyleBackColor = false;
            this.button_them_DienNuoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_them_DienNuoc_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BackgroundImage = global::KhuCanHo.Properties.Resources.round_assignment_white_48dp1;
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
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điện nước";
            // 
            // dataGridView_dienNuoc
            // 
            this.dataGridView_dienNuoc.AllowUserToAddRows = false;
            this.dataGridView_dienNuoc.AllowUserToDeleteRows = false;
            this.dataGridView_dienNuoc.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_dienNuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_dienNuoc.ColumnHeadersHeight = 30;
            this.dataGridView_dienNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCanHo,
            this.eChiSoCu,
            this.eChiSoMoi,
            this.wChiSoCu,
            this.wChiSoMoi});
            this.dataGridView_dienNuoc.Location = new System.Drawing.Point(78, 129);
            this.dataGridView_dienNuoc.Name = "dataGridView_dienNuoc";
            this.dataGridView_dienNuoc.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_dienNuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_dienNuoc.RowHeadersVisible = false;
            this.dataGridView_dienNuoc.Size = new System.Drawing.Size(803, 403);
            this.dataGridView_dienNuoc.TabIndex = 6;
            this.dataGridView_dienNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dienNuoc_CellClick);
            this.dataGridView_dienNuoc.Click += new System.EventHandler(this.dataGridView_dienNuoc_Click);
            // 
            // maCanHo
            // 
            this.maCanHo.DataPropertyName = "maCanHo";
            this.maCanHo.HeaderText = "Mã căn hộ";
            this.maCanHo.Name = "maCanHo";
            this.maCanHo.ReadOnly = true;
            this.maCanHo.Width = 200;
            // 
            // eChiSoCu
            // 
            this.eChiSoCu.DataPropertyName = "eChiSoCu";
            this.eChiSoCu.HeaderText = "Điện chỉ số cũ";
            this.eChiSoCu.Name = "eChiSoCu";
            this.eChiSoCu.ReadOnly = true;
            this.eChiSoCu.Width = 150;
            // 
            // eChiSoMoi
            // 
            this.eChiSoMoi.DataPropertyName = "eChiSoMoi";
            this.eChiSoMoi.HeaderText = "Điện chỉ số mới";
            this.eChiSoMoi.Name = "eChiSoMoi";
            this.eChiSoMoi.ReadOnly = true;
            this.eChiSoMoi.Width = 150;
            // 
            // wChiSoCu
            // 
            this.wChiSoCu.DataPropertyName = "wChiSoCu";
            this.wChiSoCu.HeaderText = "Nước chỉ số cũ";
            this.wChiSoCu.Name = "wChiSoCu";
            this.wChiSoCu.ReadOnly = true;
            this.wChiSoCu.Width = 150;
            // 
            // wChiSoMoi
            // 
            this.wChiSoMoi.DataPropertyName = "wChiSoMoi";
            this.wChiSoMoi.HeaderText = "Nước chỉ số mới";
            this.wChiSoMoi.Name = "wChiSoMoi";
            this.wChiSoMoi.ReadOnly = true;
            this.wChiSoMoi.Width = 150;
            // 
            // textBox_timKiem
            // 
            this.textBox_timKiem.Location = new System.Drawing.Point(710, 65);
            this.textBox_timKiem.Name = "textBox_timKiem";
            this.textBox_timKiem.Size = new System.Drawing.Size(126, 20);
            this.textBox_timKiem.TabIndex = 9;
            this.textBox_timKiem.TextChanged += new System.EventHandler(this.textBox_timKiem_TextChanged);
            // 
            // comboBox_timKiem
            // 
            this.comboBox_timKiem.FormattingEnabled = true;
            this.comboBox_timKiem.Items.AddRange(new object[] {
            "Mã căn hộ"});
            this.comboBox_timKiem.Location = new System.Drawing.Point(842, 64);
            this.comboBox_timKiem.Name = "comboBox_timKiem";
            this.comboBox_timKiem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_timKiem.TabIndex = 10;
            // 
            // DienNuocKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView_dienNuoc);
            this.Controls.Add(this.panel1);
            this.Name = "DienNuocKhac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điện - Nước - Khác";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dienNuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_xoa_DienNuoc;
        private System.Windows.Forms.Button button_sua_DienNuoc;
        private System.Windows.Forms.Button button_them_DienNuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_dienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn eChiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn eChiSoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn wChiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn wChiSoMoi;
        private System.Windows.Forms.TextBox textBox_timKiem;
        private System.Windows.Forms.ComboBox comboBox_timKiem;
    }
}