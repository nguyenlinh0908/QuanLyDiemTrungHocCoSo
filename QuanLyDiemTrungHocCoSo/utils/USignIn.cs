﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemTrungHocCoSo.utils
{
    public partial class USignIn : Form
    {
        public USignIn()
        {
            InitializeComponent();
            this.Text = "Đăng nhập hệ thống";
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btn_signIn_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string pasword = tb_password.Text.Trim();           
            model.Account account = new model.Account();
            using (DataTable myAccounts = account.signInProcess(username, pasword))
            {
                if (myAccounts != null)
                {
                    if (myAccounts.Rows.Count > 0)
                    {
                        this.Alert("Login Success", Form_Alert.enmType.Success);
                        string permission = myAccounts.Rows[0]["FK_sMaQuyen"].ToString();
                        string accountID = myAccounts.Rows[0]["PK_sMaTaiKhoan"].ToString();
                        utils.UHomePage homePage;
                        switch (permission)
                        {
                            case "q0": // admin permission
                                homePage = new utils.UHomePage(permission, accountID);
                               // this.Hide();
                                homePage.Show();
                                break;
                            case "q1": //user permission
                                homePage = new utils.UHomePage(permission, accountID);
                                //this.Hide();
                                homePage.Show();
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    this.Alert("Login Fail", Form_Alert.enmType.Warning);
                }
            }
        }

        private void USignIn_Load(object sender, EventArgs e)
        {

        }

        private void tb_username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_username.Text))
            {
                e.Cancel = true;
                tb_username.Focus();
                ErrorProvider error = new ErrorProvider();
                error.SetError(tb_username, "Please enter your user name!");
            }
        }
       
        private void tb_password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_password.Text))
            {
                e.Cancel = true;
                tb_password.Focus();
                ErrorProvider error = new ErrorProvider();
                error.SetError(tb_password, "Please enter your password!");
            }
        }
    }
}
