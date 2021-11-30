
namespace QuanLyDiemTrungHocCoSo
{
    partial class DSHocSinhtheolop
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxTenlop = new System.Windows.Forms.ComboBox();
            this.comboBoxTenGVCN = new System.Windows.Forms.ComboBox();
            this.comboBoxNamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewHocSinh = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripDSHS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịDanhSáchHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.contextMenuStripDSHS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTenlop
            // 
            this.comboBoxTenlop.FormattingEnabled = true;
            this.comboBoxTenlop.Location = new System.Drawing.Point(137, 3);
            this.comboBoxTenlop.Name = "comboBoxTenlop";
            this.comboBoxTenlop.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTenlop.TabIndex = 0;
            this.comboBoxTenlop.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenlop_SelectedIndexChanged);
            // 
            // comboBoxTenGVCN
            // 
            this.comboBoxTenGVCN.FormattingEnabled = true;
            this.comboBoxTenGVCN.Location = new System.Drawing.Point(137, 88);
            this.comboBoxTenGVCN.Name = "comboBoxTenGVCN";
            this.comboBoxTenGVCN.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTenGVCN.TabIndex = 1;
            this.comboBoxTenGVCN.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenGVCN_SelectedIndexChanged);
            // 
            // comboBoxNamHoc
            // 
            this.comboBoxNamHoc.FormattingEnabled = true;
            this.comboBoxNamHoc.Location = new System.Drawing.Point(137, 166);
            this.comboBoxNamHoc.Name = "comboBoxNamHoc";
            this.comboBoxNamHoc.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNamHoc.TabIndex = 2;
            this.comboBoxNamHoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên GVCN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm Học";
            // 
            // listViewHocSinh
            // 
            this.listViewHocSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewHocSinh.ContextMenuStrip = this.contextMenuStripDSHS;
            this.listViewHocSinh.FullRowSelect = true;
            this.listViewHocSinh.HideSelection = false;
            this.listViewHocSinh.Location = new System.Drawing.Point(324, 12);
            this.listViewHocSinh.MultiSelect = false;
            this.listViewHocSinh.Name = "listViewHocSinh";
            this.listViewHocSinh.Size = new System.Drawing.Size(454, 178);
            this.listViewHocSinh.TabIndex = 6;
            this.listViewHocSinh.TabStop = false;
            this.listViewHocSinh.UseCompatibleStateImageBehavior = false;
            this.listViewHocSinh.View = System.Windows.Forms.View.Details;
            this.listViewHocSinh.Click += new System.EventHandler(this.listViewHocSinh_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 222;
            // 
            // contextMenuStripDSHS
            // 
            this.contextMenuStripDSHS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDSHS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịDanhSáchHọcSinhToolStripMenuItem});
            this.contextMenuStripDSHS.Name = "contextMenuStripDSHS";
            this.contextMenuStripDSHS.Size = new System.Drawing.Size(259, 28);
            this.contextMenuStripDSHS.Click += new System.EventHandler(this.contextMenuStripDSHS_Click);
            // 
            // hiểnThịDanhSáchHọcSinhToolStripMenuItem
            // 
            this.hiểnThịDanhSáchHọcSinhToolStripMenuItem.Name = "hiểnThịDanhSáchHọcSinhToolStripMenuItem";
            this.hiểnThịDanhSáchHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.hiểnThịDanhSáchHọcSinhToolStripMenuItem.Text = "Hiển thị danh sách học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng số học sinh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(40, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 146);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(3, 75);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(237, 32);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa học sinh";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(237, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm học sinh";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // DSHocSinhtheolop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewHocSinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNamHoc);
            this.Controls.Add(this.comboBoxTenGVCN);
            this.Controls.Add(this.comboBoxTenlop);
            this.Name = "DSHocSinhtheolop";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DSHocSinhtheolop_Load);
            this.contextMenuStripDSHS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTenlop;
        private System.Windows.Forms.ComboBox comboBoxTenGVCN;
        private System.Windows.Forms.ComboBox comboBoxNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewHocSinh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDSHS;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịDanhSáchHọcSinhToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}

