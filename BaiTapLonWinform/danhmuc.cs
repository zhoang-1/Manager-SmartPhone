using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonWinform
{
    public  class danhmuc
    {
        public string madanhmuc { get;set;}
        
        public string tendanhmuc { get;set;}
        public danhmuc(string madanhmuc, string tendanhmuc)
        {
            this.madanhmuc = madanhmuc;
         
            this.tendanhmuc = tendanhmuc;
        }
    }
}
