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
    
    public partial class chi_tiet_ban_hang
    {
        public string ma_hd { get; set; }
        public string ma_hh { get; set; }
        public int soluong { get; set; }
    
        public virtual hoadon hoadon { get; set; }
        public virtual hanghoa hanghoa { get; set; }
    }
}
