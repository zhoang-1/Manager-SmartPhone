namespace BaiTapLonWinform
{
    partial class formNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbMANV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTENNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbDIACHI = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbSODIENTHOAI = new System.Windows.Forms.TextBox();
            this.SĐT = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbLUONG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 363);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.DIACHI,
            this.SDT,
            this.CMND,
            this.NGAYSINH,
            this.GIOITINH,
            this.CHUCVU,
            this.LUONG});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.tbMANV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 52);
            this.panel2.TabIndex = 1;
            // 
            // tbMANV
            // 
            this.tbMANV.Location = new System.Drawing.Point(57, 15);
            this.tbMANV.Name = "tbMANV";
            this.tbMANV.Size = new System.Drawing.Size(172, 20);
            this.tbMANV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Controls.Add(this.tbTENNV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(18, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 52);
            this.panel3.TabIndex = 2;
            // 
            // tbTENNV
            // 
            this.tbTENNV.Location = new System.Drawing.Point(60, 15);
            this.tbTENNV.Name = "tbTENNV";
            this.tbTENNV.Size = new System.Drawing.Size(172, 20);
            this.tbTENNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TENNV";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Controls.Add(this.tbDIACHI);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(552, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 61);
            this.panel4.TabIndex = 2;
            // 
            // tbDIACHI
            // 
            this.tbDIACHI.Location = new System.Drawing.Point(60, 7);
            this.tbDIACHI.Name = "tbDIACHI";
            this.tbDIACHI.Size = new System.Drawing.Size(165, 43);
            this.tbDIACHI.TabIndex = 1;
            this.tbDIACHI.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đia chỉ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.Controls.Add(this.tbSODIENTHOAI);
            this.panel5.Controls.Add(this.SĐT);
            this.panel5.Location = new System.Drawing.Point(287, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 52);
            this.panel5.TabIndex = 2;
            // 
            // tbSODIENTHOAI
            // 
            this.tbSODIENTHOAI.Location = new System.Drawing.Point(48, 15);
            this.tbSODIENTHOAI.Name = "tbSODIENTHOAI";
            this.tbSODIENTHOAI.Size = new System.Drawing.Size(172, 20);
            this.tbSODIENTHOAI.TabIndex = 1;
            // 
            // SĐT
            // 
            this.SĐT.AutoSize = true;
            this.SĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SĐT.ForeColor = System.Drawing.Color.Red;
            this.SĐT.Location = new System.Drawing.Point(10, 15);
            this.SĐT.Name = "SĐT";
            this.SĐT.Size = new System.Drawing.Size(32, 13);
            this.SĐT.TabIndex = 0;
            this.SĐT.Text = "SĐT";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.tbCMND);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(287, 83);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 52);
            this.panel6.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CMND";
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(48, 18);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(172, 20);
            this.tbCMND.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SandyBrown;
            this.panel7.Controls.Add(this.dateTimePicker1);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(21, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 72);
            this.panel7.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SandyBrown;
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(558, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(238, 52);
            this.panel8.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "nam\t",
            "nu"});
            this.comboBox1.Location = new System.Drawing.Point(72, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới tính";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SandyBrown;
            this.panel9.Controls.Add(this.comboBox2);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(808, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(238, 52);
            this.panel9.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nhan vien ban hang",
            "Nhan vien bao ve",
            "quan ly",
            "Nhan vien sale"});
            this.comboBox2.Location = new System.Drawing.Point(72, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(10, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chức vụ";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SandyBrown;
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.tbLUONG);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Location = new System.Drawing.Point(808, 83);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(244, 52);
            this.panel10.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(5, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Lương";
            // 
            // tbLUONG
            // 
            this.tbLUONG.Location = new System.Drawing.Point(69, 17);
            this.tbLUONG.Name = "tbLUONG";
            this.tbLUONG.Size = new System.Drawing.Size(160, 20);
            this.tbLUONG.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(323, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "THÊM";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(472, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "SỬA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbtim
            // 
            this.tbtim.Location = new System.Drawing.Point(630, 188);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(130, 20);
            this.tbtim.TabIndex = 5;
            this.tbtim.TextChanged += new System.EventHandler(this.tbtim_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(766, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Tìm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(896, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 37);
            this.button4.TabIndex = 7;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên nhân viên";
            this.TENNV.Name = "TENNV";
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
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Số căn cước";
            this.CMND.Name = "CMND";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // CHUCVU
            // 
            this.CHUCVU.DataPropertyName = "CHUCVU";
            this.CHUCVU.HeaderText = "Chức vụ";
            this.CHUCVU.Name = "CHUCVU";
            // 
            // LUONG
            // 
            this.LUONG.DataPropertyName = "LUONG";
            this.LUONG.HeaderText = "Lương";
            this.LUONG.Name = "LUONG";
            // 
            // formNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 601);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbtim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.formNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbMANV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbTENNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbSODIENTHOAI;
        private System.Windows.Forms.Label SĐT;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbLUONG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox tbDIACHI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
    }
}