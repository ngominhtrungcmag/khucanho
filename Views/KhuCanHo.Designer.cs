namespace KhuCanHo
{
    partial class KhuCanHo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_timKiemKhuCanHo = new System.Windows.Forms.TextBox();
            this.button_Del_KhuCanHo = new System.Windows.Forms.Button();
            this.button_sua_KhuCanHo = new System.Windows.Forms.Button();
            this.button_them_KhuCanHo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_KhuCanHo = new System.Windows.Forms.DataGridView();
            this.maKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_timKiem = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhuCanHo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.comboBox_timKiem);
            this.panel1.Controls.Add(this.textBox_timKiemKhuCanHo);
            this.panel1.Controls.Add(this.button_Del_KhuCanHo);
            this.panel1.Controls.Add(this.button_sua_KhuCanHo);
            this.panel1.Controls.Add(this.button_them_KhuCanHo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 100);
            this.panel1.TabIndex = 7;
            // 
            // textBox_timKiemKhuCanHo
            // 
            this.textBox_timKiemKhuCanHo.Location = new System.Drawing.Point(683, 62);
            this.textBox_timKiemKhuCanHo.Multiline = true;
            this.textBox_timKiemKhuCanHo.Name = "textBox_timKiemKhuCanHo";
            this.textBox_timKiemKhuCanHo.Size = new System.Drawing.Size(142, 25);
            this.textBox_timKiemKhuCanHo.TabIndex = 9;
            this.textBox_timKiemKhuCanHo.TextChanged += new System.EventHandler(this.textBox_timKiemKhuCanHo_TextChanged);
            // 
            // button_Del_KhuCanHo
            // 
            this.button_Del_KhuCanHo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Del_KhuCanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Del_KhuCanHo.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_Del_KhuCanHo.Location = new System.Drawing.Point(589, 62);
            this.button_Del_KhuCanHo.Name = "button_Del_KhuCanHo";
            this.button_Del_KhuCanHo.Size = new System.Drawing.Size(75, 25);
            this.button_Del_KhuCanHo.TabIndex = 8;
            this.button_Del_KhuCanHo.Text = "Xoá";
            this.button_Del_KhuCanHo.UseVisualStyleBackColor = false;
            this.button_Del_KhuCanHo.Click += new System.EventHandler(this.button_Del_KhuCanHo_Click);
            // 
            // button_sua_KhuCanHo
            // 
            this.button_sua_KhuCanHo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_sua_KhuCanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua_KhuCanHo.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_sua_KhuCanHo.Location = new System.Drawing.Point(502, 62);
            this.button_sua_KhuCanHo.Name = "button_sua_KhuCanHo";
            this.button_sua_KhuCanHo.Size = new System.Drawing.Size(75, 25);
            this.button_sua_KhuCanHo.TabIndex = 7;
            this.button_sua_KhuCanHo.Text = "Sửa";
            this.button_sua_KhuCanHo.UseVisualStyleBackColor = false;
            this.button_sua_KhuCanHo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_sua_KhuCanHo_MouseClick);
            // 
            // button_them_KhuCanHo
            // 
            this.button_them_KhuCanHo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_them_KhuCanHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_KhuCanHo.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_them_KhuCanHo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_them_KhuCanHo.Location = new System.Drawing.Point(415, 62);
            this.button_them_KhuCanHo.Name = "button_them_KhuCanHo";
            this.button_them_KhuCanHo.Size = new System.Drawing.Size(75, 25);
            this.button_them_KhuCanHo.TabIndex = 2;
            this.button_them_KhuCanHo.Text = "Thêm";
            this.button_them_KhuCanHo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_them_KhuCanHo.UseVisualStyleBackColor = false;
            this.button_them_KhuCanHo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_them_KhuCanHo_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BackgroundImage = global::KhuCanHo.Properties.Resources.company_50px;
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
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khu căn hộ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_KhuCanHo);
            this.panel3.Location = new System.Drawing.Point(10, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 304);
            this.panel3.TabIndex = 8;
            // 
            // dataGridView_KhuCanHo
            // 
            this.dataGridView_KhuCanHo.AccessibleName = "dataGirdView_KhuCanHo";
            this.dataGridView_KhuCanHo.AllowUserToAddRows = false;
            this.dataGridView_KhuCanHo.AllowUserToDeleteRows = false;
            this.dataGridView_KhuCanHo.AllowUserToOrderColumns = true;
            this.dataGridView_KhuCanHo.AllowUserToResizeRows = false;
            this.dataGridView_KhuCanHo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_KhuCanHo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.dataGridView_KhuCanHo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(121)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(121)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_KhuCanHo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_KhuCanHo.ColumnHeadersHeight = 40;
            this.dataGridView_KhuCanHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_KhuCanHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhu,
            this.tenKhu,
            this.soTang,
            this.soCanHo,
            this.diaChi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_KhuCanHo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_KhuCanHo.Location = new System.Drawing.Point(10, 3);
            this.dataGridView_KhuCanHo.Name = "dataGridView_KhuCanHo";
            this.dataGridView_KhuCanHo.ReadOnly = true;
            this.dataGridView_KhuCanHo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_KhuCanHo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_KhuCanHo.RowHeadersVisible = false;
            this.dataGridView_KhuCanHo.RowHeadersWidth = 40;
            this.dataGridView_KhuCanHo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView_KhuCanHo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_KhuCanHo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_KhuCanHo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_KhuCanHo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_KhuCanHo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView_KhuCanHo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_KhuCanHo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_KhuCanHo.ShowRowErrors = false;
            this.dataGridView_KhuCanHo.Size = new System.Drawing.Size(948, 300);
            this.dataGridView_KhuCanHo.TabIndex = 0;
            this.dataGridView_KhuCanHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KhuCanHo_CellClick);
            this.dataGridView_KhuCanHo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KhuCanHo_CellContentClick);
            // 
            // maKhu
            // 
            this.maKhu.DataPropertyName = "maKhu";
            this.maKhu.HeaderText = "Mã Khu";
            this.maKhu.Name = "maKhu";
            this.maKhu.ReadOnly = true;
            // 
            // tenKhu
            // 
            this.tenKhu.DataPropertyName = "tenKhu";
            this.tenKhu.HeaderText = "Tên Khu";
            this.tenKhu.Name = "tenKhu";
            this.tenKhu.ReadOnly = true;
            this.tenKhu.Width = 300;
            // 
            // soTang
            // 
            this.soTang.DataPropertyName = "soTang";
            this.soTang.HeaderText = "Số Tầng";
            this.soTang.Name = "soTang";
            this.soTang.ReadOnly = true;
            // 
            // soCanHo
            // 
            this.soCanHo.DataPropertyName = "soCanHo";
            this.soCanHo.HeaderText = "Số Căn Hộ";
            this.soCanHo.Name = "soCanHo";
            this.soCanHo.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 345;
            // 
            // comboBox_timKiem
            // 
            this.comboBox_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_timKiem.ItemHeight = 13;
            this.comboBox_timKiem.Items.AddRange(new object[] {
            "Mã khu",
            "Tên khu",
            "Số tầng",
            "Số căn hộ",
            "Địa chỉ"});
            this.comboBox_timKiem.Location = new System.Drawing.Point(831, 62);
            this.comboBox_timKiem.Name = "comboBox_timKiem";
            this.comboBox_timKiem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_timKiem.TabIndex = 10;
            // 
            // KhuCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "KhuCanHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khu căn hộ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhuCanHo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Del_KhuCanHo;
        private System.Windows.Forms.Button button_sua_KhuCanHo;
        private System.Windows.Forms.Button button_them_KhuCanHo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_timKiemKhuCanHo;
        private System.Windows.Forms.DataGridView dataGridView_KhuCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.ComboBox comboBox_timKiem;
    }
}