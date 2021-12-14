
namespace QuanLyDiemTrungHocCoSo.utils
{
    partial class UScoreTableView
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
            this.cbx_sesmeter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_scoreEachSubject = new System.Windows.Forms.DataGridView();
            this.btn_ViewScoreReport = new System.Windows.Forms.Button();
            this.btn_displayScore = new System.Windows.Forms.Button();
            this.lb_warningViewScore = new System.Windows.Forms.Label();
            this.cl_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_sNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_diemMieng2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_trungBinhMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_scoreEachSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_sesmeter
            // 
            this.cbx_sesmeter.FormattingEnabled = true;
            this.cbx_sesmeter.Location = new System.Drawing.Point(139, 60);
            this.cbx_sesmeter.Name = "cbx_sesmeter";
            this.cbx_sesmeter.Size = new System.Drawing.Size(121, 24);
            this.cbx_sesmeter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kỳ học";
            // 
            // cbx_subject
            // 
            this.cbx_subject.FormattingEnabled = true;
            this.cbx_subject.Location = new System.Drawing.Point(12, 60);
            this.cbx_subject.Name = "cbx_subject";
            this.cbx_subject.Size = new System.Drawing.Size(121, 24);
            this.cbx_subject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Môn học";
            // 
            // dgv_scoreEachSubject
            // 
            this.dgv_scoreEachSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_scoreEachSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_HoTen,
            this.cl_sNgaySinh,
            this.cl_gioiTinh,
            this.cl_HocKy,
            this.cl_Mon,
            this.cl_diemMieng2,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.cl_trungBinhMon});
            this.dgv_scoreEachSubject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_scoreEachSubject.Location = new System.Drawing.Point(0, 116);
            this.dgv_scoreEachSubject.Name = "dgv_scoreEachSubject";
            this.dgv_scoreEachSubject.RowHeadersWidth = 51;
            this.dgv_scoreEachSubject.RowTemplate.Height = 24;
            this.dgv_scoreEachSubject.Size = new System.Drawing.Size(800, 334);
            this.dgv_scoreEachSubject.TabIndex = 4;
            // 
            // btn_ViewScoreReport
            // 
            this.btn_ViewScoreReport.Location = new System.Drawing.Point(633, 52);
            this.btn_ViewScoreReport.Name = "btn_ViewScoreReport";
            this.btn_ViewScoreReport.Size = new System.Drawing.Size(155, 32);
            this.btn_ViewScoreReport.TabIndex = 5;
            this.btn_ViewScoreReport.Text = "Xuất báo cáo";
            this.btn_ViewScoreReport.UseVisualStyleBackColor = true;
            this.btn_ViewScoreReport.Click += new System.EventHandler(this.btn_ViewScoreReport_Click);
            // 
            // btn_displayScore
            // 
            this.btn_displayScore.Location = new System.Drawing.Point(267, 61);
            this.btn_displayScore.Name = "btn_displayScore";
            this.btn_displayScore.Size = new System.Drawing.Size(75, 23);
            this.btn_displayScore.TabIndex = 6;
            this.btn_displayScore.Text = "Hiển thị";
            this.btn_displayScore.UseVisualStyleBackColor = true;
            this.btn_displayScore.Click += new System.EventHandler(this.btn_displayScore_Click);
            // 
            // lb_warningViewScore
            // 
            this.lb_warningViewScore.AutoSize = true;
            this.lb_warningViewScore.ForeColor = System.Drawing.Color.Red;
            this.lb_warningViewScore.Location = new System.Drawing.Point(15, 91);
            this.lb_warningViewScore.Name = "lb_warningViewScore";
            this.lb_warningViewScore.Size = new System.Drawing.Size(217, 17);
            this.lb_warningViewScore.TabIndex = 7;
            this.lb_warningViewScore.Text = "Môn học này chưa cập nhật điểm";
            // 
            // cl_HoTen
            // 
            this.cl_HoTen.DataPropertyName = "sHoTen";
            this.cl_HoTen.HeaderText = "Họ và tên";
            this.cl_HoTen.MinimumWidth = 6;
            this.cl_HoTen.Name = "cl_HoTen";
            this.cl_HoTen.Width = 125;
            // 
            // cl_sNgaySinh
            // 
            this.cl_sNgaySinh.DataPropertyName = "sNgaySinh";
            this.cl_sNgaySinh.HeaderText = "Ngày sinh";
            this.cl_sNgaySinh.MinimumWidth = 6;
            this.cl_sNgaySinh.Name = "cl_sNgaySinh";
            this.cl_sNgaySinh.Width = 125;
            // 
            // cl_gioiTinh
            // 
            this.cl_gioiTinh.DataPropertyName = "bGioiTinh";
            this.cl_gioiTinh.HeaderText = "Giới tính";
            this.cl_gioiTinh.MinimumWidth = 6;
            this.cl_gioiTinh.Name = "cl_gioiTinh";
            this.cl_gioiTinh.Width = 125;
            // 
            // cl_HocKy
            // 
            this.cl_HocKy.DataPropertyName = "sTenHocKy";
            this.cl_HocKy.HeaderText = "Học kỳ";
            this.cl_HocKy.MinimumWidth = 6;
            this.cl_HocKy.Name = "cl_HocKy";
            this.cl_HocKy.Width = 125;
            // 
            // cl_Mon
            // 
            this.cl_Mon.DataPropertyName = "fDiemMiengL1";
            this.cl_Mon.HeaderText = "Điểm miệng 1";
            this.cl_Mon.MinimumWidth = 6;
            this.cl_Mon.Name = "cl_Mon";
            this.cl_Mon.Width = 125;
            // 
            // cl_diemMieng2
            // 
            this.cl_diemMieng2.DataPropertyName = "fDiemMiengL2";
            this.cl_diemMieng2.HeaderText = "Điểm miệng 2";
            this.cl_diemMieng2.MinimumWidth = 6;
            this.cl_diemMieng2.Name = "cl_diemMieng2";
            this.cl_diemMieng2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fDiem15L1";
            this.Column1.HeaderText = "Điểm 15\' 1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fDiem15L2";
            this.Column2.HeaderText = "Điểm 15\' 2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fDiem45";
            this.Column3.HeaderText = "Điểm 45\'";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fDiemThi";
            this.Column4.HeaderText = "Điểm thi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // cl_trungBinhMon
            // btn_ViewScoreReport
            // 
            this.btn_ViewScoreReport.Location = new System.Drawing.Point(633, 52);
            this.btn_ViewScoreReport.Name = "btn_ViewScoreReport";
            this.btn_ViewScoreReport.Size = new System.Drawing.Size(155, 32);
            this.btn_ViewScoreReport.TabIndex = 5;
            this.btn_ViewScoreReport.Text = "Xuất báo cáo";
            this.btn_ViewScoreReport.UseVisualStyleBackColor = true;
            this.btn_ViewScoreReport.Click += new System.EventHandler(this.btn_ViewScoreReport_Click);
            // 
            // btn_clearFilter
            // 
            this.cl_trungBinhMon.DataPropertyName = "fTrungBinhMon";
            this.cl_trungBinhMon.HeaderText = "Trung bình môn";
            this.cl_trungBinhMon.MinimumWidth = 6;
            this.cl_trungBinhMon.Name = "cl_trungBinhMon";
            this.cl_trungBinhMon.Width = 125;
            // 
            // UScoreTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_warningViewScore);
            this.Controls.Add(this.btn_displayScore);
            this.Controls.Add(this.btn_ViewScoreReport);
            this.Controls.Add(this.dgv_scoreEachSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_sesmeter);
            this.Name = "UScoreTableView";
            this.Text = "UScoreTableView";
            this.Load += new System.EventHandler(this.UScoreTableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_scoreEachSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_sesmeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_scoreEachSubject;
        private System.Windows.Forms.Button btn_ViewScoreReport;
        private System.Windows.Forms.Button btn_displayScore;
        private System.Windows.Forms.Label lb_warningViewScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_sNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_diemMieng2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_trungBinhMon;
    }
}