
namespace QuanLyDiemTrungHocCoSo
{
    partial class HomePage
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tp_mainClass = new System.Windows.Forms.TabPage();
            this.dgv_mainStudents = new System.Windows.Forms.DataGridView();
            this.cl_studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_dataOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_classSubject = new System.Windows.Forms.DataGridView();
            this.cl_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountManager = new System.Windows.Forms.TabPage();
            this.dgv_accounts = new System.Windows.Forms.DataGridView();
            this.cl_teachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbx_teacherNoAccount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.cbx_permission = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabl_workAssignment = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_classSchoolYear = new System.Windows.Forms.DataGridView();
            this.cl_classList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_headTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_schoolYear = new System.Windows.Forms.ComboBox();
            this.btn_addHeadAccount = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_teacher = new System.Windows.Forms.ComboBox();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.tp_mainClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mainStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classSubject)).BeginInit();
            this.accountManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounts)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabl_workAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classSchoolYear)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tp_mainClass);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.accountManager);
            this.mainTabControl.Controls.Add(this.tabl_workAssignment);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1463, 767);
            this.mainTabControl.TabIndex = 0;
            // 
            // tp_mainClass
            // 
            this.tp_mainClass.Controls.Add(this.dgv_mainStudents);
            this.tp_mainClass.Controls.Add(this.panel1);
            this.tp_mainClass.Location = new System.Drawing.Point(4, 25);
            this.tp_mainClass.Name = "tp_mainClass";
            this.tp_mainClass.Padding = new System.Windows.Forms.Padding(3);
            this.tp_mainClass.Size = new System.Drawing.Size(1455, 738);
            this.tp_mainClass.TabIndex = 0;
            this.tp_mainClass.Text = "Lớp chủ nhiệm";
            this.tp_mainClass.UseVisualStyleBackColor = true;
            // 
            // dgv_mainStudents
            // 
            this.dgv_mainStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mainStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mainStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_studentName,
            this.cl_dataOfBirth,
            this.cl_address});
            this.dgv_mainStudents.Location = new System.Drawing.Point(3, 226);
            this.dgv_mainStudents.Name = "dgv_mainStudents";
            this.dgv_mainStudents.RowHeadersWidth = 51;
            this.dgv_mainStudents.RowTemplate.Height = 24;
            this.dgv_mainStudents.Size = new System.Drawing.Size(1449, 509);
            this.dgv_mainStudents.TabIndex = 1;
            this.dgv_mainStudents.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_mainStudents_DataBindingComplete);
            // 
            // cl_studentName
            // 
            this.cl_studentName.DataPropertyName = "sHoTen";
            this.cl_studentName.HeaderText = "Họ và tên";
            this.cl_studentName.MinimumWidth = 6;
            this.cl_studentName.Name = "cl_studentName";
            // 
            // cl_dataOfBirth
            // 
            this.cl_dataOfBirth.DataPropertyName = "sNgaySinh";
            this.cl_dataOfBirth.HeaderText = "Ngày sinh";
            this.cl_dataOfBirth.MinimumWidth = 6;
            this.cl_dataOfBirth.Name = "cl_dataOfBirth";
            // 
            // cl_address
            // 
            this.cl_address.DataPropertyName = "sDiaChi";
            this.cl_address.HeaderText = "Địa chỉ";
            this.cl_address.MinimumWidth = 6;
            this.cl_address.Name = "cl_address";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 80);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "30 học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sĩ số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp 1910A03";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_classSubject);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1455, 738);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lớp giảng dạy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_classSubject
            // 
            this.dgv_classSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_classSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_class});
            this.dgv_classSubject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_classSubject.Location = new System.Drawing.Point(3, 198);
            this.dgv_classSubject.Name = "dgv_classSubject";
            this.dgv_classSubject.RowHeadersWidth = 51;
            this.dgv_classSubject.RowTemplate.Height = 24;
            this.dgv_classSubject.Size = new System.Drawing.Size(1449, 537);
            this.dgv_classSubject.TabIndex = 0;
            this.dgv_classSubject.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_classSubject_DataBindingComplete);
            // 
            // cl_class
            // 
            this.cl_class.DataPropertyName = "sTenLop";
            this.cl_class.HeaderText = "Lớp";
            this.cl_class.MinimumWidth = 6;
            this.cl_class.Name = "cl_class";
            // 
            // accountManager
            // 
            this.accountManager.Controls.Add(this.dgv_accounts);
            this.accountManager.Controls.Add(this.panel3);
            this.accountManager.Location = new System.Drawing.Point(4, 25);
            this.accountManager.Name = "accountManager";
            this.accountManager.Padding = new System.Windows.Forms.Padding(3);
            this.accountManager.Size = new System.Drawing.Size(1455, 738);
            this.accountManager.TabIndex = 2;
            this.accountManager.Text = "Quản lý tài khoản";
            this.accountManager.UseVisualStyleBackColor = true;
            // 
            // dgv_accounts
            // 
            this.dgv_accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_teachName,
            this.cl_phoneNumber,
            this.Column1,
            this.cl_username,
            this.cl_permission});
            this.dgv_accounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_accounts.Location = new System.Drawing.Point(3, 282);
            this.dgv_accounts.Name = "dgv_accounts";
            this.dgv_accounts.RowHeadersWidth = 51;
            this.dgv_accounts.RowTemplate.Height = 24;
            this.dgv_accounts.Size = new System.Drawing.Size(1449, 453);
            this.dgv_accounts.TabIndex = 0;
            this.dgv_accounts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_accounts_DataBindingComplete);
            // 
            // cl_teachName
            // 
            this.cl_teachName.DataPropertyName = "sHoTen";
            this.cl_teachName.HeaderText = "Họ và tên";
            this.cl_teachName.MinimumWidth = 6;
            this.cl_teachName.Name = "cl_teachName";
            // 
            // cl_phoneNumber
            // 
            this.cl_phoneNumber.DataPropertyName = "sSDT";
            this.cl_phoneNumber.HeaderText = "Số điện thoại";
            this.cl_phoneNumber.MinimumWidth = 6;
            this.cl_phoneNumber.Name = "cl_phoneNumber";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sTenMonHoc";
            this.Column1.HeaderText = "Chuyên môn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // cl_username
            // 
            this.cl_username.DataPropertyName = "sUsername";
            this.cl_username.HeaderText = "Tài khoản";
            this.cl_username.MinimumWidth = 6;
            this.cl_username.Name = "cl_username";
            // 
            // cl_permission
            // 
            this.cl_permission.DataPropertyName = "sTenQuyen";
            this.cl_permission.HeaderText = "Quyền";
            this.cl_permission.MinimumWidth = 6;
            this.cl_permission.Name = "cl_permission";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbx_teacherNoAccount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_signUp);
            this.panel3.Controls.Add(this.cbx_permission);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tb_password);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tb_username);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(348, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 161);
            this.panel3.TabIndex = 13;
            // 
            // cbx_teacherNoAccount
            // 
            this.cbx_teacherNoAccount.FormattingEnabled = true;
            this.cbx_teacherNoAccount.Location = new System.Drawing.Point(90, 32);
            this.cbx_teacherNoAccount.Name = "cbx_teacherNoAccount";
            this.cbx_teacherNoAccount.Size = new System.Drawing.Size(207, 24);
            this.cbx_teacherNoAccount.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giáo viên";
            // 
            // btn_signUp
            // 
            this.btn_signUp.Location = new System.Drawing.Point(90, 135);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(75, 23);
            this.btn_signUp.TabIndex = 12;
            this.btn_signUp.Text = "Cấp";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // cbx_permission
            // 
            this.cbx_permission.FormattingEnabled = true;
            this.cbx_permission.Location = new System.Drawing.Point(611, 30);
            this.cbx_permission.Name = "cbx_permission";
            this.cbx_permission.Size = new System.Drawing.Size(121, 24);
            this.cbx_permission.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mật khẩu";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(380, 60);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(169, 22);
            this.tb_password.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tài khoản";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(380, 32);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(169, 22);
            this.tb_username.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quản lý tài khoản";
            // 
            // tabl_workAssignment
            // 
            this.tabl_workAssignment.Controls.Add(this.label13);
            this.tabl_workAssignment.Controls.Add(this.dgv_classSchoolYear);
            this.tabl_workAssignment.Controls.Add(this.panel2);
            this.tabl_workAssignment.Location = new System.Drawing.Point(4, 25);
            this.tabl_workAssignment.Name = "tabl_workAssignment";
            this.tabl_workAssignment.Padding = new System.Windows.Forms.Padding(3);
            this.tabl_workAssignment.Size = new System.Drawing.Size(1455, 738);
            this.tabl_workAssignment.TabIndex = 3;
            this.tabl_workAssignment.Text = "Phân công công tác";
            this.tabl_workAssignment.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(15, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Danh sách lớp";
            // 
            // dgv_classSchoolYear
            // 
            this.dgv_classSchoolYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classSchoolYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_classList,
            this.cl_headTeacher});
            this.dgv_classSchoolYear.Location = new System.Drawing.Point(19, 263);
            this.dgv_classSchoolYear.Name = "dgv_classSchoolYear";
            this.dgv_classSchoolYear.RowHeadersWidth = 51;
            this.dgv_classSchoolYear.RowTemplate.Height = 24;
            this.dgv_classSchoolYear.Size = new System.Drawing.Size(408, 469);
            this.dgv_classSchoolYear.TabIndex = 8;
            this.dgv_classSchoolYear.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_classSchoolYear_DataBindingComplete);
            // 
            // cl_classList
            // 
            this.cl_classList.DataPropertyName = "sTenLop";
            this.cl_classList.HeaderText = "Lớp";
            this.cl_classList.MinimumWidth = 6;
            this.cl_classList.Name = "cl_classList";
            this.cl_classList.Width = 125;
            // 
            // cl_headTeacher
            // 
            this.cl_headTeacher.DataPropertyName = "sHoTen";
            this.cl_headTeacher.HeaderText = "Giáo viên";
            this.cl_headTeacher.MinimumWidth = 6;
            this.cl_headTeacher.Name = "cl_headTeacher";
            this.cl_headTeacher.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbx_schoolYear);
            this.panel2.Controls.Add(this.btn_addHeadAccount);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbx_teacher);
            this.panel2.Controls.Add(this.cbx_class);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 136);
            this.panel2.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Năm học";
            // 
            // cbx_schoolYear
            // 
            this.cbx_schoolYear.FormattingEnabled = true;
            this.cbx_schoolYear.Location = new System.Drawing.Point(273, 61);
            this.cbx_schoolYear.Name = "cbx_schoolYear";
            this.cbx_schoolYear.Size = new System.Drawing.Size(129, 24);
            this.cbx_schoolYear.TabIndex = 7;
            // 
            // btn_addHeadAccount
            // 
            this.btn_addHeadAccount.Location = new System.Drawing.Point(84, 91);
            this.btn_addHeadAccount.Name = "btn_addHeadAccount";
            this.btn_addHeadAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_addHeadAccount.TabIndex = 6;
            this.btn_addHeadAccount.Text = "Thêm";
            this.btn_addHeadAccount.UseVisualStyleBackColor = true;
            this.btn_addHeadAccount.Click += new System.EventHandler(this.btn_addHeadAccount_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Giáo viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Lớp";
            // 
            // cbx_teacher
            // 
            this.cbx_teacher.FormattingEnabled = true;
            this.cbx_teacher.Location = new System.Drawing.Point(84, 26);
            this.cbx_teacher.Name = "cbx_teacher";
            this.cbx_teacher.Size = new System.Drawing.Size(318, 24);
            this.cbx_teacher.TabIndex = 3;
            // 
            // cbx_class
            // 
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(84, 61);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(113, 24);
            this.cbx_class.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giáo viên chủ nhiệm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 791);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tp_mainClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mainStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classSubject)).EndInit();
            this.accountManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabl_workAssignment.ResumeLayout(false);
            this.tabl_workAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classSchoolYear)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tp_mainClass;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_mainStudents;
        private System.Windows.Forms.DataGridView dgv_classSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_class;
        private System.Windows.Forms.TabPage accountManager;
        private System.Windows.Forms.DataGridView dgv_accounts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.ComboBox cbx_permission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbx_teacherNoAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_dataOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_teachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_permission;
        private System.Windows.Forms.TabPage tabl_workAssignment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_teacher;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addHeadAccount;
        private System.Windows.Forms.DataGridView dgv_classSchoolYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_schoolYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_classList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_headTeacher;
    }
}

