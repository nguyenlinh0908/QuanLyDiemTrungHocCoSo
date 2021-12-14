using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemTrungHocCoSo.utils
{
    public partial class UScoreTableView : Form
    {
        private string classYearID;
        public UScoreTableView(string classYearID)
        {
            this.classYearID = classYearID;
            InitializeComponent();
        }
        
        private void UScoreTableView_Load(object sender, EventArgs e)
        {
            displayView();
        }

        private void displayView()
        {
            model.SubjectClass classSubject = new model.SubjectClass();
            
            
            using (SqlConnection cnn = new SqlConnection(classSubject.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "procClassSubjectByClassYear";
                        cmd.Parameters.AddWithValue("@id", this.classYearID);
                        DataTable subjects = new DataTable("tblMonHoc");
                        adp.Fill(subjects);
                        cnn.Close();
                        if (subjects.Rows.Count > 0)
                        {
                            cbx_subject.DisplayMember = "sTenMonHoc";
                            cbx_subject.DataSource = subjects;
                            cbx_subject.ValueMember = "PK_sMaLopMon";
                        }
                        else
                        {
                            cbx_subject.SelectedText = "Không có môn học nào";
                        }
                    }
                }
            }
            using (SqlConnection cnn = new SqlConnection(classSubject.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "proGetSemester";                   
                        DataTable subjects = new DataTable("tblHocKy");
                        adp.Fill(subjects);
                        cnn.Close();
                        if (subjects.Rows.Count > 0)
                        {
                            cbx_sesmeter.DisplayMember = "sTenHocKy";
                            cbx_sesmeter.DataSource = subjects;
                            cbx_sesmeter.ValueMember = "PK_sMaHocKy";
                        }
                        else
                        {
                            cbx_sesmeter.SelectedText = "Không có học kỳ nào";
                        }
                    }
                }
            }

            using (SqlConnection cnn = new SqlConnection(classSubject.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "procAllScoreByClassYear";
                        cmd.Parameters.AddWithValue("@id", this.classYearID);
                        DataTable scoreEachSubject = new DataTable("tblDiem");
                        adp.Fill(scoreEachSubject);
                        cnn.Close();
                        if (scoreEachSubject.Rows.Count > 0)
                        {
                            DataView scoreView = new DataView(scoreEachSubject);
                            dgv_scoreEachSubject.AutoGenerateColumns = false;
                            dgv_scoreEachSubject.ReadOnly = true;
                            dgv_scoreEachSubject.DataSource = scoreView;
                        }
                       
                    }
                }
            }
        }

        private void cbx_sesmeter_DropDownClosed(object sender, EventArgs e)
        {
           
            String semesterID, subjectID;
            subjectID = cbx_subject.SelectedValue.ToString();
            semesterID = cbx_sesmeter.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(subjectID) || !string.IsNullOrEmpty(semesterID))
            {
                if (dgv_scoreEachSubject.Rows.Count > 1)
                {
                    (dgv_scoreEachSubject.DataSource as DataView).RowFilter = string.Format("FK_sMaLopMon LIKE '%{0}%' AND FK_sMaHocKy LIKE '%{1}%'", subjectID, semesterID);
                }
            }
        }

        private void cbx_subject_DropDownClosed(object sender, EventArgs e)
        {
            String subjectID, semesterID;
            subjectID = cbx_subject.SelectedValue.ToString();
            semesterID = cbx_sesmeter.SelectedValue.ToString();
            if(!string.IsNullOrEmpty(subjectID) || !string.IsNullOrEmpty(semesterID))
            {
                if(dgv_scoreEachSubject.Rows.Count > 1)
                {                 
                    (dgv_scoreEachSubject.DataSource as DataView).RowFilter = string.Format("FK_sMaLopMon LIKE '%{0}%' AND FK_sMaHocKy LIKE '%{1}%'", subjectID, semesterID);
                }               
            }
        }

        private void btn_ViewScoreReport_Click(object sender, EventArgs e)
        {
            DataView myTableView = (DataView)dgv_scoreEachSubject.DataSource;
            DataRowView dataRowViewStudents = myTableView[0];
            string subjectName = dataRowViewStudents["sTenMonHoc"].ToString();
            DataTable myTable = myTableView.ToTable();
            utils.UScoreSubjectReport uScoreSubjectReport = new UScoreSubjectReport(myTable, "");// subjectName để thêm tên bảng điểm
            uScoreSubjectReport.Show();
        }

        private void btn_clearFilter_Click(object sender, EventArgs e)
        {
            displayView();
        }

        
    }
}
