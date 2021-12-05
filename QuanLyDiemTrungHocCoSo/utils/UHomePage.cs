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
            using (DataTable teacherHaveAccount = teacher.objectList("procAccounts", "tblGiaoVien"))
            {
                DataView teacherHaveView = new DataView(teacherHaveAccount);
                cbx_teacher.DataSource = teacherHaveView;
                cbx_teacher.DisplayMember = "sHoTen";
                cbx_teacher.ValueMember = "PK_sMaTaiKhoan";

            }
            using (DataTable teacherHaveAccount = teacher.objectList("proGetClass", "tblLopHoc"))
            {
                DataView teacherHaveView = new DataView(teacherHaveAccount);
                cbx_class.DataSource = teacherHaveView;
                cbx_class.DisplayMember = "sTenLop";
                cbx_class.ValueMember = "PK_sMaLop";

            }
            using (DataTable teacherHaveAccount = teacher.objectList("procSchoolYear", "tblNamHoc"))
            {
                DataView teacherHaveView = new DataView(teacherHaveAccount);
                cbx_schoolYear.DataSource = teacherHaveView;
                cbx_schoolYear.DisplayMember = "sNamHoc";
                cbx_schoolYear.ValueMember = "PK_sMaNamHoc";
            }
            using (DataTable teacherHaveAccount = teacher.objectList("procClassSchoolYear", "tblLop_NamHoc"))
            {
                DataView teacherHaveView = new DataView(teacherHaveAccount);
                dgv_classSchoolYear.AutoGenerateColumns = false;
                dgv_classSchoolYear.ReadOnly = true;
                dgv_classSchoolYear.DataSource = teacherHaveView;
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

        private void btn_addHeadAccount_Click(object sender, EventArgs e)
        {
            createHeadTeacher();
            displayHeadTeacher();
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
                lb_numberOfStudents.Text = myStudents.Rows.Count.ToString();
                lb_className.Text = myStudents.Rows[0]["sTenLop"].ToString();
                DataView myStudentsView = new DataView(myStudents);
                dgv_MyStudents.AutoGenerateColumns = false;
                dgv_MyStudents.ReadOnly = true;
                dgv_MyStudents.DataSource = myStudentsView;
            }
        }

        private void dgv_classITeach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LoadSerial(dgv_classITeach);

        }



        // Quản lý giảng dạy
        private void displayClassITeach()
        {
            model.Class classITeach = new model.Class();
            using (DataTable myClass = classITeach.objectListWithID("procClassSubjectWithAccount", "tblClassSubjectWithID", this.accountID))
            {              
                DataView myClassView = new DataView(myClass);
                dgv_classITeach.AutoGenerateColumns = false;
                dgv_classITeach.ReadOnly = true;
                dgv_classITeach.DataSource = myClassView;
            }
            
        }
    }
}
