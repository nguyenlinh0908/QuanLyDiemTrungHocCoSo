using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{
    class Student : sdk.MainService
    {
        private string id, name, dateOfBirth, address;
        private byte gender;

        public Student() {}
        public Student(string id, string name, string dateOfBirth, string address, byte gender)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.gender = gender;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public byte Gender { get => gender; set => gender = value; }

        public override void addObject()
        {
            throw new NotImplementedException();
        }

        public override void editObject()
        {
            throw new NotImplementedException();
        }
        
        public DataTable studentListMyClass(string accountID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    using (SqlDataAdapter adapterMyStudents = new SqlDataAdapter(cmd))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "proGetStudentsOfClass";

                        cmd.Parameters.AddWithValue("@accountID", accountID);                        

                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        DataTable datatableMyStudents = new DataTable("tblStudentsMyClass"); // chua thong tin hoc sinh lop mk chu nhiem
                        adapterMyStudents.Fill(datatableMyStudents);
                        return datatableMyStudents;
                    }
                }
            }
        }
    }
}
