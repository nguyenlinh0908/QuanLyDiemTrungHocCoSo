
namespace QuanLyDiemTrungHocCoSo
{
    partial class DanhsachHSLH
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
            this.crystalReportViewerLHHS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerLHHS
            // 
            this.crystalReportViewerLHHS.ActiveViewIndex = -1;
            this.crystalReportViewerLHHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerLHHS.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerLHHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerLHHS.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerLHHS.Name = "crystalReportViewerLHHS";
            this.crystalReportViewerLHHS.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerLHHS.TabIndex = 0;
            // 
            // DanhsachHSLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerLHHS);
            this.Name = "DanhsachHSLH";
            this.Text = "DanhsachHSLH";
//            this.Load += new System.EventHandler(this.DanhsachHSLH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerLHHS;
    }
}