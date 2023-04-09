namespace BaiTapLonWinform
{
    partial class FormKhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachhang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbmakhachhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbtenkhachhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbDiachi = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbsodienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.DIACHI,
            this.SDT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // tbmakhachhang
            // 
            this.tbmakhachhang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmakhachhang.Location = new System.Drawing.Point(104, 31);
            this.tbmakhachhang.Name = "tbmakhachhang";
            this.tbmakhachhang.Size = new System.Drawing.Size(187, 22);
            this.tbmakhachhang.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.tbmakhachhang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 85);
            this.panel1.TabIndex = 0;
            // 
            // tbtenkhachhan
            // 
            this.tbtenkhachhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtenkhachhan.Location = new System.Drawing.Point(117, 14);
            this.tbtenkhachhan.Name = "tbtenkhachhan";
            this.tbtenkhachhan.Size = new System.Drawing.Size(174, 22);
            this.tbtenkhachhan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.tbtenkhachhan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(59, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 58);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Controls.Add(this.rtbDiachi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(437, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 85);
            this.panel3.TabIndex = 3;
            // 
            // rtbDiachi
            // 
            this.rtbDiachi.Location = new System.Drawing.Point(104, 17);
            this.rtbDiachi.Name = "rtbDiachi";
            this.rtbDiachi.Size = new System.Drawing.Size(185, 48);
            this.rtbDiachi.TabIndex = 1;
            this.rtbDiachi.Text = "";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 257);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(783, 164);
            this.panel7.TabIndex = 3;
            // 
            // tbsodienthoai
            // 
            this.tbsodienthoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsodienthoai.Location = new System.Drawing.Point(104, 19);
            this.tbsodienthoai.Name = "tbsodienthoai";
            this.tbsodienthoai.Size = new System.Drawing.Size(185, 22);
            this.tbsodienthoai.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(17, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "số điện thoại";
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Red;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(581, 208);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 30);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "TÌM KIẾM";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Red;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(163, 205);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 37);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = " SỬA";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSalmon;
            this.panel4.Controls.Add(this.tbsodienthoai);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(437, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 58);
            this.panel4.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbtim);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(680, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 30);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbtim
            // 
            this.tbtim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtim.Location = new System.Drawing.Point(437, 216);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(121, 22);
            this.tbtim.TabIndex = 8;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Red;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(59, 205);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(82, 37);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "THÊM";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // FormKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(783, 421);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKhachhang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FormKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbmakhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbtenkhachhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbsodienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDiachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}