using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace BaiTapLonWinform
{
    public partial class FormSanpham : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MANHHUNG-ECO\DUCHUY719;Initial Catalog=PHONE_STORE_MANAGER;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ap;
        DataTable dt;
        public FormSanpham()
        {
            InitializeComponent();
            




        }
        modify modify=new modify();
        string query = " select *from SANPHAM";
        private void FormSanpham_Load(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = modify.getAllData(query);
            LoadNhomhang();
            
            
        }
      
     
        private void button1_Click(object sender, EventArgs e)
        {
            string madt = tbmadt.Text;
            string tendt = tbtendt.Text;
            string manhom = comboBoxManhom.Text;
          
            string giaban = tbgiaban.Text;
            string thoigianbaohanh = comboBox2.Text;
            SanPham sanPham = new SanPham(madt, tendt, manhom, giaban, thoigianbaohanh);
            if (modify.themSanpham(sanPham)){
                MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dataGridView1.DataSource = modify.getAllData(query);
            }
            else
            {
                MessageBox.Show("không thể thêm","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbmadt.Enabled = false;
            tbmadt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbtendt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            comboBoxManhom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tbgiaban.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string madt = tbmadt.Text;
            string tendt = tbtendt.Text;
            string manhom = comboBoxManhom.Text;
            
            string giaban = tbgiaban.Text;
            string thoigianbaohanh = comboBox2.Text;
            SanPham sanPham = new SanPham(madt, tendt, manhom,  giaban, thoigianbaohanh);
            if (modify.Suathongtinsanpham(sanPham))
            {
                MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dataGridView1.DataSource = modify.getAllData(query);
                tbmadt.Text = "";

              
                comboBoxManhom.Text = "";
                tbtendt.Text = "";
                tbgiaban.Text = "";
                
            }
            else
            {
                MessageBox.Show("không thể sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tbtim.Text;
            string sql = "select * from SANPHAM where MADT ='" + id + "'";
            dataGridView1.DataSource = modify.TimSanPham(sql);
            tbtim.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=modify.getAllData(query);
            tbtim.Text = "";
        }

        private void tbtim_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadNhomhang()
        {

            con.Open();
            cmd = new SqlCommand("SELECT *FROM NHOMHANG",con);
            ap = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ap.Fill(dt);
            comboBoxManhom.DataSource = dt;
            comboBoxManhom.DisplayMember = "TENNHOM";
            comboBoxManhom.ValueMember = "MANHOM";
            con.Close();
        }
    }
}
