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
    public partial class UForgotPassword : Form
    {
        private string accountID;
        public UForgotPassword(string accountID,string teacherName, string username)
        {
            this.accountID = accountID;
            InitializeComponent();
            tb_teacherName.Text = teacherName;
            tb_username.Text = username;
        }

        private void UForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            string password = tbl_pass1.Text;
            string repeatPassword = tb_pass2.Text;
            if(object.Equals(password, repeatPassword))
            {
                model.Account account = new model.Account(this.accountID,"", password, "", "");
                account.editObject();
            }
        }
    }
}
