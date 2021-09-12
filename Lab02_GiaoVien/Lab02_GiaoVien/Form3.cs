using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_GiaoVien
{
    public partial class frmThongTinGiaoVien : Form
    {
        private QuanLyGiaoVien quanLyGV;
        public frmThongTinGiaoVien()
        {
            InitializeComponent();
        }
        public frmThongTinGiaoVien(QuanLyGiaoVien qlgv) : this()
        {
            quanLyGV = qlgv;
        }

        private void rdMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
            {
                lblTimKiem.Text = rdMaGV.Text;
                txtSearch.Text = "";
            }
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHoTen.Checked)
            {
                lblTimKiem.Text = rdHoTen.Text;
                txtSearch.Text = "";
            }
        }

        private void rdSoDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSoDT.Checked)
            {
                lblTimKiem.Text = rdSoDT.Text;
                txtSearch.Text = "";
            }
        }

        private void btnSearchOK_Click(object sender, EventArgs e)
        {
            var kieuTim = Tim.TheoHoTen;
            if (rdMaGV.Checked)
            {
                kieuTim = Tim.TheoMa;
            }
            else if (rdHoTen.Checked)
            {
                kieuTim = Tim.TheoHoTen;
            } else if (rdSoDT.Checked)
            {
                kieuTim = Tim.TheoSDT;
            }

            var ketQua = quanLyGV.Tim(txtSearch.Text, kieuTim);

            if (ketQua is null)
            {
                MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var frmTBGiaoVien = new frmTBGiaoVien();
                frmTBGiaoVien.SetText(ketQua.ToString());
                frmTBGiaoVien.ShowDialog();
            }
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
