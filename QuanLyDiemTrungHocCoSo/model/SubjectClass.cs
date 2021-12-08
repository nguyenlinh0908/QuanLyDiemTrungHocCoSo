using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{
    class SubjectClass : sdk.MainService
    {
        private string subjectClassID, schoolYearClassID, subjectID, accountTeacherID;

        public SubjectClass() { }
        public SubjectClass(string subjectClassID, string schoolYearClassID, string subjectID, string accountTeacherID)
        {
            this.subjectClassID = subjectClassID;
            this.schoolYearClassID = schoolYearClassID;
            this.subjectID = subjectID;
            this.accountTeacherID = accountTeacherID;
        }

        public string SubjectClassID { get => subjectClassID; set => subjectClassID = value; }
        public string SchoolYearClassID { get => schoolYearClassID; set => schoolYearClassID = value; }
        public string SubjectID { get => subjectID; set => subjectID = value; }
        public string AccountTeacherID { get => accountTeacherID; set => accountTeacherID = value; }

        public override void addObject()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procAddSubjectClass";

                    cmd.Parameters.AddWithValue("@id", this.subjectClassID);
                    cmd.Parameters.AddWithValue("@schoolYearClass", this.schoolYearClassID);
                    cmd.Parameters.AddWithValue("@subjectID", this.subjectID);
                    cmd.Parameters.AddWithValue("@accoutTeacherID", this.accountTeacherID);
                   

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
                    cmd.CommandText = "procEditSubjectClass";

                    cmd.Parameters.AddWithValue("@id", this.subjectClassID);
                    cmd.Parameters.AddWithValue("@schoolYearClass", this.schoolYearClassID);
                    cmd.Parameters.AddWithValue("@subjectID", this.subjectID);
                    cmd.Parameters.AddWithValue("@accoutTeacherID", this.accountTeacherID);
                   

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
    }
}
