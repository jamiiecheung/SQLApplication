//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrderDetail
    {
        public int OrderdetailsID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<float> LineItem { get; set; }
        public Nullable<int> Quant { get; set; }
        public Nullable<float> ASP { get; set; }
        public Nullable<System.DateTime> CRD { get; set; }
        public Nullable<System.DateTime> FCD { get; set; }
        public Nullable<System.DateTime> CSD { get; set; }
        public Nullable<System.DateTime> Datelineitemaddedd { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual tblOrder tblOrder { get; set; }
    }
}
