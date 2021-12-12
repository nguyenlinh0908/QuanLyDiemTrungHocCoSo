using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemTrungHocCoSo
{
    public partial class AddStudentClass : Form
    {

        SqlConnection Ketnoi;
        SqlCommand Thuchien;
        SqlDataReader Docdl;
        private String chuoiketnoi = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        string lenh;


        public AddStudentClass()
        {
            InitializeComponent();
            Ketnoi = new SqlConnection(chuoiketnoi);
            loadTenHS();
            loadTenlop();
            
            
            
        }

       

        private void loadTenHS()
        {
            comboBoxLop.Items.Clear();
            lenh = @"SELECT sHoTen FROM tblHocSinh";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            while (Docdl.Read())
            {
                comboBoxTenHS.Items.Add(Docdl[0].ToString());
            }
            Ketnoi.Close();
        }

        private void loadTenlop()
        {
            comboBoxLop.Items.Clear();
            lenh = @"SELECT sTenLop FROM tblLopHoc";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            while (Docdl.Read())
            {
                comboBoxLop.Items.Add(Docdl[0].ToString());
            }
            Ketnoi.Close();
        }

        private void comboBoxTenHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaHS.Items.Clear();
            lenh = @"SELECT PK_sMaHocSinh
                    FROM     tblHocSinh
                    WHERE  (sHoTen = N'" + comboBoxTenHS.Text + "') ";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            while (Docdl.Read())
            {
                comboBoxMaHS.Items.Add(Docdl[0].ToString());
            }
            Ketnoi.Close();
        }
        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLopNamHoc.Items.Clear();
            lenh = @"SELECT tblLop_NamHoc.PK_sMaLopNamHoc
                    FROM     tblLop_NamHoc INNER JOIN
                    tblLopHoc ON tblLop_NamHoc.FK_sMaLop = tblLopHoc.PK_sMaLop
                    WHERE(tblLopHoc.sTenLop = '"+comboBoxLop.Text+"')";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            while (Docdl.Read())
            {
                comboBoxLopNamHoc.Items.Add(Docdl[0].ToString());
            }
            Ketnoi.Close();
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (Ketnoi = new SqlConnection(chuoiketnoi))
            {
                using (Thuchien = new SqlCommand("", Ketnoi))
                {
                    Thuchien.CommandType = CommandType.StoredProcedure;
                    Thuchien.CommandText = "spHocSinh_LopHoc_Insert";
                    //cmd.Parameters.Add("@PK_sMaHocSinh", SqlDbType.VarChar).Direction = ParameterDirection.Output;

                    Thuchien.Parameters.AddWithValue("@PK_sMaHocSinhLopHoc", txtMaHSLH.Text);
                    Thuchien.Parameters.AddWithValue("@FK_sMaHocSinh", comboBoxMaHS.Text);
                    Thuchien.Parameters.AddWithValue("@sFK_sMaLopNamHoc", comboBoxLopNamHoc.Text);


                    Ketnoi.Open();
                    Thuchien.ExecuteNonQuery();
                    Ketnoi.Close();

                    MessageBox.Show("Thêm học sinh thành công","Thông báo", MessageBoxButtons.OK);
                    
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DSHocSinhtheolop ds = new DSHocSinhtheolop();
            ds.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            txtMaHSLH.ResetText();
            comboBoxTenHS.ResetText();
            comboBoxMaHS.ResetText();
            comboBoxLopNamHoc.ResetText();
            comboBoxLop.ResetText();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            string delete = "DELETE FROM tblHocSinh_LopHoc WHERE FK_sMaHocSinh = @FK_sMaHocSinh";

            using ( Ketnoi = new SqlConnection(chuoiketnoi))
            {
                using (Thuchien = new SqlCommand(delete, Ketnoi))
                {

                    Thuchien.Parameters.AddWithValue("@PK_sMaHocSinhLopHoc", txtMaHSLH.Text);
                    Thuchien.Parameters.AddWithValue("@FK_sMaHocSinh", comboBoxMaHS.Text);
                    Thuchien.Parameters.AddWithValue("@sFK_sMaLopNamHoc", comboBoxLopNamHoc.Text);

                    Ketnoi.Open();
                    Thuchien.ExecuteNonQuery();
                    Ketnoi.Close();
                    MessageBox.Show("Xóa học sinh thành công", "Thông báo", MessageBoxButtons.OK);

                }
            }
        }






        
    }
}
