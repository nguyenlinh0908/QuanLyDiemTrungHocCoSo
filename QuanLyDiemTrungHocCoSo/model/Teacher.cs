using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{
    class Teacher : sdk.MainService
    {
        private string id, name, dateOfBirth, phoneNumber, identifycationCard, specialize, address;
        private byte gender;

        public Teacher() { }

        public Teacher(string id, string name, string dateOfBirth, byte gender, string address, string phoneNumber, string identifycationCard, string specialize)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.identifycationCard = identifycationCard;
            this.specialize = specialize;
            this.gender = gender;
            this.address = address;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string IdentifycationCard { get => identifycationCard; set => identifycationCard = value; }
        public string Specialize { get => specialize; set => specialize = value; }
        public byte Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value;}

        public override void addObject()
        {   
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procAddTeacher";

                    cmd.Parameters.AddWithValue("@id", this.id);
                    cmd.Parameters.AddWithValue("@name", this.name);
                    cmd.Parameters.AddWithValue("@dateOfBirth", this.dateOfBirth);
                    cmd.Parameters.AddWithValue("@gender", this.gender);
                    cmd.Parameters.AddWithValue("@address", this.address);
                    cmd.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
                    cmd.Parameters.AddWithValue("@identifycationCard", this.identifycationCard);
                    cmd.Parameters.AddWithValue("@specialize", this.specialize);

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
                    cmd.CommandText = "procEditTeacher";

                    cmd.Parameters.AddWithValue("@id", this.id);
                    cmd.Parameters.AddWithValue("@name", this.name);
                    cmd.Parameters.AddWithValue("@dateOfBirth", this.dateOfBirth);
                    cmd.Parameters.AddWithValue("@gender", this.gender);
                    cmd.Parameters.AddWithValue("@address", this.address);
                    cmd.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
                    cmd.Parameters.AddWithValue("@identifycationCard", this.identifycationCard);
                    cmd.Parameters.AddWithValue("@specialize", this.specialize);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }   
    }
}
