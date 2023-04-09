namespace BaiTapLonWinform
{
    partial class formdanhmuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdanhmuc));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbtendanhmuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSuahang = new System.Windows.Forms.Button();
            this.tbmadanhmuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(407, 133);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 37);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "TÌM KIẾM";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Red;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(6, 137);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 37);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnThemhang_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 187);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(605, 198);
            this.panel7.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // tbtendanhmuc
            // 
            this.tbtendanhmuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtendanhmuc.Location = new System.Drawing.Point(70, 15);
            this.tbtendanhmuc.Name = "tbtendanhmuc";
            this.tbtendanhmuc.Size = new System.Drawing.Size(100, 22);
            this.tbtendanhmuc.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên hãng";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSalmon;
            this.panel6.Controls.Add(this.tbtendanhmuc);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(217, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 48);
            this.panel6.TabIndex = 4;
            // 
            // btnSuahang
            // 
            this.btnSuahang.BackColor = System.Drawing.Color.Red;
            this.btnSuahang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuahang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSuahang.Image = ((System.Drawing.Image)(resources.GetObject("btnSuahang.Image")));
            this.btnSuahang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuahang.Location = new System.Drawing.Point(139, 140);
            this.btnSuahang.Name = "btnSuahang";
            this.btnSuahang.Size = new System.Drawing.Size(104, 37);
            this.btnSuahang.TabIndex = 6;
            this.btnSuahang.Text = "SỬA";
            this.btnSuahang.UseVisualStyleBackColor = false;
            this.btnSuahang.Click += new System.EventHandler(this.btnSuahang_Click);
            // 
            // tbmadanhmuc
            // 
            this.tbmadanhmuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmadanhmuc.Location = new System.Drawing.Point(67, 12);
            this.tbmadanhmuc.Name = "tbmadanhmuc";
            this.tbmadanhmuc.Size = new System.Drawing.Size(103, 22);
            this.tbmadanhmuc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hãng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.tbmadanhmuc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 48);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbtim);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSuahang);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(553, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbtim
            // 
            this.tbtim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtim.Location = new System.Drawing.Point(249, 148);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(155, 22);
            this.tbtim.TabIndex = 8;
            // 
            // formdanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(605, 385);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formdanhmuc";
            this.Text = "Hãng điện thoại";
            this.Load += new System.EventHandler(this.formdanhmuc_Load);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbtendanhmuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSuahang;
        private System.Windows.Forms.TextBox tbmadanhmuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbtim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}