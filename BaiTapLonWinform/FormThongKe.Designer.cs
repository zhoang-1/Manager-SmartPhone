namespace BaiTapLonWinform
{
    partial class FormThongKe
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SOBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYMUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHETHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(201, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 275);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Sản Phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 254);
            this.dataGridView1.TabIndex = 5;
            // 
            // a
            // 
            this.a.DataPropertyName = "MADT";
            this.a.HeaderText = "Mã Điện Thoại";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDT";
            this.Column2.HeaderText = "Tên Điện Thoại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MANHOM";
            this.Column3.HeaderText = "Mã Nhóm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIABAN";
            this.Column4.HeaderText = "Giá Bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "THOIGIANBAOHANH";
            this.Column5.HeaderText = "Thời Gian Bảo Hành";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1088, 227);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Bảo Hành";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOBH,
            this.MADT,
            this.MAKH,
            this.DIACHI,
            this.NGAYMUA,
            this.NGAYHETHAN,
            this.THANHTIEN});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1082, 206);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // SOBH
            // 
            this.SOBH.DataPropertyName = "SOBH";
            this.SOBH.HeaderText = "Mã Bảo Hành";
            this.SOBH.MinimumWidth = 6;
            this.SOBH.Name = "SOBH";
            this.SOBH.Width = 125;
            // 
            // MADT
            // 
            this.MADT.DataPropertyName = "MADT";
            this.MADT.HeaderText = "Mã Sản Phẩm";
            this.MADT.MinimumWidth = 6;
            this.MADT.Name = "MADT";
            this.MADT.Width = 125;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 125;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 155;
            // 
            // NGAYMUA
            // 
            this.NGAYMUA.DataPropertyName = "NGAYMUA";
            this.NGAYMUA.HeaderText = "Ngày Mua";
            this.NGAYMUA.MinimumWidth = 6;
            this.NGAYMUA.Name = "NGAYMUA";
            this.NGAYMUA.Width = 125;
            // 
            // NGAYHETHAN
            // 
            this.NGAYHETHAN.DataPropertyName = "NGAYHETHAN";
            this.NGAYHETHAN.HeaderText = "Ngày Hết Hạn";
            this.NGAYHETHAN.MinimumWidth = 6;
            this.NGAYHETHAN.Name = "NGAYHETHAN";
            this.NGAYHETHAN.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 326);
            this.panel1.TabIndex = 9;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1088, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYMUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHETHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}