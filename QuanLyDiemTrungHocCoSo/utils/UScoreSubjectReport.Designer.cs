
namespace QuanLyDiemTrungHocCoSo.utils
{
    partial class UScoreSubjectReport
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
            this.crvScoreSubject = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvScoreSubject
            // 
            this.crvScoreSubject.ActiveViewIndex = -1;
            this.crvScoreSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvScoreSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvScoreSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvScoreSubject.Location = new System.Drawing.Point(0, 0);
            this.crvScoreSubject.Name = "crvScoreSubject";
            this.crvScoreSubject.Size = new System.Drawing.Size(800, 450);
            this.crvScoreSubject.TabIndex = 0;
            this.crvScoreSubject.Load += new System.EventHandler(this.crvScoreSubject_Load);
            // 
            // UScoreSubjectReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvScoreSubject);
            this.Name = "UScoreSubjectReport";
            this.Text = "UScoreSubjectReport";
            this.Load += new System.EventHandler(this.UScoreSubjectReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvScoreSubject;
    }
}