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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCap ncc = new NhaCungCap();
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThi();
            cboTK.SelectedIndex = 0;
        }

        public void HienThi()
        {
            dataGridView1.DataSource = ncc.ShowNCC("");

            Init();
        }
        public void Init()
        {
            if (dataGridView1.RowCount > 1)
            {
                try
                {
                    txtMaNCC.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    txtTenNCC.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txtDiaChi.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txtSDT.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                }
                catch { }
            }

        }
        public void SetNull()
        {
            txtTK.Text = "";
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetNull();
            cboTK.Enabled = false;
            txtTK.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ncc.UpdateNCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
            MessageBox.Show("Sửa dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }

    }
}
