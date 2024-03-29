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
        public void hi()
        {

        }
        public void SetNull()
        {
            txtTenSP.Text = "";
            txtNSX.Text = "";
            txtMoTa.Text = "";
            numericUpDownGX.Value = numericUpDown2.Value = numericUpDown3.Value = 1;
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenhh = txtTenSP.Text;
            soluong = Convert.ToInt32(numericUpDown2.Value.ToString());
            gianhap = long.Parse(numericUpDown3.Value.ToString());
            giaxuat = long.Parse(numericUpDownGX.Value.ToString());
            nsx = txtNSX.Text;
            thongtin = txtMoTa.Text;
            //string ma = hh.InsertHangHoa(tenhh, soluong, gianhap, giaxuat, nsx, thongtin);
            MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
            //if (dgvSP.SelectedRows.Count > 0)
            //{
            //    dgvSPN.Rows.AddRange(new DataGridViewRow());
            //    dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[1].Value = ma;
            //    dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[2].Value = soluong;
            //    dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[3].Value = gianhap;
            //    dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[4].Value = soluong * gianhap;
            //}
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên NSX !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMoTa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin sản phẩm !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string ma = hh.InsertHangHoa(tenhh, soluong, gianhap, giaxuat, nsx, thongtin);
                dgvSPN.Rows.AddRange(new DataGridViewRow());
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[1].Value = ma;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[2].Value = soluong;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[3].Value = gianhap;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[4].Value = soluong * gianhap;

                MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
                //cboTK.Enabled = true;
                //txtTK.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
            catch { }
            SetNull();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetNull();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSPN.Rows.Count; i++)
            {
                if (dgvSPN.Rows[i].Cells[0].Value == dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[0].Value)
                {
                    MessageBox.Show("Sản phẩm đã được chọn !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (dgvSP.SelectedRows.Count > 0)
            {
                dgvSPN.Rows.AddRange(new DataGridViewRow());
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[0].Value = mahh;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[1].Value = numericUpDownSL.Value;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[2].Value = numericUpDownGN.Value;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[3].Value = int.Parse(numericUpDownSL.Value.ToString()) * long.Parse(numericUpDownGN.Value.ToString());
            }
        }
        int indexSPN = 0;
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSPN.Rows.RemoveAt(indexSPN);
                indexSPN--;
            }
            catch
            {

            }
        }

        private void TxtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void DomainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
