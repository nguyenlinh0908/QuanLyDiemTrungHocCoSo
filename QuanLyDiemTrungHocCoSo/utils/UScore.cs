using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Notifications;

namespace QuanLyDiemTrungHocCoSo.utils
{
    public partial class UScore : Form
    {
        private string myClass, subject, subjectClass, classSchoolYear;
        private String connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        public UScore(string myClass, string subject, string subjectClass, string classSchoolYear)
        {
            this.myClass = myClass;
            this.subject = subject;
            this.subjectClass = subjectClass;
            this.classSchoolYear = classSchoolYear;
            InitializeComponent();
        }

        private void UScore_Load(object sender, EventArgs e)
        {
            // load thông tin cần thiết
            displayMainInformation();
            // load score table
            displayScore();
     
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void displayMainInformation()
        {
            tb_class.Text = this.myClass;
            tb_subject.Text = this.subject;
            using (SqlConnection connectionScholastic = new SqlConnection(connectionString))
            {
                using (SqlCommand commandScholastic = new SqlCommand("", connectionScholastic))
                {
                    using (SqlDataAdapter adapterScholastic = new SqlDataAdapter(commandScholastic))
                    {
                        commandScholastic.CommandType = CommandType.StoredProcedure;
                        commandScholastic.CommandText = "proGetSemester";
                        DataTable scholasticTable = new DataTable("tblHocKy");
                        adapterScholastic.Fill(scholasticTable);
                        cbx_semester.DisplayMember = "sTenHocKy";
                        cbx_semester.DataSource = scholasticTable;
                        cbx_semester.ValueMember = "PK_sMaHocKy";


                        cbx_semesterFilter.DisplayMember = "sTenHocKy";
                        cbx_semesterFilter.DataSource = scholasticTable;
                        cbx_semesterFilter.ValueMember = "PK_sMaHocKy";                   
                    }
                }
            }   
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "proGetStudentsOfSubjectClass";
                        cmd.Parameters.AddWithValue("@id", this.subjectClass);
                        DataTable studentsOfSubjectClass = new DataTable("tblStudentsOfSubjectClass");
                        adp.Fill(studentsOfSubjectClass);
                        cnn.Close();
                        if(studentsOfSubjectClass.Rows.Count > 0)
                        {
                            cbx_students.DisplayMember = "sHoTen";
                            cbx_students.DataSource = studentsOfSubjectClass;
                            cbx_students.ValueMember = "PK_sMaHocSinhLopHoc";
                        }
                        else
                        {
                            cbx_students.SelectedText = "Không còn học sinh nào";
                        }  
                    }
                }
            }
        }
    
        private void dgv_score_DoubleClick(object sender, EventArgs e)
        {
            DataView dataViewScore = (DataView)dgv_score.DataSource;
            DataRowView dataRowViewScore = dataViewScore[dgv_score.CurrentRow.Index];

            string semester = dataRowViewScore["sTenHocKy"].ToString();
            string _fastTest1 = dataRowViewScore["fDiemMiengL1"].ToString();
            string _fastTest2 = dataRowViewScore["fDiemMiengL2"].ToString();
            string _15Test1 = dataRowViewScore["fDiem15L1"].ToString();
            string _15Test2 = dataRowViewScore["fDiem15L2"].ToString();
            string _45Test = dataRowViewScore["fDiem45"].ToString();
            string semesterTest = dataRowViewScore["fDiemThi"].ToString();
            string student = dataRowViewScore["sHoTen"].ToString();
            cbx_semester.SelectedIndex = cbx_semester.FindStringExact(semester);
            cbx_students.SelectedIndex = cbx_students.FindStringExact(student);       
            tb_fastTest1.Text = _fastTest1;
            tb_fastTest2.Text = _fastTest2;
            tb_15test1.Text = _15Test1;
            tb_15test2.Text = _15Test2;
            tb_45test.Text = _45Test;
            tb_semesterGrades.Text = semesterTest;
        }

        private void btn_editScore_Click(object sender, EventArgs e)
        {
            DataView dataViewScore = (DataView)dgv_score.DataSource;
            DataRowView dataRowViewScore = dataViewScore[dgv_score.CurrentRow.Index];

            string scoreID = dataRowViewScore["PK_sMaDiem"].ToString();
            string semester = cbx_semester.SelectedValue.ToString();
            float _fastTest1 = float.Parse(tb_fastTest1.Text);
            float _fastTest2 = float.Parse(tb_fastTest2.Text);
            float _15Test1 = float.Parse(tb_15test1.Text);
            float _15Test2 = float.Parse(tb_15test2.Text);
            float _45Test = float.Parse(tb_45test.Text);
            float semesterTest = float.Parse(tb_semesterGrades.Text);
            string student = cbx_students.SelectedValue.ToString();

            model.Score score = new model.Score(scoreID, semester, student, "",_fastTest1, _fastTest2, _15Test1, _15Test2, _45Test, semesterTest);
            score.editObject();

            displayMainInformation();
            displayScore();
        }

        private void btn_removeScore_Click(object sender, EventArgs e)
        {
            DataView dataViewScore = (DataView)dgv_score.DataSource;
            DataRowView dataRowViewScore = dataViewScore[dgv_score.CurrentRow.Index];

            string scoreID = dataRowViewScore["PK_sMaDiem"].ToString();
            model.Score score = new model.Score();
            score.queryObjectWithId("procDeleteScore", scoreID);
            displayScore();
        }

        private void cbx_semesterFilter_DropDownClosed(object sender, EventArgs e)
        {
            String semesterID;
            semesterID = cbx_semesterFilter.SelectedValue.ToString();
            (dgv_score.DataSource as DataView).RowFilter = string.Format("PK_sMaHocKy LIKE '%{0}%'", semesterID);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            DataView myTableView = (DataView)dgv_score.DataSource;
            DataTable myTable = myTableView.ToTable();         
            utils.UScoreSubjectReport uScoreSubjectReport = new UScoreSubjectReport(myTable, this.subject);
            uScoreSubjectReport.Show();
        }

        private void tb_fastTest1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_fastTest2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_15test1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_15test2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_45test_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_semesterGrades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_seacherByStudentName_TextChanged(object sender, EventArgs e)
        {
            (dgv_score.DataSource as DataView).RowFilter = string.Format("sHoTen LIKE '%{0}%'", tb_seacherByStudentName.Text);
        }
        private void btn_addScore_Click(object sender, EventArgs e)
        {
            string id, semester, student_class, class_subject;
            float fastScore1, fastScore2, _15Score1, _15Score2, _45Score, semesterGrades;

            Random rnd = new Random();
            
            semester = cbx_semester.SelectedValue.ToString();
            fastScore1 = float.Parse(tb_fastTest1.Text);
            fastScore2 = float.Parse(tb_fastTest2.Text);

            _15Score1 = float.Parse(tb_15test1.Text);
            _15Score2 = float.Parse(tb_15test2.Text);

            _45Score = float.Parse(tb_45test.Text);
            semesterGrades = float.Parse(tb_semesterGrades.Text);
            student_class = cbx_students.SelectedValue.ToString();
            class_subject = this.subjectClass;

            int idCode = rnd.Next(999);
            id = String.Format("s{0}", idCode.ToString());
            model.Score score = new model.Score(id, semester, student_class, class_subject, fastScore1, fastScore2, _15Score1, _15Score2, _45Score, semesterGrades);
            score.addObject();
            this.Alert("Success Alert", Form_Alert.enmType.Success);
            displayScore();
        }
        private void displayScore()
        {
            model.Score score = new model.Score();
            using (DataTable scoreTable = score.objectListWithID("procScore", "tblDiem", this.subjectClass))
            {                       
                DataView scoreView = new DataView(scoreTable);
                dgv_score.AutoGenerateColumns = false;
                dgv_score.ReadOnly = true;
                dgv_score.DataSource = scoreView;               
            }
        }    
    }
}
