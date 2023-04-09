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
using System.Data;

namespace BaiTapLonWinform
{
    public partial class UCHoadon : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MANHHUNG-ECO\DUCHUY719;Initial Catalog=PHONE_STORE_MANAGER;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ap;
        DataTable dt;
        modify modify = new modify();
        string query = " select  b.SOBH, b.MADT,b.MAKH,b.DIACHI,b.NGAYMUA,b.NGAYHETHAN from SANPHAM a ,PHIEUBH b where a.MADT=b.MADT";
        public UCHoadon()
        {
            InitializeComponent();
        }

        private void UCHoadon_Load(object sender, EventArgs e)
        {
            loadKhachhang();
            loadsanpham();
            LoadSOHD();

            dataGridView1.DataSource = modify.getAllData(query);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mahoadon = cbSOHD.Text;

            string madt = cbMADT.Text;
            string makh = cbKH.Text;
            string diachi = tbdiachi.Text;
            DateTime ngaymua = dateTimePicker1.Value;
            DateTime ngayhethan = dateTimePicker1.Value.AddMonths(12);
            hoadon hoadon = new hoadon(mahoadon, madt, makh, diachi, ngaymua, ngayhethan);
            if (modify.laphoadon(hoadon))
            {
                MessageBox.Show("đã cập nhật ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dataGridView1.DataSource = modify.getAllData(query);
            }
            else
            {
                MessageBox.Show("không thể thêm", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            cbSOHD.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cbMADT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cbKH.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbdiachi.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[4].Value;
            dateTimePicker2.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[5].Value;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.getAllData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
        public void LoadSOHD()
        {
            con.Open();
            cmd = new SqlCommand("SELECT  SOHD FROM HOADON", con);
            ap = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ap.Fill(dt);

            ;



            cbSOHD.DataSource = dt;
            cbSOHD.DisplayMember = "SOHD";

            con.Close();
        }
        public void loadKhachhang()
        {
            con.Open();
            cmd = new SqlCommand("SELECT *FROM KHACHHANG", con);
            ap = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ap.Fill(dt);

            cbKH.DataSource = dt;
            cbKH.DisplayMember = "TENKH";
            cbKH.ValueMember = "MAKH";
            con.Close();
        }
        public void loadsanpham()
        {
            con.Open();
            cmd = new SqlCommand("SELECT *FROM SANPHAM", con);
            ap = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ap.Fill(dt);

            cbMADT.DataSource = dt;
            cbMADT.DisplayMember = "TENDT";
            cbMADT.ValueMember = "MADT";
            con.Close();
        }
    }
}
