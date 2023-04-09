using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonWinform
{
    public class quanly
    {
        public string NGUOIQUANLY { get; set; }
        public string PIN { get; set; }


        public quanly(string taikhoan, string matkhau)
        {
            NGUOIQUANLY = taikhoan;
            PIN = matkhau;
         }
    } }
