using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonWinform
{
    public class hoadon
    {
        public string mahoadon { get; set; }
        public string madt { get; set; }
        public string makh { get; set; }
        public string diachi { get; set; }
        public DateTime ngaymua { get; set; }
        public DateTime ngayhethanbaohanh { get; set; }
        public hoadon(string mahoadon, string madt, string makh, string diachi, DateTime ngaymua, DateTime ngayhethanbaohanh)
        {
            this.mahoadon = mahoadon;
            this.madt = madt;
            this.makh = makh;
            this.diachi = diachi;
            this.ngaymua = ngaymua;
            this.ngayhethanbaohanh = ngayhethanbaohanh;
        }
    }
}
