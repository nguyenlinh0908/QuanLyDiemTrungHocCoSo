using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            btn_ViewScoreReport.Enabled = false;
        }

        private void displayView()
        {
            model.SubjectClass classSubject = new model.SubjectClass();
            lb_warningViewScore.Text = "Nhấn hiển thị để xem danh sách điểm từng môn";
            lb_warningViewScore.ForeColor = Color.FromArgb(0, 0, 0);//(R, G, B) (0, 0, 0 = black)
            lb_warningViewScore.Show();

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
                        cmd.CommandText = "proGetSemesterNoExcept";
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
        }
        private void btn_ViewScoreReport_Click(object sender, EventArgs e)
        {
            DataView myTableView = (DataView)dgv_scoreEachSubject.DataSource;
            DataRowView dataRowViewStudents = myTableView[0];
            string subjectName = dataRowViewStudents["sTenMonHoc"].ToString();
            string semester = cbx_sesmeter.GetItemText(cbx_sesmeter.SelectedItem);
            DataTable myTable = myTableView.ToTable();
            utils.UScoreSubjectReport uScoreSubjectReport = new UScoreSubjectReport(myTable, subjectName + " " + semester);// subjectName để thêm tên bảng điểm
            uScoreSubjectReport.Show();
        }
        private void btn_displayScore_Click(object sender, EventArgs e)
        {
            model.Score score = new model.Score();
            String semesterID, subjectID;
            subjectID = cbx_subject.SelectedValue.ToString();
            semesterID = cbx_sesmeter.SelectedValue.ToString();

            using (SqlConnection cnn = new SqlConnection(score.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (string.Equals(semesterID, "hk3") == false)
                        {
                            cmd.CommandText = "procAllScoreByClassYear";
                            cmd.Parameters.AddWithValue("@id", this.classYearID);
                            cmd.Parameters.AddWithValue("@subjectClass", subjectID);
                            cmd.Parameters.AddWithValue("@semester", semesterID);
                        }
                        else
                        {
                            cmd.CommandText = "procScore";
                            cmd.Parameters.AddWithValue("@id", subjectID);
                        }
                        DataTable scoreEachSubject = new DataTable("tblDiem");
                        adp.Fill(scoreEachSubject);
                        cnn.Close();
                        if (scoreEachSubject.Rows.Count > 0)
                        {
                            DataView scoreView = new DataView(scoreEachSubject);
                            dgv_scoreEachSubject.AutoGenerateColumns = false;
                            dgv_scoreEachSubject.ReadOnly = true;
                            dgv_scoreEachSubject.DataSource = scoreView;
                            lb_warningViewScore.Hide();
                            btn_ViewScoreReport.Enabled = true;
                        }
                        else
                        {
                            lb_warningViewScore.Text = "Môn học này chưa được cập nhật điểm";
                            lb_warningViewScore.ForeColor = Color.FromArgb(235, 52, 52);
                            lb_warningViewScore.Show();
                            dgv_scoreEachSubject.DataSource = null;
                            btn_ViewScoreReport.Enabled = true;
                        }

                    }
                }
            }
        }
    }
}
