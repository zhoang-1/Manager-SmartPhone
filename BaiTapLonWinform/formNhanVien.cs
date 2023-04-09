using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonWinform
{
    public partial class formNhanVien : Form
    {
        public formNhanVien()
        {
            InitializeComponent();
        }
        modify modify= new modify();
        string query = "select *from NHANVIEN";
        private void formNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.getAllData(query);
        }
        //ttwrtw
        private void label1_Click(object sender, EventArgs e)
        {

        }
        NhanVien nhanVien;
        private void button1_Click(object sender, EventArgs e)
        {
            string MANV = tbMANV.Text;
                string TENNV = tbTENNV.Text;
            string DIACHI = tbDIACHI.Text;
            string SDT = tbSODIENTHOAI.Text;
            string CMND=tbCMND.Text;
            string NGAYSINH = dateTimePicker1.Text;
            string GIOITINH = comboBox1.Text;
            string CHUCVU =comboBox2.Text;
            string LUONG=tbLUONG.Text;
      ;
             nhanVien = new NhanVien(MANV, TENNV, DIACHI, SDT, CMND, NGAYSINH, GIOITINH, CHUCVU, LUONG);
            if (modify.themNhanVien(nhanVien))
            {
                MessageBox.Show("Thêm nhân viên thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                comboBox2.Text = "";
                tbCMND.Text = "";
                tbMANV.Text = "";
                tbSODIENTHOAI.Text = "";
               
                comboBox1.Text = "";
                tbDIACHI.Text = "";
                tbTENNV.Text = "";
                tbDIACHI.Text = "";
                dataGridView1.DataSource = modify.getAllData(query);
            }
        }

   


        private void button2_Click(object sender, EventArgs e)
        {
            string MANV = tbMANV.Text;
            string TENNV = tbTENNV.Text;
            string DIACHI = tbDIACHI.Text;
            string SDT = tbSODIENTHOAI.Text;
            string CMND = tbCMND.Text;
            string NGAYSINH = dateTimePicker1.Text;
            string GIOITINH = comboBox1.Text;
            string CHUCVU = comboBox2.Text;
            string LUONG = tbLUONG.Text;
            
        
            nhanVien = new NhanVien(MANV, TENNV, DIACHI, SDT, CMND, NGAYSINH, GIOITINH, CHUCVU, LUONG);
            if (modify.SuaNhanVien(nhanVien))
            {
                MessageBox.Show("Đã Sửa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                dataGridView1.DataSource = modify.getAllData(query);
                comboBox2.Text = "";
                tbCMND.Text = "";
                tbMANV.Text = "";
                tbSODIENTHOAI.Text = "";
                
               
                comboBox1.Text = "";
                tbDIACHI.Text = "";
                tbTENNV.Text = "";
                tbDIACHI.Text = "";
                
            }
            else
            {
                MessageBox.Show("Không thể sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string manv = tbtim.Text;
            string query2 = "select * from NHANVIEN where MANV='" + manv + "'";
            dataGridView1.DataSource = modify.getAllData(query2);
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.getAllData(query);
            tbtim.Text = "";
        }

        private void tbtim_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMANV.ReadOnly = true;
            tbMANV.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbTENNV.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbDIACHI.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbSODIENTHOAI.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tbCMND.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[5].Value;
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            tbLUONG.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

                
        }
    }
}
