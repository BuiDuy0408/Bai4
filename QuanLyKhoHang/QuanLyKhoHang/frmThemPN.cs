﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
namespace QuanLyKhoHang
{
    public partial class frmThemPN : Form
    {

        public frmThemPN()
        {
            InitializeComponent();
        }
        HangHoa hh = new HangHoa();
        NhaCungCap ncc = new NhaCungCap();
        PhieuNhap pn = new PhieuNhap();
        ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
        string mahh;
        string tenhh;
        int soluong;
        long gianhap;
        long giaxuat;
        string nsx;
        string thongtin;
        public void HienThi()
        {
            dgvSP.DataSource = hh.ShowHangHoa("");
        }
        private void frmThemPN_Load(object sender, EventArgs e)
        {
            HienThi();
            cboTenNCC.DataSource = ncc.ShowNCC("");
            cboTenNCC.DisplayMember = "TenNCC";
            cboTenNCC.ValueMember = "MaNCC";
            cboTenNCC.SelectedValue = "MaNCC";
            cboTenNCC.SelectedIndex = 0;
        }

        private void TxtTenSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
