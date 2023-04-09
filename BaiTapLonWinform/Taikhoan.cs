using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonWinform
{
    public class Taikhoan
    {
        public string Tentaikhoan { get; set; }
        public string matkhau { get; set; }
    
        public Taikhoan(string tentaikhoan,string tenmatkhau)
        {
            this.Tentaikhoan = tentaikhoan;
            this.matkhau = tenmatkhau;
         
        }

    }
}
