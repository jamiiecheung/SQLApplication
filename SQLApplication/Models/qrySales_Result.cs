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
    
    public partial class qrySales_Result
    {
        public int AUTOID { get; set; }
        public string SALES_PERSON { get; set; }
        public string PRINCIPAL { get; set; }
        public string OEM_POS { get; set; }
        public string PURCHASING_CUSTOMER { get; set; }
        public string CUSTOMER { get; set; }
        public string Customer_Nickname { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string ZIP { get; set; }
        public string DISTI { get; set; }
        public string PO_NUMBER { get; set; }
        public string SO_NUMBER { get; set; }
        public string INVOICE_NUMBER { get; set; }
        public string PRODUCT_LINE__ { get; set; }
        public string PART_NUMBER { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<double> QTY { get; set; }
        public Nullable<double> UNIT_COST { get; set; }
        public Nullable<double> UNIT_RESALE { get; set; }
        public Nullable<double> GROSS_INVOICE { get; set; }
        public Nullable<int> SPLIT__ { get; set; }
        public Nullable<double> NET_INVOICE { get; set; }
        public string COMM__ { get; set; }
        public Nullable<double> COMMISSIONS { get; set; }
        public string SPLIT_Num { get; set; }
        public Nullable<System.DateTime> Date_Imported { get; set; }
        public string PaidStatus { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public string AB { get; set; }
    }
}
