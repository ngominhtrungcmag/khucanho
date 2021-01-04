
namespace KhuCanHo.Views
{
    partial class UpdatePassWord
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
            this.ChangePassWord = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.reNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangePassUpdate = new System.Windows.Forms.Button();
            this.ChangePassCancel = new System.Windows.Forms.Button();
            this.check_Pass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ChangePassWord
            // 
            this.ChangePassWord.AutoSize = true;
            this.ChangePassWord.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassWord.Location = new System.Drawing.Point(79, 49);
            this.ChangePassWord.Name = "ChangePassWord";
            this.ChangePassWord.Size = new System.Drawing.Size(187, 25);
            this.ChangePassWord.TabIndex = 0;
            this.ChangePassWord.Text = "Thay đổi mật khẩu";
            // 
            // oldPass
            // 
            this.oldPass.Location = new System.Drawing.Point(184, 120);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(100, 20);
            this.oldPass.TabIndex = 1;
            this.oldPass.UseSystemPasswordChar = true;
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(184, 162);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(100, 20);
            this.newPass.TabIndex = 2;
            this.newPass.UseSystemPasswordChar = true;
            // 
            // reNewPass
            // 
            this.reNewPass.Location = new System.Drawing.Point(184, 212);
            this.reNewPass.Name = "reNewPass";
            this.reNewPass.Size = new System.Drawing.Size(100, 20);
            this.reNewPass.TabIndex = 3;
            this.reNewPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // ChangePassUpdate
            // 
            this.ChangePassUpdate.Location = new System.Drawing.Point(49, 297);
            this.ChangePassUpdate.Name = "ChangePassUpdate";
            this.ChangePassUpdate.Size = new System.Drawing.Size(100, 40);
            this.ChangePassUpdate.TabIndex = 7;
            this.ChangePassUpdate.Text = "Cập nhật";
            this.ChangePassUpdate.UseVisualStyleBackColor = true;
            this.ChangePassUpdate.Click += new System.EventHandler(this.ChangePassUpdate_Click);
            // 
            // ChangePassCancel
            // 
            this.ChangePassCancel.Location = new System.Drawing.Point(184, 297);
            this.ChangePassCancel.Name = "ChangePassCancel";
            this.ChangePassCancel.Size = new System.Drawing.Size(100, 40);
            this.ChangePassCancel.TabIndex = 8;
            this.ChangePassCancel.Text = "Cancel";
            this.ChangePassCancel.UseVisualStyleBackColor = true;
            this.ChangePassCancel.Click += new System.EventHandler(this.ChangePassCancel_Click);
            // 
            // check_Pass
            // 
            this.check_Pass.AccessibleName = "check_Pass";
            this.check_Pass.AutoSize = true;
            this.check_Pass.Location = new System.Drawing.Point(49, 253);
            this.check_Pass.Name = "check_Pass";
            this.check_Pass.Size = new System.Drawing.Size(109, 17);
            this.check_Pass.TabIndex = 9;
            this.check_Pass.Text = "Hiển thị mật khẩu";
            this.check_Pass.UseVisualStyleBackColor = true;
            this.check_Pass.CheckedChanged += new System.EventHandler(this.check_Pass_CheckedChanged);
            // 
            // UpdatePassWord
            // 
            this.ClientSize = new System.Drawing.Size(334, 369);
            this.Controls.Add(this.check_Pass);
            this.Controls.Add(this.ChangePassCancel);
            this.Controls.Add(this.ChangePassUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reNewPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.ChangePassWord);
            this.Name = "UpdatePassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChangePassWord;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox reNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangePassUpdate;
        private System.Windows.Forms.Button ChangePassCancel;
        private System.Windows.Forms.CheckBox check_Pass;
    }
}
