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
    
    public partial class hanghoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hanghoa()
        {
            this.chi_tiet_ban_hang = new HashSet<chi_tiet_ban_hang>();
        }
    
        public string ma_hh { get; set; }
        public string ten_hh { get; set; }
        public int soluong { get; set; }
        public int gia_sp { get; set; }
        public string ma_lh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_ban_hang> chi_tiet_ban_hang { get; set; }
        public virtual loaihang loaihang { get; set; }
    }
}
