using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{
    class Score : sdk.MainService
    {
        private string scoreID, scoreType, semesterID, student_class_ID, class_subject_ID;
        private float myScore;
        private int times;
        public Score() { }
        public Score(string scoreID, string scoreType, string semesterID, string student_class_ID, string class_subject_ID, float myScore, int times)
        {
            this.scoreID = scoreID;
            this.scoreType = scoreType;
            this.semesterID = semesterID;
            this.student_class_ID = student_class_ID;
            this.class_subject_ID = class_subject_ID;
            this.myScore = myScore;
            this.times = times;
        }

        public string ScoreID { get => scoreID; set => scoreID = value; }
        public string ScoreType { get => scoreType; set => scoreType = value; }
        public string SemesterID { get => semesterID; set => semesterID = value; }
        public string Student_class_ID { get => student_class_ID; set => student_class_ID = value; }
        public string Class_subject_ID { get => class_subject_ID; set => class_subject_ID = value; }
        public float MyScore { get => myScore; set => myScore = value; }
        public int Times { get => times; set => times = value; }

        public override void addObject()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procAddScore";
                    cmd.Parameters.AddWithValue("@id", this.ScoreID);
                    cmd.Parameters.AddWithValue("@score", this.myScore);
                    cmd.Parameters.AddWithValue("@typeScore", this.ScoreType);
                    cmd.Parameters.AddWithValue("@semester", this.SemesterID);
                    cmd.Parameters.AddWithValue("@student_class", this.Student_class_ID);
                    cmd.Parameters.AddWithValue("@class_subject", this.Class_subject_ID);
                    cmd.Parameters.AddWithValue("@times", this.Times);
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
