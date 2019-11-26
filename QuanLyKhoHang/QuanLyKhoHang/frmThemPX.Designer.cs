namespace QuanLyKhoHang
{
    partial class frmThemPX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemPX));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSPX = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSL = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownGN = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 59);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleDescription = "";
            this.dateTimePicker1.AccessibleName = "";
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(409, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 104;
            this.dateTimePicker1.Value = new System.DateTime(2015, 4, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Xuất";
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(100, 18);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(177, 21);
            this.cbChiNhanh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSPX);
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 327);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dgvSPX
            // 
            this.dgvSPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvSPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSPX.Location = new System.Drawing.Point(3, 16);
            this.dgvSPX.Name = "dgvSPX";
            this.dgvSPX.Size = new System.Drawing.Size(299, 308);
            this.dgvSPX.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Mã HH";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Số Lượng";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Giá Xuất";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Thành Tiền";
            this.Column11.Name = "Column11";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTaoMoi);
            this.groupBox2.Controls.Add(this.btnXoaSP);
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.numericUpDownGN);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericUpDownSL);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(336, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 308);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // numericUpDownSL
            // 
            this.numericUpDownSL.Location = new System.Drawing.Point(26, 37);
            this.numericUpDownSL.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownSL.Name = "numericUpDownSL";
            this.numericUpDownSL.Size = new System.Drawing.Size(104, 20);
            this.numericUpDownSL.TabIndex = 131;
            this.numericUpDownSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(26, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 130;
            this.label6.Text = "Số Lượng";
            // 
            // numericUpDownGN
            // 
            this.numericUpDownGN.Location = new System.Drawing.Point(28, 94);
            this.numericUpDownGN.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownGN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGN.Name = "numericUpDownGN";
            this.numericUpDownGN.Size = new System.Drawing.Size(102, 20);
            this.numericUpDownGN.TabIndex = 133;
            this.numericUpDownGN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownGN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(26, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 132;
            this.label11.Text = "Giá xuất";
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemSP.BackgroundImage")));
            this.btnThemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemSP.Location = new System.Drawing.Point(26, 129);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(102, 24);
            this.btnThemSP.TabIndex = 134;
            this.btnThemSP.Text = "<< Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaSP.BackgroundImage")));
            this.btnXoaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoaSP.Location = new System.Drawing.Point(26, 159);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(102, 24);
            this.btnXoaSP.TabIndex = 135;
            this.btnXoaSP.Text = "Xóa >>";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaoMoi.BackgroundImage")));
            this.btnTaoMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTaoMoi.Location = new System.Drawing.Point(28, 189);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(102, 24);
            this.btnTaoMoi.TabIndex = 136;
            this.btnTaoMoi.Text = "Tạo Phiếu Mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            // 
            // frmThemPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThemPX";
            this.Text = "frmThemPX";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownGN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnTaoMoi;
    }
}