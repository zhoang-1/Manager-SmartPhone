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
    public partial class FormForgetPassWord : Form
    {
        public FormForgetPassWord()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("bạn hãy nhập email của mình vào ", " thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            
            {
                string query = "select * from TAIKHOAN Where EMAIL='" + email + "'";
                if (modify.taikhoans(query).Count != 0)
                {
                    lbketqua.ForeColor = Color.White;
                    lbketqua.Text = "mật khẩu " + modify.taikhoans(query)[0].matkhau;
                }
                else
                {
                    lbketqua.ForeColor= Color.Gray;
                    lbketqua.Text = "bạn nhập sai email hoặc email của bạn không tồn tại";
                }
            }
        }
    }
}
