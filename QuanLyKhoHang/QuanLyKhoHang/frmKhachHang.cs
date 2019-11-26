using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
        ChiNhanh kh = new ChiNhanh();
        int temp = 0;

        private void KhachHang_Load(object sender, EventArgs e)
        {
            DKOThongTin(false);
            //setNULL();
            //HienThiDGV();
        }

        public void DKOThongTin(bool bl)
        {
            txttenKH.Enabled = txtSoDT.Enabled = txtMaKH.Enabled = txtDC.Enabled = cmbLoaiKH.Enabled = bl;
            cmbGioiTinh.Enabled = txtGhichu.Enabled = bl;
        }
    }
}
