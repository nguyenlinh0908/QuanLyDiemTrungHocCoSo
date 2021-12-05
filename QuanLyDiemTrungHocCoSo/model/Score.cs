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
        private string scoreID, semesterID, student_class_ID, class_subject_ID;
        private float fastScore1, fastScore2, test15_1, test15_2, test45, lastTest;
        public Score() { }
        public Score(string scoreID, string semesterID, string student_class_ID, string class_subject_ID, float fastScore1, float fastScore2, float test15_1, float test15_2, float test45, float lastTest)
        {
            this.scoreID = scoreID;
            this.semesterID = semesterID;
            this.student_class_ID = student_class_ID;
            this.class_subject_ID = class_subject_ID;

            this.fastScore1 = fastScore1;
            this.fastScore2 = fastScore2;
            this.test15_1 = test15_1;
            this.test15_2 = test15_2;
            this.test45 = test45;
            this.lastTest = lastTest;
        }
        public string ScoreID { get => scoreID; set => scoreID = value; }
        public string SemesterID { get => semesterID; set => semesterID = value; }
        public string Student_class_ID { get => student_class_ID; set => student_class_ID = value; }
        public string Class_subject_ID { get => class_subject_ID; set => class_subject_ID = value; }
        public float FastScore1 { get => fastScore1; set => fastScore1 = value; }
        public float FastScore2 { get => fastScore2; set => fastScore2 = value; }
        public float Test15_1 { get => test15_1; set => test15_1 = value; }
        public float Test15_2 { get => test15_2; set => test15_2 = value; }
        public float Test45 { get => test45; set => test45 = value; }
        public float LastTest { get => lastTest; set => lastTest = value; }

        public override void addObject()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString)) // var connectionString get from abstract class MainService
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procAddScore";
                    cmd.Parameters.AddWithValue("@id", this.scoreID);
                    cmd.Parameters.AddWithValue("@semester", this.semesterID);
                    cmd.Parameters.AddWithValue("@student_class", this.student_class_ID);
                    cmd.Parameters.AddWithValue("@class_subject", this.class_subject_ID);
                    cmd.Parameters.AddWithValue("@fastTest1", this.fastScore1);
                    cmd.Parameters.AddWithValue("@fastTest2", this.fastScore2);
                    cmd.Parameters.AddWithValue("@_15Test1", this.test15_1);
                    cmd.Parameters.AddWithValue("@_15Test2", this.test15_2);
                    cmd.Parameters.AddWithValue("@_45Test", this.test45);
                    cmd.Parameters.AddWithValue("@semesterGrades", this.lastTest);
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
                    cmd.CommandText = "procEditScore";

                    cmd.Parameters.AddWithValue("@id", this.scoreID);
                    cmd.Parameters.AddWithValue("@_fastTest1", this.fastScore1);
                    cmd.Parameters.AddWithValue("@_fastTest2", this.fastScore2);
                    cmd.Parameters.AddWithValue("@_15Test1", this.test15_1);
                    cmd.Parameters.AddWithValue("@_15Test2", this.test15_2);
                    cmd.Parameters.AddWithValue("@_45Test", this.test45);
                    cmd.Parameters.AddWithValue("@semesterTest", this.lastTest);
                    cmd.Parameters.AddWithValue("@studentClassID", this.student_class_ID);
                    cmd.Parameters.AddWithValue("@semesterID", this.semesterID);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }  
    }
}
