﻿
namespace QuanLyDiemTrungHocCoSo.utils
{
    partial class UScore
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
            this.lb_headerScoreTable = new System.Windows.Forms.Label();
            this.lb_infoStudent = new System.Windows.Forms.Label();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.lb_class = new System.Windows.Forms.Label();
            this.lb_semester = new System.Windows.Forms.Label();
            this.cbx_semester = new System.Windows.Forms.ComboBox();
            this.lb_subjects = new System.Windows.Forms.Label();
            this.cbx_subjects = new System.Windows.Forms.ComboBox();
            this.cbx_student = new System.Windows.Forms.ComboBox();
            this.lb_students = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_fastTest1 = new System.Windows.Forms.TextBox();
            this.tb_15test1 = new System.Windows.Forms.TextBox();
            this.tb_45test = new System.Windows.Forms.TextBox();
            this.tb_semesterGrades = new System.Windows.Forms.TextBox();
            this.btn_addScore = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgv_score = new System.Windows.Forms.DataGridView();
            this.cl_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fastTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_fastTest2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_15Test1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_15Test2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_45Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_semesterGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelScore = new System.Windows.Forms.Panel();
            this.tb_15test2 = new System.Windows.Forms.TextBox();
            this.tb_fastTest2 = new System.Windows.Forms.TextBox();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.panelModule = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_score)).BeginInit();
            this.panelScore.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.panelModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_headerScoreTable
            // 
            this.lb_headerScoreTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_headerScoreTable.AutoSize = true;
            this.lb_headerScoreTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_headerScoreTable.Location = new System.Drawing.Point(303, 9);
            this.lb_headerScoreTable.Name = "lb_headerScoreTable";
            this.lb_headerScoreTable.Size = new System.Drawing.Size(386, 39);
            this.lb_headerScoreTable.TabIndex = 0;
            this.lb_headerScoreTable.Text = "BẢNG ĐIỂM HỌC SINH";
            this.lb_headerScoreTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_infoStudent
            // 
            this.lb_infoStudent.AutoSize = true;
            this.lb_infoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lb_infoStudent.Location = new System.Drawing.Point(3, 0);
            this.lb_infoStudent.Name = "lb_infoStudent";
            this.lb_infoStudent.Size = new System.Drawing.Size(166, 26);
            this.lb_infoStudent.TabIndex = 1;
            this.lb_infoStudent.Text = "Thông tin chung";
            // 
            // cbx_class
            // 
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(102, 79);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(162, 24);
            this.cbx_class.TabIndex = 2;
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Location = new System.Drawing.Point(5, 81);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(32, 17);
            this.lb_class.TabIndex = 3;
            this.lb_class.Text = "Lớp";
            // 
            // lb_semester
            // 
            this.lb_semester.AutoSize = true;
            this.lb_semester.Location = new System.Drawing.Point(5, 44);
            this.lb_semester.Name = "lb_semester";
            this.lb_semester.Size = new System.Drawing.Size(51, 17);
            this.lb_semester.TabIndex = 6;
            this.lb_semester.Text = "Học kỳ";
            // 
            // cbx_semester
            // 
            this.cbx_semester.FormattingEnabled = true;
            this.cbx_semester.Location = new System.Drawing.Point(102, 44);
            this.cbx_semester.Name = "cbx_semester";
            this.cbx_semester.Size = new System.Drawing.Size(162, 24);
            this.cbx_semester.TabIndex = 7;
            // 
            // lb_subjects
            // 
            this.lb_subjects.AutoSize = true;
            this.lb_subjects.Location = new System.Drawing.Point(6, 47);
            this.lb_subjects.Name = "lb_subjects";
            this.lb_subjects.Size = new System.Drawing.Size(62, 17);
            this.lb_subjects.TabIndex = 8;
            this.lb_subjects.Text = "Môn học";
            // 
            // cbx_subjects
            // 
            this.cbx_subjects.FormattingEnabled = true;
            this.cbx_subjects.Location = new System.Drawing.Point(150, 44);
            this.cbx_subjects.Name = "cbx_subjects";
            this.cbx_subjects.Size = new System.Drawing.Size(144, 24);
            this.cbx_subjects.TabIndex = 9;
            // 
            // cbx_student
            // 
            this.cbx_student.FormattingEnabled = true;
            this.cbx_student.Location = new System.Drawing.Point(102, 115);
            this.cbx_student.Name = "cbx_student";
            this.cbx_student.Size = new System.Drawing.Size(162, 24);
            this.cbx_student.TabIndex = 10;
            // 
            // lb_students
            // 
            this.lb_students.AutoSize = true;
            this.lb_students.Location = new System.Drawing.Point(3, 114);
            this.lb_students.Name = "lb_students";
            this.lb_students.Size = new System.Drawing.Size(63, 17);
            this.lb_students.TabIndex = 11;
            this.lb_students.Text = "Học sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nhập điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Điểm miệng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Điểm 15\'";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Điểm 45\'";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Điểm học kỳ";
            // 
            // tb_fastTest1
            // 
            this.tb_fastTest1.Location = new System.Drawing.Point(150, 76);
            this.tb_fastTest1.Name = "tb_fastTest1";
            this.tb_fastTest1.Size = new System.Drawing.Size(66, 22);
            this.tb_fastTest1.TabIndex = 20;
            // 
            // tb_15test1
            // 
            this.tb_15test1.Location = new System.Drawing.Point(150, 109);
            this.tb_15test1.Name = "tb_15test1";
            this.tb_15test1.Size = new System.Drawing.Size(66, 22);
            this.tb_15test1.TabIndex = 21;
            // 
            // tb_45test
            // 
            this.tb_45test.Location = new System.Drawing.Point(150, 137);
            this.tb_45test.Name = "tb_45test";
            this.tb_45test.Size = new System.Drawing.Size(144, 22);
            this.tb_45test.TabIndex = 22;
            // 
            // tb_semesterGrades
            // 
            this.tb_semesterGrades.Location = new System.Drawing.Point(150, 165);
            this.tb_semesterGrades.Name = "tb_semesterGrades";
            this.tb_semesterGrades.Size = new System.Drawing.Size(144, 22);
            this.tb_semesterGrades.TabIndex = 23;
            // 
            // btn_addScore
            // 
            this.btn_addScore.Location = new System.Drawing.Point(17, 63);
            this.btn_addScore.Name = "btn_addScore";
            this.btn_addScore.Size = new System.Drawing.Size(75, 23);
            this.btn_addScore.TabIndex = 24;
            this.btn_addScore.Text = "Thêm";
            this.btn_addScore.UseVisualStyleBackColor = true;
            this.btn_addScore.Click += new System.EventHandler(this.btn_addScore_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Chức năng";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "In";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dgv_score
            // 
            this.dgv_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_score.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_serial,
            this.cl_name,
            this.col_dateOfBirth,
            this.cl_fastTest,
            this.cl_fastTest2,
            this.cl_15Test1,
            this.cl_15Test2,
            this.cl_45Test,
            this.cl_semesterGrades});
            this.dgv_score.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_score.Location = new System.Drawing.Point(0, 358);
            this.dgv_score.Name = "dgv_score";
            this.dgv_score.RowHeadersWidth = 51;
            this.dgv_score.RowTemplate.Height = 24;
            this.dgv_score.Size = new System.Drawing.Size(1006, 363);
            this.dgv_score.TabIndex = 30;
            // 
            // cl_serial
            // 
            this.cl_serial.DataPropertyName = "serial";
            this.cl_serial.HeaderText = "STT";
            this.cl_serial.MinimumWidth = 6;
            this.cl_serial.Name = "cl_serial";
            this.cl_serial.Width = 125;
            // 
            // cl_name
            // 
            this.cl_name.DataPropertyName = "studentName";
            this.cl_name.HeaderText = "Họ và tên";
            this.cl_name.MinimumWidth = 6;
            this.cl_name.Name = "cl_name";
            this.cl_name.Width = 125;
            // 
            // col_dateOfBirth
            // 
            this.col_dateOfBirth.DataPropertyName = "dateOfBirth";
            this.col_dateOfBirth.HeaderText = "Ngày sinh";
            this.col_dateOfBirth.MinimumWidth = 6;
            this.col_dateOfBirth.Name = "col_dateOfBirth";
            this.col_dateOfBirth.Width = 125;
            // 
            // cl_fastTest
            // 
            this.cl_fastTest.DataPropertyName = "fastTest1";
            this.cl_fastTest.HeaderText = "Điểm miệng lần 1";
            this.cl_fastTest.MinimumWidth = 6;
            this.cl_fastTest.Name = "cl_fastTest";
            this.cl_fastTest.Width = 125;
            // 
            // cl_fastTest2
            // 
            this.cl_fastTest2.DataPropertyName = "fastTest2";
            this.cl_fastTest2.HeaderText = "Điểm miệng lần 2";
            this.cl_fastTest2.MinimumWidth = 6;
            this.cl_fastTest2.Name = "cl_fastTest2";
            this.cl_fastTest2.Width = 125;
            // 
            // cl_15Test1
            // 
            this.cl_15Test1.DataPropertyName = "_15Test1";
            this.cl_15Test1.HeaderText = "Điểm 15\' lần 1";
            this.cl_15Test1.MinimumWidth = 6;
            this.cl_15Test1.Name = "cl_15Test1";
            this.cl_15Test1.Width = 125;
            // 
            // cl_15Test2
            // 
            this.cl_15Test2.DataPropertyName = "_15Test2";
            this.cl_15Test2.HeaderText = "Điểm 15\' lần 2";
            this.cl_15Test2.MinimumWidth = 6;
            this.cl_15Test2.Name = "cl_15Test2";
            this.cl_15Test2.Width = 125;
            // 
            // cl_45Test
            // 
            this.cl_45Test.DataPropertyName = "_45Test";
            this.cl_45Test.HeaderText = "Điểm 45\'";
            this.cl_45Test.MinimumWidth = 6;
            this.cl_45Test.Name = "cl_45Test";
            this.cl_45Test.Width = 125;
            // 
            // cl_semesterGrades
            // 
            this.cl_semesterGrades.DataPropertyName = "semesterGrades";
            this.cl_semesterGrades.HeaderText = "Điểm thi";
            this.cl_semesterGrades.MinimumWidth = 6;
            this.cl_semesterGrades.Name = "cl_semesterGrades";
            this.cl_semesterGrades.Width = 125;
            // 
            // panelScore
            // 
            this.panelScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelScore.Controls.Add(this.tb_15test2);
            this.panelScore.Controls.Add(this.tb_fastTest2);
            this.panelScore.Controls.Add(this.tb_semesterGrades);
            this.panelScore.Controls.Add(this.tb_45test);
            this.panelScore.Controls.Add(this.tb_15test1);
            this.panelScore.Controls.Add(this.tb_fastTest1);
            this.panelScore.Controls.Add(this.label10);
            this.panelScore.Controls.Add(this.label9);
            this.panelScore.Controls.Add(this.label8);
            this.panelScore.Controls.Add(this.label7);
            this.panelScore.Controls.Add(this.label6);
            this.panelScore.Controls.Add(this.cbx_subjects);
            this.panelScore.Controls.Add(this.lb_subjects);
            this.panelScore.Location = new System.Drawing.Point(366, 86);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(348, 266);
            this.panelScore.TabIndex = 31;
            // 
            // tb_15test2
            // 
            this.tb_15test2.Location = new System.Drawing.Point(228, 109);
            this.tb_15test2.Name = "tb_15test2";
            this.tb_15test2.Size = new System.Drawing.Size(66, 22);
            this.tb_15test2.TabIndex = 25;
            // 
            // tb_fastTest2
            // 
            this.tb_fastTest2.Location = new System.Drawing.Point(228, 74);
            this.tb_fastTest2.Name = "tb_fastTest2";
            this.tb_fastTest2.Size = new System.Drawing.Size(66, 22);
            this.tb_fastTest2.TabIndex = 24;
            // 
            // panelInformation
            // 
            this.panelInformation.Controls.Add(this.lb_students);
            this.panelInformation.Controls.Add(this.cbx_student);
            this.panelInformation.Controls.Add(this.cbx_semester);
            this.panelInformation.Controls.Add(this.lb_semester);
            this.panelInformation.Controls.Add(this.lb_class);
            this.panelInformation.Controls.Add(this.cbx_class);
            this.panelInformation.Controls.Add(this.lb_infoStudent);
            this.panelInformation.Location = new System.Drawing.Point(12, 86);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(348, 266);
            this.panelInformation.TabIndex = 32;
            // 
            // panelModule
            // 
            this.panelModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModule.Controls.Add(this.button5);
            this.panelModule.Controls.Add(this.button4);
            this.panelModule.Controls.Add(this.button3);
            this.panelModule.Controls.Add(this.button2);
            this.panelModule.Controls.Add(this.label11);
            this.panelModule.Controls.Add(this.btn_addScore);
            this.panelModule.Location = new System.Drawing.Point(720, 86);
            this.panelModule.Name = "panelModule";
            this.panelModule.Size = new System.Drawing.Size(259, 139);
            this.panelModule.TabIndex = 33;
            // 
            // UScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelModule);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.panelScore);
            this.Controls.Add(this.dgv_score);
            this.Controls.Add(this.lb_headerScoreTable);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "UScore";
            this.Text = "UScore";
            this.Load += new System.EventHandler(this.UScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_score)).EndInit();
            this.panelScore.ResumeLayout(false);
            this.panelScore.PerformLayout();
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            this.panelModule.ResumeLayout(false);
            this.panelModule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_headerScoreTable;
        private System.Windows.Forms.Label lb_infoStudent;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.Label lb_class;
        private System.Windows.Forms.Label lb_semester;
        private System.Windows.Forms.ComboBox cbx_semester;
        private System.Windows.Forms.Label lb_subjects;
        private System.Windows.Forms.ComboBox cbx_subjects;
        private System.Windows.Forms.ComboBox cbx_student;
        private System.Windows.Forms.Label lb_students;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_fastTest1;
        private System.Windows.Forms.TextBox tb_15test1;
        private System.Windows.Forms.TextBox tb_45test;
        private System.Windows.Forms.TextBox tb_semesterGrades;
        private System.Windows.Forms.Button btn_addScore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgv_score;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Panel panelModule;
        private System.Windows.Forms.TextBox tb_15test2;
        private System.Windows.Forms.TextBox tb_fastTest2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fastTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fastTest2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_15Test1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_15Test2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_45Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_semesterGrades;
    }
}