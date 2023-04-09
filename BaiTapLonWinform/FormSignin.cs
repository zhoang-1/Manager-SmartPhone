using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BaiTapLonWinform
{
    public partial class FormSignin : Form
    {
        public FormSignin()
        {
            InitializeComponent();
        }
        modify modify =new modify();

        public bool checkAcount(string ac)
        {// check mat khau và tai khoan
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string ad)
        {
            return Regex.IsMatch(ad, @"^[a-zA-Z0-9_.]{8,30}@gmail.com(.vn|)$");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = tbtentk.Text;
            string matkhau = tbmk.Text;
            string xacnhanmk = tbxacnhanmk.Text;
            string  email=tbemail.Text;
            if (checkAcount(tentk) == false)
            {
                MessageBox.Show("tên tài khoản bao gồm các kí tự A-Z hoặc 0-9 có độ dài từ 6 đến 24 kí tự ", "Gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkAcount(matkhau)) { MessageBox.Show("mật khẩu bao gồm các kí tự A-Z hoặc 0-9 có độ dài từ 6 đến 24 kí tự ", "Gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (matkhau != xacnhanmk) { MessageBox.Show("xác nhận mật khẩu phải trùng khớp với mật khẩu ", "Gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
        
            if (modify.taikhoans("select * from TAIKHOAN where email='" + email + "'").Count != 0) { MessageBox.Show("email bạn đăng ký  đã được sử  dụng cho một tài khoản khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            try
            {

                string query = "insert into TAIKHOAN values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.dangky(query);
                if (MessageBox.Show(" đăng ký thành công, bạn có muốn đăng nhập bây giờ ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) ;
                this.Close();
                FormLogin form = new FormLogin();
                form.ShowDialog();

            }
            catch
            {
                MessageBox.Show("Tài khoản đã được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        

      
    }
}
