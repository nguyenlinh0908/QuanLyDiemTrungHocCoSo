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

namespace QuanLyDiemTrungHocCoSo.utils
{
    public partial class UScore : Form
    {
        private String connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        public UScore()
        {
            InitializeComponent();
        }

        private void UScore_Load(object sender, EventArgs e)
        {
            
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;

            // load thông tin cần thiết
            //loadSubjects();
            loadHocKy();
          //  loadLopHoc();
            loadHocSinh();
            // load score table
            displayScore();
        }


        private void loadSubjects()
        {
            using (SqlConnection connectionSubjects = new SqlConnection(connectionString))
            {
                using (SqlCommand commandSubjects = new SqlCommand("", connectionSubjects))
                {
                    using (SqlDataAdapter adapterSubjects = new SqlDataAdapter(commandSubjects))
                    {
                        commandSubjects.CommandType = CommandType.StoredProcedure;
                        commandSubjects.CommandText = "proGetSubjects";

                        DataTable subjectsTable = new DataTable("tblMonHoc");
                        adapterSubjects.Fill(subjectsTable);

                        cbx_subjects.DisplayMember = "sTenMonHoc";
                        cbx_subjects.DataSource = subjectsTable;
                        cbx_subjects.ValueMember = "PK_sMaMonHoc";
                        
                    }
                }
            }
        }

        private void loadLopHoc()
        {
            using (SqlConnection connectionScholastic = new SqlConnection(connectionString))
            {
                using (SqlCommand commandScholastic = new SqlCommand("", connectionScholastic))
                {
                    using (SqlDataAdapter adapterScholastic = new SqlDataAdapter(commandScholastic))
                    {
                        commandScholastic.CommandType = CommandType.StoredProcedure;
                        commandScholastic.CommandText = "proGetClass";
                        DataTable scholasticTable = new DataTable("tblLopHoc");
                        adapterScholastic.Fill(scholasticTable);
                        cbx_class.DisplayMember = "sTenLop";
                        cbx_class.DataSource = scholasticTable;
                        cbx_class.ValueMember = "PK_sMaLop";
                    }
                }
            }
        }
        
        private void loadHocKy()
        {
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
                    }
                }
            }
        }
        private void loadHocSinh()
        {
            using (SqlConnection connectionScholastic = new SqlConnection(connectionString))
            {
                using (SqlCommand commandScholastic = new SqlCommand("", connectionScholastic))
                {
                    using (SqlDataAdapter adapterScholastic = new SqlDataAdapter(commandScholastic))
                    {
                        commandScholastic.CommandType = CommandType.StoredProcedure;
                        commandScholastic.CommandText = "proGetStudentsOfClass";
                        DataTable scholasticTable = new DataTable("tblHocSinh");
                        adapterScholastic.Fill(scholasticTable);
                        cbx_student.DisplayMember = "sHoTen";
                        cbx_student.DataSource = scholasticTable;
                        cbx_student.ValueMember = "PK_sMaHocSinhLopHoc";
                    }
                }
            }
        }

        private void btn_addScore_Click(object sender, EventArgs e)
        {
            string id, semester, student_class, class_subject;
            string type0 ="ld0", type1 = "ld1", type2 = "ld2", type3 = "ld3";
            float fastScore1, fastScore2, _15Score1, _15Score2, _45Score, semesterGrades;

            Random rnd = new Random();
            
            semester = cbx_semester.SelectedValue.ToString();
            fastScore1 = float.Parse(tb_fastTest1.Text);
            fastScore2 = float.Parse(tb_fastTest2.Text);

            _15Score1 = float.Parse(tb_15test1.Text);
            _15Score2 = float.Parse(tb_15test2.Text);

            _45Score = float.Parse(tb_45test.Text);
            semesterGrades = float.Parse(tb_semesterGrades.Text);
            student_class = cbx_student.SelectedValue.ToString();
            class_subject = "lm0";
            
            if (fastScore1 != 0)
            {
                int idCode = rnd.Next(999);
                id = String.Format("s{0}", idCode.ToString());
                model.Score score = new model.Score(id, type0, semester, student_class, class_subject, fastScore1, 1);
                score.addObject();
            }
            if(fastScore2 != 0)
            {
                int idCode = rnd.Next(999);
                id = String.Format("s{0}", idCode.ToString());
                model.Score score = new model.Score(id, type0, semester, student_class, class_subject, fastScore2, 2);
                score.addObject();
            }
            if (_15Score1 != 0)
            {
                int idCode = rnd.Next(999);
                id = String.Format("s{0}", idCode.ToString());
                model.Score score = new model.Score(id, type1, semester, student_class, class_subject, _15Score1, 1);
                score.addObject();
            }
            if (_15Score2 != 0)
            {
                int idCode = rnd.Next(999);
                id = String.Format("s{0}", idCode.ToString());
                model.Score score = new model.Score(id, type1, semester, student_class, class_subject, _15Score2, 2);
                score.addObject();
            }
            if (_45Score != 0)
            {
                int idCode = rnd.Next(999);
                id = String.Format("s{0}", idCode.ToString());
                model.Score score = new model.Score(id, type2, semester, student_class, class_subject, _45Score, 1);
                score.addObject();
            }
            if (semesterGrades != 0)
            {
                int idCode = rnd.Next(999);
                id = String.Format("s{0}", idCode.ToString());
                model.Score score = new model.Score(id, type3, semester, student_class, class_subject, semesterGrades, 1);
                score.addObject();
            }

        }
        private void displayScore()
        {
            model.Score score = new model.Score();
            using (DataTable teachTable = score.objectList("procScore", "tblDiem"))
            {
                DataTable teacherTableDisplay = new DataTable();
                teacherTableDisplay.Clear();
                teacherTableDisplay.Columns.Add("serial", typeof(int));
                teacherTableDisplay.Columns.Add("ID", typeof(string));
                teacherTableDisplay.Columns.Add("studentName", typeof(string));
                teacherTableDisplay.Columns.Add("dateOfBirth", typeof(string));
                teacherTableDisplay.Columns.Add("fastTest1", typeof(float));
                teacherTableDisplay.Columns.Add("fastTest2", typeof(float));
                teacherTableDisplay.Columns.Add("_15Test1", typeof(float));
                teacherTableDisplay.Columns.Add("_15Test2", typeof(float));
                teacherTableDisplay.Columns.Add("_45Test", typeof(float));
                teacherTableDisplay.Columns.Add("semesterGrades", typeof(float));
                int serial = 0;
                for (int i = 0; i < teachTable.Rows.Count; ++i)
                {
                    
                    for (int j = i; j < teachTable.Rows.Count; ++j)
                    {
                        if (String.Compare(teachTable.Rows[i]["PK_sMaHocSinhLopHoc"].ToString(), teachTable.Rows[j]["PK_sMaHocSinhLopHoc"].ToString(), true) == 0
                            && String.Compare(teachTable.Rows[i]["FK_sMaLopMon"].ToString(), teachTable.Rows[j]["FK_sMaLopMon"].ToString(), true) == 0
                            && String.Compare(teachTable.Rows[i]["FK_sMaHocKy"].ToString(), teachTable.Rows[j]["FK_sMaHocKy"].ToString(), true) == 0
                           )
                        {
                            ++serial;
                            DataRow teacherRowDisplay = teacherTableDisplay.NewRow();
                            teacherRowDisplay["serial"] = i;
                            teacherRowDisplay["ID"] = 1;
                            teacherRowDisplay["studentName"] = teachTable.Rows[i]["sHoTen"];
                            teacherRowDisplay["dateOfBirth"] = teachTable.Rows[i]["sNgaySinh"];

                            switch (teachTable.Rows[i]["FK_sMaLoaiDiem"])
                            {
                                case "ld0":
                                    if (Int32.Parse(teachTable.Rows[i]["iLanKiemTra"].ToString()) == 1)
                                    {
                                        teacherRowDisplay["fastTest1"] = teachTable.Rows[i]["fDiem"];
                                    }
                                    else
                                    {
                                        teacherRowDisplay["fastTest2"] = teachTable.Rows[i]["fDiem"];
                                    }
                                    break;
                                case "ld1":
                                    if (Int32.Parse(teachTable.Rows[i]["iLanKiemTra"].ToString()) == 1)
                                    {
                                        teacherRowDisplay["_15Test1"] = teachTable.Rows[i]["fDiem"];
                                    }
                                    else
                                    {
                                        teacherRowDisplay["_15Test2"] = teachTable.Rows[i]["fDiem"];
                                    }
                                    break;
                                case "ld2":
                                    teacherRowDisplay["_45Test"] = teachTable.Rows[i]["fDiem"];
                                    break;
                                case "ld3":
                                    teacherRowDisplay["semesterGrades"] = teachTable.Rows[i]["fDiem"];
                                    break;
                                default:
                                    break;
                            }
                            teacherTableDisplay.Rows.Add(teacherRowDisplay);
                        }
                    }  
                   
                }          
                DataView teacherView = new DataView(teacherTableDisplay);
                dgv_score.AutoGenerateColumns = false;
                dgv_score.ReadOnly = true;
                dgv_score.DataSource = teacherView;
            }
        }

       
    }
}
