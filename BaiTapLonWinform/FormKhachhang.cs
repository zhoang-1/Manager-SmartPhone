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
    public partial class FormKhachhang : Form
    {
        public FormKhachhang()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        string query = "  select *from KHACHHANG";
        private void FormKhachhang_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = modify.getAllData(query);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string MAKH= tbmakhachhang.Text;
            string TENKH= tbtenkhachhan.Text;
            string DIACHI = rtbDiachi.Text;
            string SDT= tbsodienthoai.Text;
            Khachhang khachhang = new Khachhang(MAKH, TENKH, DIACHI,SDT);
            if (modify.ThemNhanVien(khachhang))
            {
                MessageBox.Show("thêm mới khách hàng thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dataGridView1.DataSource = modify.getAllData(query);
                tbmakhachhang.Text = "";
                tbtenkhachhan.Text = "";
                rtbDiachi.Text = "";
                tbsodienthoai.Text = "";
            }
            else
            {
                MessageBox.Show("Không thể thêm", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void btnsua_Click(object sender, EventArgs e)
        {
           
            string MAKH = tbmakhachhang.Text;
            string TENKH = tbtenkhachhan.Text;
            string DIACHI = rtbDiachi.Text;
            string SDT = tbsodienthoai.Text;
            Khachhang khachhang = new Khachhang(MAKH, TENKH, DIACHI, SDT);
            if (modify.SuaNhanVien(khachhang))
            {
                MessageBox.Show("Đã sửa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dataGridView1.DataSource = modify.getAllData(query);
                tbmakhachhang.Text = "";
                tbtenkhachhan.Text = "";
                rtbDiachi.Text = "";
                tbsodienthoai.Text = "";
            }
            else
            {
                MessageBox.Show("Không thể sửa", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            string MAKH = tbtim.Text;
            string sql = "select *from KHACHHANG where MAKH='"+MAKH+"'";
            dataGridView1.DataSource=modify.getAllData(sql);
          
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbmakhachhang.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbtenkhachhan.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            rtbDiachi.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbsodienthoai.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tbmakhachhang.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.getAllData(query);
            tbtim.Text = "";
        }
    }

}
