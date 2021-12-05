
namespace QuanLyDiemTrungHocCoSo.utils
{
    partial class UForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_teacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbl_pass1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pass2 = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giáo viên";
            // 
            // tb_teacherName
            // 
            this.tb_teacherName.Enabled = false;
            this.tb_teacherName.Location = new System.Drawing.Point(95, 35);
            this.tb_teacherName.Name = "tb_teacherName";
            this.tb_teacherName.Size = new System.Drawing.Size(167, 22);
            this.tb_teacherName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tài khoản";
            // 
            // tb_username
            // 
            this.tb_username.Enabled = false;
            this.tb_username.Location = new System.Drawing.Point(414, 35);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(167, 22);
            this.tb_username.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu";
            // 
            // tbl_pass1
            // 
            this.tbl_pass1.Location = new System.Drawing.Point(95, 66);
            this.tbl_pass1.Name = "tbl_pass1";
            this.tbl_pass1.Size = new System.Drawing.Size(167, 22);
            this.tbl_pass1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // tb_pass2
            // 
            this.tb_pass2.Location = new System.Drawing.Point(414, 66);
            this.tb_pass2.Name = "tb_pass2";
            this.tb_pass2.Size = new System.Drawing.Size(167, 22);
            this.tb_pass2.TabIndex = 8;
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(186, 123);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(252, 45);
            this.btn_accept.TabIndex = 9;
            this.btn_accept.Text = "Xác nhận";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // UForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 180);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.tb_pass2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbl_pass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_teacherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UForgotPassword";
            this.Text = "UForgotPassword";
            this.Load += new System.EventHandler(this.UForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_teacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbl_pass1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pass2;
        private System.Windows.Forms.Button btn_accept;
    }
}