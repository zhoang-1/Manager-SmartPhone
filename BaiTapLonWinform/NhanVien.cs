using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonWinform
{
    public class NhanVien
    {
        public string MANV { get; set; }
        public string Ten { get; set; }
        public string Diachi{ get; set; }
        public string Sdt{ get; set; }
        public string CMND { get; set; }
        public string Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Chucvu{ get; set; }
        public string Luong { get; set; }
     
        
        public NhanVien(string mANV, string ten, string diachi, string sdt, string cMND, string ngaysinh, string gioitinh, string chucvu, string luong)
        {
            MANV = mANV;
            Ten = ten;
            Diachi = diachi;
            Sdt = sdt;
            CMND = cMND;
            Ngaysinh = ngaysinh;
            Gioitinh = gioitinh;
            Chucvu = chucvu;
            Luong = luong;
          
        }
    }
}
