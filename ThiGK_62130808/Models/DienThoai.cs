//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThiGK_62130808.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DienThoai
    {
        public string MaDT { get; set; }
        public string TenDT { get; set; }
        public Nullable<bool> XuatXu { get; set; }
        public Nullable<int> DonGia { get; set; }
        public string AnhDT { get; set; }
        public string MoTa { get; set; }
        public string PhuKienKemTheo { get; set; }
        public string MaLDT { get; set; }
    
        public virtual LoaiDienThoai LoaiDienThoai { get; set; }
    }
}