using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{
    class HeadTeacher : sdk.MainService
    {
        private string id, schoolYearID, classID, accountID;

        public HeadTeacher() { }
        public HeadTeacher(string id, string schoolYearID, string classID, string accountID)
        {
            this.id = id;
            this.schoolYearID = schoolYearID;
            this.classID = classID;
            this.accountID = accountID;
        }

        public string Id { get => id; set => id = value; }
        public string SchoolYearID { get => schoolYearID; set => schoolYearID = value; }
        public string ClassID { get => classID; set => classID = value; }
        public string AccountID { get => accountID; set => accountID = value; }

        public override void addObject()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procAddClassSchoolYear"; 

                    cmd.Parameters.AddWithValue("@id", this.id);
                    cmd.Parameters.AddWithValue("@schoolYearID", this.schoolYearID);
                    cmd.Parameters.AddWithValue("@classID", this.classID);
                    cmd.Parameters.AddWithValue("@accountID", this.accountID);     

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        public override void editObject()
        {
            throw new NotImplementedException();
        }
    }
}
