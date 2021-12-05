using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{    
    class Account : sdk.MainService
    {
        private string accountID, teacherID, permissionID;
        private string username, password;

        public Account() { }
        public Account(string accountID, string username, string password, string teacherID, string permissionID)
        {
            this.accountID = accountID;
            this.teacherID = teacherID;
            this.permissionID = permissionID;
            this.username = username;
            this.password = password;
        }

        public string AccountID { get => accountID; set => accountID = value; }
        public string TeacherID { get => teacherID; set => teacherID = value; }
        public string PermissionID { get => permissionID; set => permissionID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public override void addObject()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procAddAccount";

                    cmd.Parameters.AddWithValue("@accountID", this.accountID);
                    cmd.Parameters.AddWithValue("@username", this.username);
                    cmd.Parameters.AddWithValue("@password", this.password);
                    cmd.Parameters.AddWithValue("@teacherID", this.teacherID);
                    cmd.Parameters.AddWithValue("@permissionID", this.permissionID);
                  
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        public override void editObject()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procForgotPassword";

                    cmd.Parameters.AddWithValue("@accountID", this.accountID);
                    cmd.Parameters.AddWithValue("@password", this.password);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }  
        
        public DataTable signInProcess(string username, string password)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {                  
                    using (SqlDataAdapter adapterSignIn = new SqlDataAdapter(cmd))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "procSignIn";

                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        DataTable datatableAccountSigned = new DataTable("tblAccountSigned");
                        adapterSignIn.Fill(datatableAccountSigned);
                        return datatableAccountSigned;
                    }
                }
            }
        }
    }
}
