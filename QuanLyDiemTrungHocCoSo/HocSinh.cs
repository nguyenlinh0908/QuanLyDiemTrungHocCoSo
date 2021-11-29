using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyDiemTrungHocCoSo
{
    public partial class HocSinh : Form
    {
        public HocSinh()
        {
            InitializeComponent();
        }
        private DataTable getHocSinh()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyDiem"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spHocSinh_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(Cmd))
                    {
                        DataTable tbl = new DataTable("tblHocSinh");
                        da.Fill(tbl);
                        return tbl;
                    }    

                }    
            }    
        } 
        private void HienDanhSachHocSinh()
        {
            using (DataTable tblHocSinh = getHocSinh())
            {
                DataView dvHocSinh = new DataView(tblHocSinh);
                dgrHocSinh.AutoGenerateColumns = false;
                dgrHocSinh.ReadOnly = true;
                dgrHocSinh.DataSource = dvHocSinh;
               
            }    
        }

        private void HocSinh_Load(object sender, EventArgs e)
        {
            HienDanhSachHocSinh();
        }

        //xong tìm kiếm
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyDiem"].ConnectionString;
            string timkiem = "SELECT *FROM tblHocSinh WHERE sHoTen = @sHoTen";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(timkiem, cnn))
                {
                    cmd.Parameters.AddWithValue("PK_sMaHocSinh", txtMahocsinh.Text);
                    cmd.Parameters.AddWithValue("sHoTen", txtTenhocsinh.Text);
                    cmd.Parameters.AddWithValue("bGioiTinh", rbtNu.Checked);
                    cmd.Parameters.AddWithValue("sNgaySinh", txtNgaysinh.Text);
                    cmd.Parameters.AddWithValue("sDiaChi", txtDiachi.Text);

                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgrHocSinh.DataSource = dt;
                    cnn.Close();
                    

                }
            }




        }

        //xong thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyDiem"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spHocSinh_Insert";
                        //cmd.Parameters.Add("@PK_sMaHocSinh", SqlDbType.VarChar).Direction = ParameterDirection.Output;
                    
                    cmd.Parameters.AddWithValue("@PK_sMaHocSinh", txtMahocsinh.Text);
                    cmd.Parameters.AddWithValue("@sHoTen", txtTenhocsinh.Text);
                    cmd.Parameters.AddWithValue("@bGioiTinh", rbtNu.Checked);
                    cmd.Parameters.AddWithValue("@sNgaySinh",txtNgaysinh.Text);
                    cmd.Parameters.AddWithValue("@sDiaChi", txtDiachi.Text);


                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    
                    HocSinh_Load(sender, e);
                }
            }
            

        }

        //xong sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyDiem"].ConnectionString;
            using(SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "spHocSinh_Update";

                    

                    Cmd.Parameters.AddWithValue("@PK_sMaHocSinh", txtMahocsinh.Text);
                    Cmd.Parameters.AddWithValue("@sHoTen", txtTenhocsinh.Text);
                    Cmd.Parameters.AddWithValue("@bGioiTinh", rbtNu.Checked);
                    Cmd.Parameters.AddWithValue("@sNgaySinh", txtNgaysinh.Text);
                    Cmd.Parameters.AddWithValue("@sDiaChi", txtDiachi.Text);

                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();

                    HocSinh_Load(sender, e);
                }    
            }    
        }

       

        private void dgrHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMahocsinh.Text = dgrHocSinh[0, e.RowIndex].Value.ToString();
                txtTenhocsinh.Text = dgrHocSinh[1, e.RowIndex].Value.ToString();
                txtNgaysinh.Text = dgrHocSinh[3, e.RowIndex].Value.ToString();
                txtDiachi.Text = dgrHocSinh[4, e.RowIndex].Value.ToString();
                

                //dateTimeNgaysinh.Value = (DateTime)dgrDanhsach[4, e.RowIndex].Value;
                //txtTencoquan.Text = dgrDanhsach[5, e.RowIndex].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        //xong thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Form1 abc = new Form1();
            //abc.ShowDialog();
        }

        //xong xóa
        private void btnXoa_Click(object sender, EventArgs e)
        { 
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyDiem"].ConnectionString;
            string delete = "DELETE FROM tblHocSinh WHERE PK_sMaHocSinh = @PK_sMaHocSinh";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(delete, cnn))
                {
                    cmd.Parameters.AddWithValue("PK_sMaHocSinh", txtMahocsinh.Text);
                    cmd.Parameters.AddWithValue("sHoTen", txtTenhocsinh.Text);
                    cmd.Parameters.AddWithValue("bGioiTinh", rbtNu.Checked);
                    cmd.Parameters.AddWithValue("sNgaySinh", txtNgaysinh.Text);
                    cmd.Parameters.AddWithValue("sDiaChi", txtDiachi.Text);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    HienDanhSachHocSinh();

                }
            }
        }

        //xong btnRequest
        private void btnRequest_Click(object sender, EventArgs e)
        {
            txtMahocsinh.ResetText();
            txtTenhocsinh.ResetText();
            
            txtNgaysinh.ResetText();
            txtDiachi.ResetText();
            HocSinh_Load(sender, e);
        }

        private void btnXemchitiet_Click(object sender, EventArgs e)
        {
            DSHocSinhtheolop ds = new DSHocSinhtheolop();
            ds.Show();
        }
    }
}
