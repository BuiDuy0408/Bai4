namespace QuanLyKhoHang
{
    partial class frmHuongDan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Đăng nhập");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Màn hình chính");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Quản lý hàng hóa");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Quản lý khách hàng");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Quản lý nhà cung cấp");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Quản lý nhập xuất");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Thêm phiếu nhập");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Thêm phiếu xuất");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Các chức năng", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Giới thiệu phần mềm", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "gtDangNhap";
            treeNode11.Text = "Đăng nhập";
            treeNode12.Name = "gtManHinhChinh";
            treeNode12.Text = "Màn hình chính";
            treeNode13.Name = "gtHangHoa";
            treeNode13.Text = "Quản lý hàng hóa";
            treeNode14.Name = "gtKhachHang";
            treeNode14.Text = "Quản lý khách hàng";
            treeNode15.Name = "gtNhaCungCap";
            treeNode15.Text = "Quản lý nhà cung cấp";
            treeNode16.Name = "gtNhapXuat";
            treeNode16.Text = "Quản lý nhập xuất";
            treeNode17.Name = "gtThemPN";
            treeNode17.Text = "Thêm phiếu nhập";
            treeNode18.Name = "gtThemPX";
            treeNode18.Text = "Thêm phiếu xuất";
            treeNode19.Name = "gtChucNang";
            treeNode19.Text = "Các chức năng";
            treeNode20.Name = "gtPhanMem";
            treeNode20.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(172, 368);
            this.treeView1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(172, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 277);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Location = new System.Drawing.Point(172, 277);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(639, 91);
            this.txtGioiThieu.TabIndex = 4;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 368);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGioiThieu;
    }
}