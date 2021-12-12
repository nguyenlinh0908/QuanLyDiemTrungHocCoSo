using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyDiemTrungHocCoSo
{
    public partial class DSHocSinhtheolop : Form
    {
        SqlConnection Ketnoi;
        SqlCommand Thuchien;
        SqlDataReader Docdl;
        string chuoiketnoi = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        string lenh;
        
        public DSHocSinhtheolop()
        {
            InitializeComponent();
            Ketnoi = new SqlConnection(chuoiketnoi);
            loadTenlop();
            contextMenuStripDSHS.Enabled = false;
            
        }
        public void loadTenlop()
        {
            comboBoxTenlop.Items.Clear();
            lenh = @"SELECT sTenLop FROM tblLopHoc";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            while (Docdl.Read())
            {
                comboBoxTenlop.Items.Add(Docdl[0].ToString());
            }
            Ketnoi.Close();
        }

        private void comboBoxTenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTenGVCN.Items.Clear();
            lenh = @"SELECT tblGiaoVien.sHoTen
                    FROM     tblGiaoVien INNER JOIN
                  tblTaiKhoan ON tblGiaoVien.PK_sMaGiaoVien = tblTaiKhoan.FK_sMaGiaoVien INNER JOIN
                  tblLop_NamHoc ON tblTaiKhoan.PK_sMaTaiKhoan = tblLop_NamHoc.FK_sGiaoVienChuNhiem INNER JOIN
                  tblLopHoc ON tblLop_NamHoc.FK_sMaLop = tblLopHoc.PK_sMaLop
				  where (tblLopHoc.sTenLop = '" + comboBoxTenlop.Text + "')";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            while (Docdl.Read())
            {
                comboBoxTenGVCN.Items.Add(Docdl[0].ToString());
            }
            Ketnoi.Close();
        }

        private void comboBoxTenGVCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewHocSinh.Items.Clear();
            comboBoxNamHoc.Items.Clear();
            lenh = @"SELECT tblNamHoc.sNamHoc
                    FROM     tblNamHoc INNER JOIN
                                      tblLop_NamHoc ON tblNamHoc.PK_sMaNamHoc = tblLop_NamHoc.FK_sMaNamHoc INNER JOIN
                                      tblTaiKhoan ON tblLop_NamHoc.FK_sGiaoVienChuNhiem = tblTaiKhoan.PK_sMaTaiKhoan INNER JOIN
                                      tblGiaoVien ON tblTaiKhoan.FK_sMaGiaoVien = tblGiaoVien.PK_sMaGiaoVien
                    WHERE  (tblGiaoVien.sHoTen = N'" + comboBoxTenGVCN.Text + "')";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            while (Docdl.Read())
            {
                comboBoxNamHoc.Items.Add(Docdl[0].ToString());

            }
            Ketnoi.Close();
        }

        private void comboBoxNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewHocSinh.Items.Clear();
            lenh = @"SELECT tblHocSinh.sHoTen
                    FROM     tblHocSinh INNER JOIN
                                      tblHocSinh_LopHoc ON tblHocSinh.PK_sMaHocSinh = tblHocSinh_LopHoc.FK_sMaHocSinh INNER JOIN
                                      tblLop_NamHoc ON tblHocSinh_LopHoc.FK_sMaLopNamHoc = tblLop_NamHoc.PK_sMaLopNamHoc INNER JOIN
                                      tblNamHoc ON tblLop_NamHoc.FK_sMaNamHoc = tblNamHoc.PK_sMaNamHoc
                    WHERE  (tblNamHoc.sNamHoc = '" + comboBoxNamHoc.Text + "')";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            int i = 0;
            while (Docdl.Read())
            {

                listViewHocSinh.Items.Add((i + 1).ToString());
                listViewHocSinh.Items[i].SubItems.Add(Docdl[0].ToString());
                i++;
            }
            label4.Text = "Tổng số học sinh: ";
            label4.Text = label4.Text + (i).ToString();
            Ketnoi.Close();
        }

        private void listViewHocSinh_Click(object sender, EventArgs e)
        {
            contextMenuStripDSHS.Enabled = true;
        }

        private void contextMenuStripDSHS_Click(object sender, EventArgs e)
        {
            ThongtinchitietHocSinh chitiet = new ThongtinchitietHocSinh();
            lenh = @"SELECT PK_sMaHocSinh,bGioiTinh, sNgaySinh, sDiaChi
                        FROM     tblHocSinh
                        WHERE  (sHoTen = N'" + listViewHocSinh.SelectedItems[0].SubItems[1].Text + "')";
            Ketnoi.Open();
            Thuchien = new SqlCommand(lenh, Ketnoi);
            Docdl = Thuchien.ExecuteReader();
            int i = 0;
            while (Docdl.Read())
            {
                chitiet.txtTenhocsinh.Text = listViewHocSinh.SelectedItems[0].SubItems[1].Text;
                chitiet.txtTenGVCN.Text = comboBoxTenGVCN.Text;
                chitiet.txtNamhoc.Text = comboBoxNamHoc.Text;
                chitiet.txtTenlop.Text = comboBoxTenlop.Text;
                chitiet.txtMahocsinh.Text = Docdl[0].ToString();
                chitiet.txtGioitinh.Text = Docdl[1].ToString();
                chitiet.txtNgaysinh.Text = Docdl[2].ToString();
                chitiet.txtDiachi.Text = Docdl[3].ToString();
                i++;
            }
            Ketnoi.Close();
            chitiet.Show();
        }

        private void DSHocSinhtheolop_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHSDS ds = new ThemHSDS();
            ds.Show();
        }
    }
}
