
namespace QuanLyDiemTrungHocCoSo
{
    partial class AddStudentClass
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.comboBoxMaHS = new System.Windows.Forms.ComboBox();
            this.comboBoxTenHS = new System.Windows.Forms.ComboBox();
            this.comboBoxLopNamHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHSLH = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(210, 213);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(456, 213);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(154, 23);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem danh sách lớp";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(127, 145);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLop.TabIndex = 9;
            this.comboBoxLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxLop_SelectedIndexChanged);
            // 
            // comboBoxMaHS
            // 
            this.comboBoxMaHS.FormattingEnabled = true;
            this.comboBoxMaHS.Location = new System.Drawing.Point(127, 86);
            this.comboBoxMaHS.Name = "comboBoxMaHS";
            this.comboBoxMaHS.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaHS.TabIndex = 10;
            // 
            // comboBoxTenHS
            // 
            this.comboBoxTenHS.FormattingEnabled = true;
            this.comboBoxTenHS.Location = new System.Drawing.Point(127, 33);
            this.comboBoxTenHS.Name = "comboBoxTenHS";
            this.comboBoxTenHS.Size = new System.Drawing.Size(174, 24);
            this.comboBoxTenHS.TabIndex = 11;
            this.comboBoxTenHS.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenHS_SelectedIndexChanged);
            // 
            // comboBoxLopNamHoc
            // 
            this.comboBoxLopNamHoc.FormattingEnabled = true;
            this.comboBoxLopNamHoc.Location = new System.Drawing.Point(489, 33);
            this.comboBoxLopNamHoc.Name = "comboBoxLopNamHoc";
            this.comboBoxLopNamHoc.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLopNamHoc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã LopNamHoc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã HocSinhLopHoc";
            // 
            // txtMaHSLH
            // 
            this.txtMaHSLH.Location = new System.Drawing.Point(489, 86);
            this.txtMaHSLH.Name = "txtMaHSLH";
            this.txtMaHSLH.Size = new System.Drawing.Size(121, 22);
            this.txtMaHSLH.TabIndex = 15;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(333, 213);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 16;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(83, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // AddStudentClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.txtMaHSLH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLopNamHoc);
            this.Controls.Add(this.comboBoxTenHS);
            this.Controls.Add(this.comboBoxMaHS);
            this.Controls.Add(this.comboBoxLop);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentClass";
            this.Text = "Thêm Học Sinh vào Lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.ComboBox comboBoxMaHS;
        private System.Windows.Forms.ComboBox comboBoxTenHS;
        private System.Windows.Forms.ComboBox comboBoxLopNamHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHSLH;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnXoa;
    }
}