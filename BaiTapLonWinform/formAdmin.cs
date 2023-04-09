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
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }
        public static string quyen;
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            
        }
        

        private void btnFormSanPham_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UCDIENTHOAIcs uCDIENTHOAIcs= new UCDIENTHOAIcs();
           panel2.Controls.Add(uCDIENTHOAIcs);
            panel2.BackgroundImage = null;
            panel2.BackColor = Color.White;
          
        }

        private void btnhang_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UCDanhmuc uCDanhmuc = new UCDanhmuc();
            panel2.Controls.Add(uCDanhmuc);
            panel2.BackgroundImage = null;
            panel2.BackColor = Color.White;
        }

        private void btnKhachahang_Click(object sender, EventArgs e)
        {
          panel2.Controls.Clear();
            UcKhachhang ucKhachhang = new UcKhachhang();
            panel2.Controls.Add(ucKhachhang);
            panel2.BackgroundImage = null;
            panel2.BackColor = Color.White;
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UCHoadon uCHoadon = new UCHoadon();
            panel2.Controls.Add(uCHoadon);
            panel2.BackgroundImage = null;
            panel2.BackColor = Color.White;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin form = new FormLogin();
            form.Show();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            quảnLýNhânViênToolStripMenuItem.Enabled = true;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.Show();
        }

        

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe form = new FormThongKe();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UCTrungbay uCTrungbay = new UCTrungbay();
            panel2.Controls.Add(uCTrungbay);
            panel2.BackgroundImage = null;
            panel2.BackColor = Color.Bisque;
        }
    }
}
