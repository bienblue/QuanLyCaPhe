using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class nhanvien
    {
        public string ma_nv { get; set; }
        public string ten_nv { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string chucvu { get; set; }
        public string gioitinh { get; set; }
        public DateTime ngay_vao_lam { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public byte[] avatar { get; set; }
    }
}
