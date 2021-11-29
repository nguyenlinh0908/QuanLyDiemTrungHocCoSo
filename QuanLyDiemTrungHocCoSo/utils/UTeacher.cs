using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Controls;

namespace QuanLyDiemTrungHocCoSo.utils
{
    public partial class UTeacher : Form
    {
        public UTeacher()
        {
            InitializeComponent();
        }

        private void UTeacher_Load(object sender, EventArgs e)
        {
            loadSpecialize();
            displayTeachList();
        }
        
        private void loadSpecialize()
        {
            model.Subject subject = new model.Subject(); // create a model subject
            subject.loadSubjects(); // running method get subject list
            // render to cbx
            cbx_specialize.DataSource = subject.SubjectList;
            cbx_specialize.DisplayMember = "sTenMonHoc";
            cbx_specialize.ValueMember = "PK_sMaMonHoc";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name, dateOfBirth, phoneNumber, address, identitfycationCard, specialize;
            byte gender = 1;

            name = tb_teacherName.Text;
            dateOfBirth = dtp_dateOfBirth.Text;
            phoneNumber = tb_phoneNumber.Text;
            address = tb_address.Text;
            identitfycationCard = tb_identifycationCard.Text;

            specialize = cbx_specialize.SelectedValue.ToString();
            name = checkEmptyString(name, lb_teacherName.Text);
            identitfycationCard = checkEmptyString(identitfycationCard, lb_identifycationCard.Text);
          

            bool isMale = rdb_gender1.Checked; // check radio button had checked
            if (isMale)
                gender = 1; // 1 is male
            else
                gender = 0; // 0 is female
            Random rnd = new Random();
            int idCode = rnd.Next(999);
            string id = String.Format("gv{0}", idCode.ToString());
            model.Teacher teacher = new model.Teacher(id, name, dateOfBirth, gender, address, phoneNumber, identitfycationCard, specialize);
            teacher.addObject();
            displayTeachList();
        }

        private string checkEmptyString(string str, string tag)
        {
            
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show(String.Format("{0} không được để trống !", tag));
            }
            return str;
        }
        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        private void displayTeachList()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            model.Teacher teacher = new model.Teacher();
            using(DataTable teachTable = teacher.objectList("procTeacherList", "tblGiaoVien"))
            {
                DataView teacherView = new DataView(teachTable);
                dgv_teacher.AutoGenerateColumns = false;
                dgv_teacher.ReadOnly = true;
                dgv_teacher.DataSource = teacherView;
            } 
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DataView dataViewTeacher = (DataView)dgv_teacher.DataSource;
            DataRowView dataRowViewTeacher = dataViewTeacher[dgv_teacher.CurrentRow.Index];

            model.Teacher teacher = new model.Teacher();
            string teacherID = dataRowViewTeacher["PK_sMaGiaoVien"].ToString();
            teacher.removeObject("procRemoveTeacher", teacherID);
            displayTeachList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataView teacherView = (DataView)dgv_teacher.DataSource;
            DataRowView teacherRow = teacherView[dgv_teacher.CurrentRow.Index];
      
            if (object.Equals(teacherRow["bGioiTinh"], "Nam"))
            {
                rdb_gender1.Checked = true;
            }
            else
            {
                rdb_gender0.Checked = true;
            }
            // restore data teacher to form
            tb_teacherName.Text = teacherRow["sHoTen"].ToString();
            dtp_dateOfBirth.Value = DateTime.ParseExact(teacherRow["sNgaySinh"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); // set value for datetimepicker
            tb_phoneNumber.Text = teacherRow["sSDT"].ToString();
            tb_address.Text = teacherRow["sQueQuan"].ToString();
            tb_identifycationCard.Text = teacherRow["sCMND"].ToString();
            cbx_specialize.SelectedItem = teacherRow["sTenMonHoc"].ToString();


        }
    }
}
