using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.sdk
{
   abstract class MainService
   {
        public string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        public abstract void addObject();
        public abstract void editObject();
        public void removeObject(string proc, string id) {         
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
        public DataTable objectList(string proc, string table)
        {
            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                using (SqlCommand commandObject= new SqlCommand("", connectionObject))
                {
                    using (SqlDataAdapter adapterObject = new SqlDataAdapter(commandObject))
                    {
                        commandObject.CommandType = CommandType.StoredProcedure;
                        commandObject.CommandText = proc;
                        DataTable dataTableObject = new DataTable(table);
                        adapterObject.Fill(dataTableObject);
                        return dataTableObject;
                    }
                }
            }
        }
    }
}
