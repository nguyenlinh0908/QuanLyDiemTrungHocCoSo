using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemTrungHocCoSo.utils
{
    public partial class UHomePage : Form
    {
        private string accountID, permission;
        public UHomePage(string permission, string accountID)
        {

            InitializeComponent();
            switch (permission)
            {
                case "q0": // admin permission
                    this.accountID = accountID;
                    this.permission = permission;
                    tabControlHomePage.Controls.Remove(tab_myClass);
                    displayTeacher();
                    displayHeadTeacher();
                    break;
                case "q1": //user permission
                    this.accountID = accountID;
                    this.permission = permission;
                    tabControlHomePage.Controls.Remove(tabAccountManager);
                    tabControlHomePage.Controls.Remove(tab_headTeacher);
                    displayMyStudents();
                    displayClassITeach();
                    break;
                default:
                    break;
            }
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        // quản lý công tác


        private void displayTeacher()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            model.Teacher teacher = new model.Teacher();
            using (DataTable teacherNoAccountTable = teacher.objectList("procTeacherNoAccount", "tblGiaoVien"))
            {
                DataView teacherNoAccountView = new DataView(teacherNoAccountTable);
                cbx_teacherNoAccount.DisplayMember = "sHoTen";
                cbx_teacherNoAccount.DataSource = teacherNoAccountView;
                cbx_teacherNoAccount.ValueMember = "PK_sMaGiaoVien";
            }

            using (DataTable premissionTable = teacher.objectList("procPermission", "tblQuyen"))
            {
                DataView premissionView = new DataView(premissionTable);
                cbx_permission.DisplayMember = "sTenQuyen";
                cbx_permission.DataSource = premissionView;
                cbx_permission.ValueMember = "PK_sMaQuyen";
            }
            using (DataTable teacherHaveAccount = teacher.objectList("procAccounts", "tblGiaoVien"))
            {
                DataView teacherHaveView = new DataView(teacherHaveAccount);
                dgv_accounts.AutoGenerateColumns = false;
                dgv_accounts.ReadOnly = true;
                dgv_accounts.DataSource = teacherHaveView;

                cbx_subjectTeacher.DataSource = teacherHaveView;
                cbx_subjectTeacher.DisplayMember = "sHoTen";
                cbx_subjectTeacher.ValueMember = "PK_sMaTaiKhoan";

            }          
        }
        private void LoadSerial(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                grid.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
        }

        private void dgv_accounts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LoadSerial(dgv_accounts);
        }
 

        // sign up account for teacher
        private void signUpAccount()
        {
            string teacherID, username, password, permissionID;
            teacherID = cbx_teacherNoAccount.SelectedValue.ToString();
            username = tb_username.Text.Trim();
            password = tb_password.Text.Trim();
            permissionID = cbx_permission.SelectedValue.ToString();
            Random rnd = new Random();
            string accountID = String.Format("tk{0}", rnd.Next(0, 9999).ToString());
            model.Account account = new model.Account(accountID, username, password, teacherID, permissionID);
            account.addObject();
        }        
        private void displayHeadTeacher()
        {
            model.Teacher teacher = new model.Teacher();
            model.SubjectClass subjectClass = new model.SubjectClass();
            using (DataTable teacherHaveAccount = teacher.objectList("procAccounts", "tblGiaoVien"))
            {
                DataView teacherHaveView = new DataView(teacherHaveAccount);
                cbx_teacher.DataSource = teacherHaveView;
                cbx_teacher.DisplayMember = "sHoTen";
                cbx_teacher.ValueMember = "PK_sMaTaiKhoan";

            }
            using (DataTable dataTableClass = teacher.objectList("proGetClass", "tblLopHoc"))
            {
                DataView dataViewClass = new DataView(dataTableClass);
                cbx_class.DataSource = dataViewClass;
                cbx_class.DisplayMember = "sTenLop";
                cbx_class.ValueMember = "PK_sMaLop";

            }
            using (DataTable dataTableSchoolYear = teacher.objectList("procSchoolYear", "tblNamHoc"))
            {
                DataView dataViewSchoolYear = new DataView(dataTableSchoolYear);
                cbx_schoolYear.DataSource = dataViewSchoolYear;
                cbx_schoolYear.DisplayMember = "sNamHoc";
                cbx_schoolYear.ValueMember = "PK_sMaNamHoc";
            }
            using (DataTable dataTableClassSchooYear = teacher.objectList("procClassSchoolYear", "tblLop_NamHoc"))
            {
                DataView dataViewClassSchoolYear = new DataView(dataTableClassSchooYear);
                dgv_classSchoolYear.AutoGenerateColumns = false;
                dgv_classSchoolYear.ReadOnly = true;
                dgv_classSchoolYear.DataSource = dataViewClassSchoolYear;
            }
            using (DataTable dataTableSubjectClass = subjectClass.objectList("procAllClassSubject", "tblLop_Mon"))
            {
                DataView dataViewSubjectClass = new DataView(dataTableSubjectClass);
                dgv_subjectClass.AutoGenerateColumns = false;
                dgv_subjectClass.ReadOnly = true;
                dgv_subjectClass.DataSource = dataViewSubjectClass;
            }
            model.Subject subject = new model.Subject();
            using (DataTable mySubject = subject.objectList("proGetSubjects", "tblMonHoc"))
            {
                DataView mySubjectDataView = new DataView(mySubject);
                cbx_subjectClass.DataSource = mySubjectDataView;
                cbx_subjectClass.DisplayMember = "sTenMonHoc";
                cbx_subjectClass.ValueMember = "PK_sMaMonHoc";
            }
            model.Class classSchooYear = new model.Class();
            using (DataTable myClassSchoolYear = classSchooYear.objectList("procAllClassSchoolYear", "tblLop_NamHoc"))
            {
                DataView myClassView = new DataView(myClassSchoolYear);
                cbx_classSchoolYear.DataSource = myClassView;
                cbx_classSchoolYear.DisplayMember = "sTenLop";
                cbx_classSchoolYear.ValueMember = "PK_sMaLopNamHoc";
            }
        }
        private void createHeadTeacher()
        {
            Random rnd = new Random();
            string id = String.Format("ln{0}", rnd.Next(0, 9999).ToString());
            string accountID = cbx_teacher.SelectedValue.ToString();
            string schoolYearID = cbx_schoolYear.SelectedValue.ToString();
            string classID = cbx_class.SelectedValue.ToString();
            model.HeadTeacher headTeacher = new model.HeadTeacher(id, schoolYearID, classID, accountID);
            headTeacher.addObject();
        }

        private void dgv_classSchoolYear_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LoadSerial(dgv_classSchoolYear);
        }

        private void dgv_MyStudents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LoadSerial(dgv_MyStudents);
        }

        private void btn_UiScore_Click(object sender, EventArgs e)
        {
            DataView dataViewClass = (DataView)dgv_classITeach.DataSource;
            DataRowView dataRowViewClass = dataViewClass[dgv_classITeach.CurrentRow.Index];
            string classSubjectID = dataRowViewClass["PK_sMaLopMon"].ToString();
            string myclass = dataRowViewClass["sTenLop"].ToString();
            string subject = dataRowViewClass["sTenMonHoc"].ToString();
            string classSchoolYear = dataRowViewClass["PK_sMaLopNamHoc"].ToString();
            utils.UScore uScore = new utils.UScore(myclass, subject, classSubjectID, classSchoolYear);
            uScore.Show();
        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh();
            hocSinh.Show();
        }

        private void btn_addTeacher_Click(object sender, EventArgs e)
        {
            utils.UTeacher uTeacher = new utils.UTeacher();
            uTeacher.Show();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            signUpAccount();
            this.Alert("Success", Form_Alert.enmType.Success);
            displayTeacher();
        }

        private void dgv_accounts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {         
            DataView dataViewTeacher = (DataView)dgv_accounts.DataSource;
            DataRowView dataRowViewTeacher = dataViewTeacher[dgv_accounts.CurrentRow.Index];
            string accountID = dataRowViewTeacher["PK_sMaTaiKhoan"].ToString();
            string teacherName = dataRowViewTeacher["sHoTen"].ToString();
            string username = dataRowViewTeacher["sUsername"].ToString();
            utils.UForgotPassword uForgotPassword = new utils.UForgotPassword(accountID, teacherName, username);
            uForgotPassword.Show();
        }




        // thong tin lop minh chu nhiem
        private void displayMyStudents() // hien thi danh sach nhưng hoc sinh minh chu nhiem
        {
            model.Student myClass = new model.Student();
            using(DataTable myStudents = myClass.studentListMyClass(this.accountID))
            {
                if(myStudents.Rows.Count > 0)
                {
                    lb_numberOfStudents.Text = myStudents.Rows.Count.ToString();
                    lb_className.Text = myStudents.Rows[0]["sTenLop"].ToString();
                    DataView myStudentsView = new DataView(myStudents);
                    dgv_MyStudents.AutoGenerateColumns = false;
                    dgv_MyStudents.ReadOnly = true;
                    dgv_MyStudents.DataSource = myStudentsView;
                    
                }
                else
                {
                    btn_viewScore.Enabled = false;
                }
            }
        }

        private void dgv_classITeach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LoadSerial(dgv_classITeach);
        }

        private void btn_addHeadAccount_Click(object sender, EventArgs e)
        {
            createHeadTeacher();
            this.Alert("Success", Form_Alert.enmType.Success);
            displayHeadTeacher();
        }

        private void dgv_classSchoolYear_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataView dataViewClassSchoolYear = (DataView)dgv_classSchoolYear.DataSource;
            DataRowView dataRowViewSchoolYear = dataViewClassSchoolYear[dgv_classSchoolYear.CurrentRow.Index];

            string teacherName  = dataRowViewSchoolYear["sHoTen"].ToString();
            string className    = dataRowViewSchoolYear["sTenLop"].ToString();
            string year         = dataRowViewSchoolYear["sNamHoc"].ToString();
            cbx_teacher.SelectedIndex = cbx_teacher.FindStringExact(teacherName);
            cbx_class.SelectedIndex = cbx_class.FindStringExact(className);
            cbx_schoolYear.SelectedIndex = cbx_schoolYear.FindStringExact(year);
        }

        private void btn_editHeadTeacher_Click(object sender, EventArgs e)
        {
            DataView dataViewClassSchoolYear = (DataView)dgv_classSchoolYear.DataSource;
            DataRowView dataRowViewSchoolYear = dataViewClassSchoolYear[dgv_classSchoolYear.CurrentRow.Index];

            string id = dataRowViewSchoolYear["PK_sMaLopNamHoc"].ToString();
            string teacherID = cbx_teacher.SelectedValue.ToString();
            string classID = cbx_class.SelectedValue.ToString();
            string schoolYearID = cbx_schoolYear.SelectedValue.ToString();

            model.HeadTeacher headTeacher = new model.HeadTeacher(id, schoolYearID, classID, teacherID);
            headTeacher.editObject();
            this.Alert("Success", Form_Alert.enmType.Success);
            displayHeadTeacher();

        }

        private void btn_addSubjectTeacher_Click(object sender, EventArgs e)
        {
            string teacherID, subjectID, classID;
            teacherID = cbx_subjectTeacher.SelectedValue.ToString();
            classID = cbx_classSchoolYear.SelectedValue.ToString();
            subjectID = cbx_subjectClass.SelectedValue.ToString();

            string subjectClassID;
            Random random = new Random();
            subjectClassID = "lm"+random.Next(0, 9999).ToString();

            model.SubjectClass subjectClass = new model.SubjectClass(subjectClassID, classID, subjectID, teacherID);
            subjectClass.addObject();
            this.Alert("Success", Form_Alert.enmType.Success);
            displayHeadTeacher();
        }

        private void dgv_subjectClass_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataView dataViewSubjectClass = (DataView)dgv_subjectClass.DataSource;
            DataRowView dataRowViewSubjectClass = dataViewSubjectClass[dgv_subjectClass.CurrentRow.Index];

            string teacherName = dataRowViewSubjectClass["sHoTen"].ToString();
            string className = dataRowViewSubjectClass["sTenLop"].ToString();
            string subjectName = dataRowViewSubjectClass["sTenMonHoc"].ToString();

            cbx_subjectTeacher.SelectedIndex = cbx_teacher.FindStringExact(teacherName);
            cbx_classSchoolYear.SelectedIndex = cbx_classSchoolYear.FindStringExact(className);
            cbx_subjectClass.SelectedIndex = cbx_subjectClass.FindStringExact(subjectName);
        }

        private void btn_editSubjectTeacher_Click(object sender, EventArgs e)
        {
            string subjectClassID,teacherID, subjectID, classID;
            DataView dataViewSubjectClass = (DataView)dgv_subjectClass.DataSource;
            DataRowView dataRowViewSubjectClass = dataViewSubjectClass[dgv_subjectClass.CurrentRow.Index];

            subjectClassID = dataRowViewSubjectClass["PK_sMaLopMon"].ToString();
            teacherID = cbx_subjectTeacher.SelectedValue.ToString();
            classID = cbx_classSchoolYear.SelectedValue.ToString();
            subjectID = cbx_subjectClass.SelectedValue.ToString();

           
            model.SubjectClass subjectClass =  new model.SubjectClass(subjectClassID, classID, subjectID, teacherID);
            subjectClass.editObject();
            this.Alert("Success", Form_Alert.enmType.Success);
            displayHeadTeacher();
        }

        private void UHomePage_Load(object sender, EventArgs e)
        {

        }
        private void btn_viewScore_Click(object sender, EventArgs e)
        {
            DataView dataViewStudents = (DataView)dgv_MyStudents.DataSource;
            DataRowView dataRowViewStudents = dataViewStudents[0];
            string classYearID = dataRowViewStudents["PK_sMaLopNamHoc"].ToString();

            utils.UScoreTableView uScoreTableView = new utils.UScoreTableView(classYearID);
            uScoreTableView.Show();
        }

        // Quản lý giảng dạy
        private void displayClassITeach()
        {
            model.Class classITeach = new model.Class();
            using (DataTable myClass = classITeach.objectListWithID("procClassSubjectWithAccount", "tblClassSubjectWithID", this.accountID))
            {              
                if(myClass.Rows.Count > 0) 
                {
                    DataView myClassView = new DataView(myClass);
                    dgv_classITeach.AutoGenerateColumns = false;
                    dgv_classITeach.ReadOnly = true;
                    dgv_classITeach.DataSource = myClassView;

                    lb_warningClassSubject.Hide();
                    btn_UiScore.Enabled = true;
                }
                else
                {
                    btn_UiScore.Enabled = false;
                    lb_warningClassSubject.Show();
                }
            }
        }
    }
}
