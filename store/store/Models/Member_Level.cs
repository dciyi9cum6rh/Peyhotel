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
    
    public partial class Member_Level
    {
        public int id { get; set; }
        public Nullable<System.DateTime> NDate { get; set; }
        public string StoreID { get; set; }
        public bool IsOnline { get; set; }
        public bool IsDel { get; set; }
        public string Subject { get; set; }
        public int Grade { get; set; }
        public string Esno { get; set; }
        public Nullable<System.DateTime> UDate { get; set; }
        public string Memo { get; set; }
        public int Rule1 { get; set; }
        public int Rule2 { get; set; }
        public double Exchange { get; set; }
        public bool Isflag { get; set; }
    }
}
