
namespace QuanLyDiemTrungHocCoSo.utils
{
    partial class UTeacher
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
            this.lb_headerInfoTeacher = new System.Windows.Forms.Label();
            this.lb_teacherName = new System.Windows.Forms.Label();
            this.tb_teacherName = new System.Windows.Forms.TextBox();
            this.lb_phoneNumber = new System.Windows.Forms.Label();
            this.tb_phoneNumber = new System.Windows.Forms.TextBox();
            this.dtp_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lb_dateofBirth = new System.Windows.Forms.Label();
            this.rdb_gender1 = new System.Windows.Forms.RadioButton();
            this.rdb_gender0 = new System.Windows.Forms.RadioButton();
            this.lb_gender = new System.Windows.Forms.Label();
            this.bl_address = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_identifycationCard = new System.Windows.Forms.TextBox();
            this.lb_identifycationCard = new System.Windows.Forms.Label();
            this.lb_specialize = new System.Windows.Forms.Label();
            this.cbx_specialize = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_options = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_teacher = new System.Windows.Forms.DataGridView();
            this.cl_teacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_teacherGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_teacherDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_specialize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_headerInfoTeacher
            // 
            this.lb_headerInfoTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_headerInfoTeacher.AutoSize = true;
            this.lb_headerInfoTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lb_headerInfoTeacher.Location = new System.Drawing.Point(8, 0);
            this.lb_headerInfoTeacher.Name = "lb_headerInfoTeacher";
            this.lb_headerInfoTeacher.Size = new System.Drawing.Size(249, 26);
            this.lb_headerInfoTeacher.TabIndex = 0;
            this.lb_headerInfoTeacher.Text = "THÔNG TIN GIÁO VIÊN";
            // 
            // lb_teacherName
            // 
            this.lb_teacherName.AutoSize = true;
            this.lb_teacherName.Location = new System.Drawing.Point(8, 41);
            this.lb_teacherName.Name = "lb_teacherName";
            this.lb_teacherName.Size = new System.Drawing.Size(65, 16);
            this.lb_teacherName.TabIndex = 1;
            this.lb_teacherName.Text = "Họ và tên";
            // 
            // tb_teacherName
            // 
            this.tb_teacherName.Location = new System.Drawing.Point(79, 41);
            this.tb_teacherName.Name = "tb_teacherName";
            this.tb_teacherName.Size = new System.Drawing.Size(178, 21);
            this.tb_teacherName.TabIndex = 2;
            // 
            // lb_phoneNumber
            // 
            this.lb_phoneNumber.AutoSize = true;
            this.lb_phoneNumber.Location = new System.Drawing.Point(416, 41);
            this.lb_phoneNumber.Name = "lb_phoneNumber";
            this.lb_phoneNumber.Size = new System.Drawing.Size(67, 16);
            this.lb_phoneNumber.TabIndex = 3;
            this.lb_phoneNumber.Text = "Điện thoại";
            // 
            // tb_phoneNumber
            // 
            this.tb_phoneNumber.Location = new System.Drawing.Point(504, 41);
            this.tb_phoneNumber.Name = "tb_phoneNumber";
            this.tb_phoneNumber.Size = new System.Drawing.Size(178, 21);
            this.tb_phoneNumber.TabIndex = 4;
            // 
            // dtp_dateOfBirth
            // 
            this.dtp_dateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtp_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateOfBirth.Location = new System.Drawing.Point(79, 68);
            this.dtp_dateOfBirth.Name = "dtp_dateOfBirth";
            this.dtp_dateOfBirth.Size = new System.Drawing.Size(178, 21);
            this.dtp_dateOfBirth.TabIndex = 5;
            // 
            // lb_dateofBirth
            // 
            this.lb_dateofBirth.AutoSize = true;
            this.lb_dateofBirth.Location = new System.Drawing.Point(8, 68);
            this.lb_dateofBirth.Name = "lb_dateofBirth";
            this.lb_dateofBirth.Size = new System.Drawing.Size(68, 16);
            this.lb_dateofBirth.TabIndex = 6;
            this.lb_dateofBirth.Text = "Ngày sinh";
            // 
            // rdb_gender1
            // 
            this.rdb_gender1.AutoSize = true;
            this.rdb_gender1.Checked = true;
            this.rdb_gender1.Location = new System.Drawing.Point(79, 96);
            this.rdb_gender1.Name = "rdb_gender1";
            this.rdb_gender1.Size = new System.Drawing.Size(58, 20);
            this.rdb_gender1.TabIndex = 7;
            this.rdb_gender1.TabStop = true;
            this.rdb_gender1.Text = "Nam";
            this.rdb_gender1.UseVisualStyleBackColor = true;
            // 
            // rdb_gender0
            // 
            this.rdb_gender0.AutoSize = true;
            this.rdb_gender0.Location = new System.Drawing.Point(143, 95);
            this.rdb_gender0.Name = "rdb_gender0";
            this.rdb_gender0.Size = new System.Drawing.Size(46, 20);
            this.rdb_gender0.TabIndex = 8;
            this.rdb_gender0.TabStop = true;
            this.rdb_gender0.Text = "Nữ";
            this.rdb_gender0.UseVisualStyleBackColor = true;
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Location = new System.Drawing.Point(8, 98);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(55, 16);
            this.lb_gender.TabIndex = 9;
            this.lb_gender.Text = "Giới tính";
            // 
            // bl_address
            // 
            this.bl_address.AutoSize = true;
            this.bl_address.Location = new System.Drawing.Point(416, 68);
            this.bl_address.Name = "bl_address";
            this.bl_address.Size = new System.Drawing.Size(48, 16);
            this.bl_address.TabIndex = 10;
            this.bl_address.Text = "Địa chỉ";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(504, 68);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(178, 21);
            this.tb_address.TabIndex = 11;
            // 
            // tb_identifycationCard
            // 
            this.tb_identifycationCard.Location = new System.Drawing.Point(504, 95);
            this.tb_identifycationCard.Name = "tb_identifycationCard";
            this.tb_identifycationCard.Size = new System.Drawing.Size(178, 21);
            this.tb_identifycationCard.TabIndex = 12;
            // 
            // lb_identifycationCard
            // 
            this.lb_identifycationCard.AutoSize = true;
            this.lb_identifycationCard.Location = new System.Drawing.Point(416, 95);
            this.lb_identifycationCard.Name = "lb_identifycationCard";
            this.lb_identifycationCard.Size = new System.Drawing.Size(48, 16);
            this.lb_identifycationCard.TabIndex = 13;
            this.lb_identifycationCard.Text = "CMND";
            // 
            // lb_specialize
            // 
            this.lb_specialize.AutoSize = true;
            this.lb_specialize.Location = new System.Drawing.Point(416, 122);
            this.lb_specialize.Name = "lb_specialize";
            this.lb_specialize.Size = new System.Drawing.Size(82, 16);
            this.lb_specialize.TabIndex = 14;
            this.lb_specialize.Text = "Chuyên môn";
            // 
            // cbx_specialize
            // 
            this.cbx_specialize.FormattingEnabled = true;
            this.cbx_specialize.Location = new System.Drawing.Point(504, 122);
            this.cbx_specialize.Name = "cbx_specialize";
            this.cbx_specialize.Size = new System.Drawing.Size(178, 23);
            this.cbx_specialize.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbx_specialize);
            this.panel1.Controls.Add(this.lb_specialize);
            this.panel1.Controls.Add(this.lb_identifycationCard);
            this.panel1.Controls.Add(this.tb_identifycationCard);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.bl_address);
            this.panel1.Controls.Add(this.lb_gender);
            this.panel1.Controls.Add(this.rdb_gender0);
            this.panel1.Controls.Add(this.rdb_gender1);
            this.panel1.Controls.Add(this.lb_dateofBirth);
            this.panel1.Controls.Add(this.dtp_dateOfBirth);
            this.panel1.Controls.Add(this.tb_phoneNumber);
            this.panel1.Controls.Add(this.lb_phoneNumber);
            this.panel1.Controls.Add(this.tb_teacherName);
            this.panel1.Controls.Add(this.lb_teacherName);
            this.panel1.Controls.Add(this.lb_headerInfoTeacher);
            this.panel1.Location = new System.Drawing.Point(4, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 180);
            this.panel1.TabIndex = 16;
            // 
            // lb_options
            // 
            this.lb_options.AutoSize = true;
            this.lb_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_options.Location = new System.Drawing.Point(2, 0);
            this.lb_options.Name = "lb_options";
            this.lb_options.Size = new System.Drawing.Size(77, 20);
            this.lb_options.TabIndex = 17;
            this.lb_options.Text = "Tùy chọn";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(7, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(88, 23);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 19;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(169, 23);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 20;
            this.btn_remove.Text = "Xóa";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_remove);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.lb_options);
            this.panel2.Location = new System.Drawing.Point(437, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 56);
            this.panel2.TabIndex = 21;
            // 
            // dgv_teacher
            // 
            this.dgv_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_teacherName,
            this.cl_teacherGender,
            this.cl_teacherDateOfBirth,
            this.cl_address,
            this.cl_phoneNumber,
            this.cl_specialize});
            this.dgv_teacher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_teacher.Location = new System.Drawing.Point(0, 257);
            this.dgv_teacher.Name = "dgv_teacher";
            this.dgv_teacher.RowHeadersWidth = 51;
            this.dgv_teacher.RowTemplate.Height = 24;
            this.dgv_teacher.Size = new System.Drawing.Size(700, 165);
            this.dgv_teacher.TabIndex = 22;
            // 
            // cl_teacherName
            // 
            this.cl_teacherName.DataPropertyName = "sHoTen";
            this.cl_teacherName.HeaderText = "Họ và tên";
            this.cl_teacherName.MinimumWidth = 6;
            this.cl_teacherName.Name = "cl_teacherName";
            this.cl_teacherName.Width = 125;
            // 
            // cl_teacherGender
            // 
            this.cl_teacherGender.DataPropertyName = "bGioiTinh";
            this.cl_teacherGender.HeaderText = "Giới tính";
            this.cl_teacherGender.MinimumWidth = 6;
            this.cl_teacherGender.Name = "cl_teacherGender";
            this.cl_teacherGender.Width = 125;
            // 
            // cl_teacherDateOfBirth
            // 
            this.cl_teacherDateOfBirth.DataPropertyName = "sNgaySinh";
            this.cl_teacherDateOfBirth.HeaderText = "Ngày sinh";
            this.cl_teacherDateOfBirth.MinimumWidth = 6;
            this.cl_teacherDateOfBirth.Name = "cl_teacherDateOfBirth";
            this.cl_teacherDateOfBirth.Width = 125;
            // 
            // cl_address
            // 
            this.cl_address.DataPropertyName = "sQueQuan";
            this.cl_address.HeaderText = "Quê quán";
            this.cl_address.MinimumWidth = 6;
            this.cl_address.Name = "cl_address";
            this.cl_address.Width = 125;
            // 
            // cl_phoneNumber
            // 
            this.cl_phoneNumber.DataPropertyName = "sSDT";
            this.cl_phoneNumber.HeaderText = "SDT";
            this.cl_phoneNumber.MinimumWidth = 6;
            this.cl_phoneNumber.Name = "cl_phoneNumber";
            this.cl_phoneNumber.Width = 125;
            // 
            // cl_specialize
            // 
            this.cl_specialize.DataPropertyName = "sTenMonHoc";
            this.cl_specialize.HeaderText = "Chuyên môn";
            this.cl_specialize.MinimumWidth = 6;
            this.cl_specialize.Name = "cl_specialize";
            this.cl_specialize.Width = 125;
            // 
            // UTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.dgv_teacher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F);
            this.Name = "UTeacher";
            this.Text = "UTeacher";
            this.Load += new System.EventHandler(this.UTeacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_headerInfoTeacher;
        private System.Windows.Forms.Label lb_teacherName;
        private System.Windows.Forms.TextBox tb_teacherName;
        private System.Windows.Forms.Label lb_phoneNumber;
        private System.Windows.Forms.TextBox tb_phoneNumber;
        private System.Windows.Forms.DateTimePicker dtp_dateOfBirth;
        private System.Windows.Forms.Label lb_dateofBirth;
        private System.Windows.Forms.RadioButton rdb_gender1;
        private System.Windows.Forms.RadioButton rdb_gender0;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label bl_address;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_identifycationCard;
        private System.Windows.Forms.Label lb_identifycationCard;
        private System.Windows.Forms.Label lb_specialize;
        private System.Windows.Forms.ComboBox cbx_specialize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_options;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_teacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_teacherGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_teacherDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_specialize;
    }
}