
namespace QuanLyDiemTrungHocCoSo
{
    partial class ThemHSDS
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTenHS = new System.Windows.Forms.ComboBox();
            this.comboBoxMaHS = new System.Windows.Forms.ComboBox();
            this.comboBoxLopNH = new System.Windows.Forms.ComboBox();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.btnThemHS = new System.Windows.Forms.Button();
            this.btnXoaHS = new System.Windows.Forms.Button();
            this.btnXemDSHS = new System.Windows.Forms.Button();
            this.btnRequestHS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHSLH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm Học";
            // 
            // comboBoxTenHS
            // 
            this.comboBoxTenHS.FormattingEnabled = true;
            this.comboBoxTenHS.Location = new System.Drawing.Point(141, 64);
            this.comboBoxTenHS.Name = "comboBoxTenHS";
            this.comboBoxTenHS.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTenHS.TabIndex = 4;
            this.comboBoxTenHS.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenHS_SelectedIndexChanged);
            // 
            // comboBoxMaHS
            // 
            this.comboBoxMaHS.FormattingEnabled = true;
            this.comboBoxMaHS.Location = new System.Drawing.Point(141, 181);
            this.comboBoxMaHS.Name = "comboBoxMaHS";
            this.comboBoxMaHS.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaHS.TabIndex = 5;
            // 
            // comboBoxLopNH
            // 
            this.comboBoxLopNH.FormattingEnabled = true;
            this.comboBoxLopNH.Location = new System.Drawing.Point(468, 181);
            this.comboBoxLopNH.Name = "comboBoxLopNH";
            this.comboBoxLopNH.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLopNH.TabIndex = 6;
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(468, 64);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLop.TabIndex = 7;
            this.comboBoxLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxLop_SelectedIndexChanged);
            // 
            // btnThemHS
            // 
            this.btnThemHS.Location = new System.Drawing.Point(62, 332);
            this.btnThemHS.Name = "btnThemHS";
            this.btnThemHS.Size = new System.Drawing.Size(75, 23);
            this.btnThemHS.TabIndex = 8;
            this.btnThemHS.Text = "Thêm Học Sinh";
            this.btnThemHS.UseVisualStyleBackColor = true;
            this.btnThemHS.Click += new System.EventHandler(this.btnThemHS_Click);
            // 
            // btnXoaHS
            // 
            this.btnXoaHS.Location = new System.Drawing.Point(212, 332);
            this.btnXoaHS.Name = "btnXoaHS";
            this.btnXoaHS.Size = new System.Drawing.Size(75, 23);
            this.btnXoaHS.TabIndex = 9;
            this.btnXoaHS.Text = "Xóa Học Sinh";
            this.btnXoaHS.UseVisualStyleBackColor = true;
            this.btnXoaHS.Click += new System.EventHandler(this.btnXoaHS_Click);
            // 
            // btnXemDSHS
            // 
            this.btnXemDSHS.Location = new System.Drawing.Point(366, 332);
            this.btnXemDSHS.Name = "btnXemDSHS";
            this.btnXemDSHS.Size = new System.Drawing.Size(75, 23);
            this.btnXemDSHS.TabIndex = 10;
            this.btnXemDSHS.Text = "Xem Danh Sách";
            this.btnXemDSHS.UseVisualStyleBackColor = true;
            this.btnXemDSHS.Click += new System.EventHandler(this.btnXemDSHS_Click);
            // 
            // btnRequestHS
            // 
            this.btnRequestHS.Location = new System.Drawing.Point(528, 332);
            this.btnRequestHS.Name = "btnRequestHS";
            this.btnRequestHS.Size = new System.Drawing.Size(75, 23);
            this.btnRequestHS.TabIndex = 11;
            this.btnRequestHS.Text = "Request";
            this.btnRequestHS.UseVisualStyleBackColor = true;
            this.btnRequestHS.Click += new System.EventHandler(this.btnRequestHS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã HSLH";
            // 
            // txtMaHSLH
            // 
            this.txtMaHSLH.Location = new System.Drawing.Point(141, 261);
            this.txtMaHSLH.Name = "txtMaHSLH";
            this.txtMaHSLH.Size = new System.Drawing.Size(100, 22);
            this.txtMaHSLH.TabIndex = 13;
            // 
            // ThemHSDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaHSLH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRequestHS);
            this.Controls.Add(this.btnXemDSHS);
            this.Controls.Add(this.btnXoaHS);
            this.Controls.Add(this.btnThemHS);
            this.Controls.Add(this.comboBoxLop);
            this.Controls.Add(this.comboBoxLopNH);
            this.Controls.Add(this.comboBoxMaHS);
            this.Controls.Add(this.comboBoxTenHS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemHSDS";
            this.Text = "ThemHSDS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTenHS;
        private System.Windows.Forms.ComboBox comboBoxMaHS;
        private System.Windows.Forms.ComboBox comboBoxLopNH;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.Button btnThemHS;
        private System.Windows.Forms.Button btnXoaHS;
        private System.Windows.Forms.Button btnXemDSHS;
        private System.Windows.Forms.Button btnRequestHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHSLH;
    }
}