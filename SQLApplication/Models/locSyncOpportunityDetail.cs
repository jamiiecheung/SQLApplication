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
    
    public partial class locSyncOpportunityDetail
    {
        public int OrderDetailID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}