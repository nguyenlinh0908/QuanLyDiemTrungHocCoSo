using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{
    class Subject
    {
        private string subjectID, subjectName;
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        private DataTable subjectList;
        public Subject() { }
        public Subject(string subjectID, string subjectName)
        {
            this.subjectID = subjectID;
            this.subjectName = subjectName;
            
        }
        public string SubjectID { get => subjectID; set => subjectID = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public DataTable SubjectList { get => subjectList; set => subjectList = value; }

        public void loadSubjects()
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
                        this.subjectList = subjectsTable;
                    }
                }
            }
        }
    }
}
