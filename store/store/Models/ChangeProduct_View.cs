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
    
    public partial class ChangeProduct_View
    {
        public int id { get; set; }
        public Nullable<System.DateTime> NDate { get; set; }
        public int Type { get; set; }
        public Nullable<long> Kind { get; set; }
        public string CKName { get; set; }
        public string subject { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public bool IsOnline { get; set; }
        public bool IsDel { get; set; }
        public Nullable<long> MLid { get; set; }
        public Nullable<double> DisCountAmt { get; set; }
        public string PicName { get; set; }
        public string SC_Id { get; set; }
        public string SC_SId { get; set; }
        public string Contents { get; set; }
        public bool IsExchange { get; set; }
        public Nullable<double> basediscount { get; set; }
        public Nullable<int> Total { get; set; }
        public int UseDays { get; set; }
        public Nullable<int> SortNo { get; set; }
    }
}
