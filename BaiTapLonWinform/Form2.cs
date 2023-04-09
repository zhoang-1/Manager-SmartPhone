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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        modify modify = new modify();

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tentk =tbtk.Text;
            string matkhau = tbmk.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập tên tài khoản của người quản lý" +
                    "", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("bạn  chưa nhập mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = " select *from QUANLY where NGUOIQUANLY='" + tentk + "' and PIN='" + matkhau + "'";

                if (modify.quanlys(query).Count != 0)
                {

                    formNhanVien form = new formNhanVien();
                    form.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" bạn đăng nhập SAI hoặctài khoản KHÔNG có quyền truy cập chức năng này chỉ dành cho người quản lý ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
