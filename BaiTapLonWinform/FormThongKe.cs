using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BaiTapLonWinform
{
    public partial class FormThongKe : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MANHHUNG-ECO\DUCHUY719;Initial Catalog=PHONE_STORE_MANAGER;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ap;
        DataTable dt;
        public FormThongKe()
        {
            InitializeComponent();
        }
        string Query = " select *from SANPHAM";
        //string query = "select *from NHANVIEN";
        modify modify = new modify();
        string query = " select  b.SOBH, b.MADT,b.MAKH,b.DIACHI,b.NGAYMUA,b.NGAYHETHAN,a.GIABAN as THANHTIEN from SANPHAM a ,PHIEUBH b where a.MADT=b.MADT";
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            loadKhachhang();
            loadsanpham();
            LoadSOHD();

            dataGridView2.DataSource = modify.getAllData(query);
            dataGridView1.DataSource = modify.getAllData(Query);
            LoadNhomhang();

            
        }
    



        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            
        }
        public void LoadSOHD()
        {
            con.Open();
            cmd = new SqlCommand("SELECT  SOHD FROM HOADON", con);
            ap = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ap.Fill(dt);

            con.Close();
        }
        public void loadKhachhang()
        {
            con.Open();
            cmd = new SqlCommand("SELECT *FROM KHACHHANG", con);
            ap = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ap.Fill(dt);

            
            con.Close();
        }
        public void loadsanpham()
        {
            con.Open();
            cmd = new SqlCommand("SELECT *FROM SANPHAM", con);
            ap = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ap.Fill(dt);

            
            con.Close();
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
    
        }
        public void LoadNhomhang()
        {

            con.Open();
            cmd = new SqlCommand("SELECT *FROM NHOMHANG", con);
            ap = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ap.Fill(dt);
            
            con.Close();
        }

        

       

        
    }
}
