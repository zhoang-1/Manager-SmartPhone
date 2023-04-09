using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonWinform
{
    public class Khachhang
    {
        public string Id { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }

        public string sdt { get; set; }
        public Khachhang(string id, string ten, string diachi, string sdt)
        {
            this.Id = id;
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;


        }
    }
}