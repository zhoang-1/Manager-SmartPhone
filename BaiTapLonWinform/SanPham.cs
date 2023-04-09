using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonWinform
{
    public class SanPham
    {
        public string MADT { get; set; }
        public string TENDT { get; set; }
        public string MANHOM { get; set; }
      

        public string GIABAN { get; set; }
        public string THOIGIANBAOHANH { get; set; }
        public SanPham(string mADT, string tENDT, string mANHOM,  string giaban, string thoigianbaohanh)
        {
            MADT = mADT;
            TENDT = tENDT;
            MANHOM = mANHOM;
           
            GIABAN = giaban;

            THOIGIANBAOHANH = thoigianbaohanh;
        }
    }
}
