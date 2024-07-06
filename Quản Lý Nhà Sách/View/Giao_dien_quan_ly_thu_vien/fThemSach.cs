using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Giao_dien_quan_ly_thu_vien.DAO;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
            txbMaSach_TextChanged();
            cbMaTacGia_SelectedIndexChanged();
            cbMaLinhVuc_SelectedIndexChanged();
            cbMaLoaiSach_SelectedIndexChanged();
            cbMaNXB_SelectedIndexChanged();
        }

        private void txbMaSach_TextChanged()
        {
            Random rd = new Random();
            txbMaSach.Text = ("SA0" + rd.Next(99, 1000));
        }

        private void cbMaTacGia_SelectedIndexChanged()
        {
            string query = "Select MATG, TENTG from TACGIA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenTacGia.DataSource = data;
            cboTenTacGia.ValueMember = "MATG";
            cboTenTacGia.DisplayMember = "TENTG";
        }

        private void cbMaLinhVuc_SelectedIndexChanged()
        {
            string query = "Select MALINHVUC, TENLINHVUC from LINHVUC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenLinhVuc.DataSource = data;
            cboTenLinhVuc.ValueMember = "MALINHVUC";
            cboTenLinhVuc.DisplayMember = "TENLINHVUC";
        }

        private void cbMaLoaiSach_SelectedIndexChanged()
        {
            string query = "Select MALOAISACH, TENLOAISACH from LOAISACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenLoaiSach.DataSource = data;
            cboTenLoaiSach.ValueMember = "MALOAISACH";
            cboTenLoaiSach.DisplayMember = "TENLOAISACH";
        }

        private void cbMaNXB_SelectedIndexChanged()
        {
            string query = "Select MANHAXUATBAN, TENNHAXUATBAN from NHAXUATBAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenNXB.DataSource = data;
            cboTenNXB.ValueMember = "MANHAXUATBAN";
            cboTenNXB.DisplayMember = "TENNHAXUATBAN";
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            if (txbTenSach.Text == "" || cboTenTacGia.Text == "" || cboTenLinhVuc.Text == "" || cboTenLoaiSach.Text == "" || cboTenNXB.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                if (numericUpDownGiaBia.Value > numericUpDownGiaMua.Value)
                {
                    DateTime namxb = dateTimePickerNamXuatBan.Value;
                    string query = "Insert into SACH values('" + txbMaSach.Text + "',N'" + txbTenSach.Text + "'," +
                        "(SELECT MATG FROM TACGIA WHERE TENTG = N'" + cboTenTacGia.Text.ToString() + "')," +
                        "(SELECT MALINHVUC FROM LINHVUC WHERE TENLINHVUC = N'" + cboTenLinhVuc.Text.ToString() + "')," +
                        "(SELECT MALOAISACH FROM LOAISACH WHERE TENLOAISACH = N'" + cboTenLoaiSach.Text.ToString() + "'),'" + numericUpDownGiaMua.Value + "'," +
                        "'" + numericUpDownGiaBia.Value + "','" + numericUpDownLanTaiBan.Value + "'," + 
                        "(SELECT MANHAXUATBAN FROM NHAXUATBAN WHERE TENNHAXUATBAN = N'" + cboTenNXB.Text.ToString() + "'),'" +
                         namxb.ToString("yyyy-MM-dd") + "')";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Không thể để giá bán nhỏ hơn giá nhập!", "THÔNG BÁO");
                }
                txbMaSach_TextChanged();
                txbTenSach.Text = "";
                cbMaTacGia_SelectedIndexChanged();
                cbMaLinhVuc_SelectedIndexChanged();
                cbMaLoaiSach_SelectedIndexChanged();
                cbMaNXB_SelectedIndexChanged();
                numericUpDownGiaMua.Value = 1000;
                numericUpDownGiaBia.Value = 1000;
                numericUpDownLanTaiBan.Value = 0;
                dateTimePickerNamXuatBan.Text = DateTime.Now.ToString();
            }
        }
    }
}
