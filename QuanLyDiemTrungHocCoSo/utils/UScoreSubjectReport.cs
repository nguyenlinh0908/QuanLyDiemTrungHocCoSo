using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemTrungHocCoSo.utils
{
    public partial class UScoreSubjectReport : Form
    {
        private DataTable myTable;
        private string title;
        public UScoreSubjectReport()
        {
            InitializeComponent();
        }
        public UScoreSubjectReport(DataTable myTable, string title)
        {
            this.myTable = myTable;
            this.title = title;
            InitializeComponent();
        }

        private void UScoreSubjectReport_Load(object sender, EventArgs e)
        {
            showReport();
        }
        private void showReport()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string reportFile = String.Format("{0}\\report\\ScoreSubjectTable.rpt", Application.StartupPath);
            rpt.Load(reportFile);

            CrystalDecisions.Shared.TableLogOnInfo tableLogOnInfo = new CrystalDecisions.Shared.TableLogOnInfo();
            tableLogOnInfo.ConnectionInfo.ServerName = "DESKTOP-VR3BE53\\SQLEXPRESS";
            tableLogOnInfo.ConnectionInfo.DatabaseName = "QuanLyDiem";
            tableLogOnInfo.ConnectionInfo.UserID = "sa";
            tableLogOnInfo.ConnectionInfo.Password = "123";


            foreach (CrystalDecisions.CrystalReports.Engine.Table table in rpt.Database.Tables)
            {
                table.ApplyLogOnInfo(tableLogOnInfo);
            }

            rpt.SummaryInfo.ReportTitle = "BẢNG ĐIỂM "+this.title.ToUpper();
            rpt.SetDataSource(this.myTable);

            crvScoreSubject.ReportSource = rpt;           
            crvScoreSubject.Refresh();
        }

        private void crvScoreSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
