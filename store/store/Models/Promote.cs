//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Promote
    {
        public string pmid { get; set; }
        public System.DateTime pmdate { get; set; }
        public string pmType { get; set; }
        public bool isDel { get; set; }
        public string StoreID { get; set; }
        public string Sidno { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool OnLine { get; set; }
        public string Subject { get; set; }
        public string SubTitle { get; set; }
        public string Stand { get; set; }
        public double DisRate { get; set; }
        public double TotalAmt { get; set; }
        public string Esno { get; set; }
        public Nullable<System.DateTime> UDate { get; set; }
        public Nullable<bool> IsShowOn_App { get; set; }
        public string MemberLevel { get; set; }
        public string Kind { get; set; }
        public string DisProduct { get; set; }
        public string SC_Id { get; set; }
        public string SC_SId { get; set; }
        public string Contents { get; set; }
        public string ConsumptionType { get; set; }
        public Nullable<int> Limit { get; set; }
        public int LimitUse { get; set; }
        public bool Isflag { get; set; }
    }
}