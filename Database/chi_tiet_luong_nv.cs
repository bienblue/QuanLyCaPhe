//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class chi_tiet_luong_nv
    {
        public string ma_ca { get; set; }
        public string ma_nv { get; set; }
        public int tong_ca_trong_thang { get; set; }
        public int thanh_tien { get; set; }
    
        public virtual calamviec calamviec { get; set; }
        public virtual nhanvien nhanvien { get; set; }
    }
}
