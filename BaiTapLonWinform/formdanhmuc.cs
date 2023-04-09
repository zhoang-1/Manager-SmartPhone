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


namespace BaiTapLonWinform
{
    public partial class formdanhmuc : Form
    {
        public formdanhmuc()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        string query = "select *from NHOMHANG";
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string madanhmuc = tbtim.Text;
            string sql = "select *from NHOMHANG where  MANHOM='" + madanhmuc + "'";

            dataGridView1.DataSource = modify.getAllData(sql);

        }
       
        private void btnSuahang_Click(object sender, EventArgs e)
        {
            string madanhmuc = tbmadanhmuc.Text;
          
            string tendanhmuc = tbtendanhmuc.Text;
            danhmuc danhmuc = new danhmuc(madanhmuc,  tendanhmuc);
            if (modify.suadanhmuc(danhmuc))
            {
                MessageBox.Show("đã cập nhật ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dataGridView1.DataSource = modify.getAllData(query);
                tbmadanhmuc.Enabled = true;
                tbmadanhmuc.Text = "";
               
                tbtendanhmuc.Text = "";
            }
            else
            {
                MessageBox.Show("không thể thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnThemhang_Click(object sender, EventArgs e)
        {
            string madanhmuc = tbmadanhmuc.Text;
           
            string tendanhmuc = tbtendanhmuc.Text;
            danhmuc danhmuc = new danhmuc(madanhmuc,tendanhmuc);
            if (modify.themdanhmuc(danhmuc))
            {
                MessageBox.Show("thêm thành công ", "thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                dataGridView1.DataSource=modify.getAllData(query);
                tbmadanhmuc.Enabled = true;
                tbmadanhmuc.Text = "";
               
                tbtendanhmuc.Text = "";
            }
            else
            {
                MessageBox.Show("không thể thêm","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        
        private void formdanhmuc_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = modify.getAllData(query);
          
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbmadanhmuc.Enabled = false;
            tbmadanhmuc.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
          
            tbtendanhmuc.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbtim.Text = "";
            dataGridView1.DataSource= modify.getAllData(query);
        }
    }
}
