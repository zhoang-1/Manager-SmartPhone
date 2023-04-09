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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        modify modify = new modify();

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tentk = tbTendangnhap.Text;
            string matkhau = tbMatkhau.Text;
            if (tentk.Trim() == "") {
                MessageBox.Show("vui lòng nhập tên tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (matkhau.Trim() == "") { MessageBox.Show("bạn  chưa nhập mật khẩu","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } else {
                string query = " select *from TAIKHOAN where TAIKHOAN='" + tentk + "' and MATKHAU='" + matkhau + "'";
                
                if (modify.taikhoans(query).Count != 0)
                {
                    
                    formAdmin form = new formAdmin();
                    form.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("tên tài khoản hoặc mật khẩu không chính xác ","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
                }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgetPassWord form=new FormForgetPassWord();
            form.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignin form=new FormSignin();
            form.ShowDialog();
        }
    }
    }

