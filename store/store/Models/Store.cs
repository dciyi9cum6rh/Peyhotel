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
    
    public partial class Store
    {
        public int Sid { get; set; }
        public string StoreID { get; set; }
        public bool IsDel { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> SDate { get; set; }
        public string FKind { get; set; }
        public bool IsOnSale { get; set; }
        public string Company { get; set; }
        public string S_Com { get; set; }
        public string Product { get; set; }
        public string URL { get; set; }
        public string Zip { get; set; }
        public string Zip_sub { get; set; }
        public string County { get; set; }
        public string Town { get; set; }
        public string Addr { get; set; }
        public string CZip { get; set; }
        public string CZip_sub { get; set; }
        public string CCounty { get; set; }
        public string CTown { get; set; }
        public string CAddr { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string ext1 { get; set; }
        public string ext2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string President { get; set; }
        public string PTel { get; set; }
        public string PMobile { get; set; }
        public string PEmail { get; set; }
        public string PIDNO { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string IDNO { get; set; }
        public string SkypeNum { get; set; }
        public Nullable<int> PDAccount { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceNO { get; set; }
        public string PayWay { get; set; }
        public string Bank { get; set; }
        public string BankBrand { get; set; }
        public string BankTitle { get; set; }
        public string BankNO { get; set; }
        public string PayDay { get; set; }
        public string Memo { get; set; }
        public string Esno { get; set; }
        public Nullable<System.DateTime> UDate { get; set; }
        public string Store_Name { get; set; }
        public string Store_Path { get; set; }
        public string Store_Logo { get; set; }
        public string Store_Logo_Footer { get; set; }
        public string Store_AppLogo { get; set; }
        public string Store_Banner { get; set; }
        public string Store_ShortIntro { get; set; }
        public string Store_Intro { get; set; }
        public string Store_Owner { get; set; }
        public string Store_Contact { get; set; }
        public string Store_ShipTime { get; set; }
        public string Store_ShipWay { get; set; }
        public string Store_ShipArea { get; set; }
        public string Store_Service { get; set; }
        public string Store_Memo { get; set; }
        public string Store_privacy { get; set; }
        public string Store_protection { get; set; }
        public string Store_Member { get; set; }
        public string Store_IVNO { get; set; }
        public string Store_Back { get; set; }
        public string Store_QandA { get; set; }
        public string PayKind { get; set; }
        public Nullable<double> FeeAmt { get; set; }
        public Nullable<double> Fee { get; set; }
        public Nullable<double> Bens { get; set; }
        public int JoinCash { get; set; }
        public int RcmCash { get; set; }
        public int ShareCash { get; set; }
        public Nullable<int> WebType { get; set; }
        public Nullable<System.DateTime> ConSdate { get; set; }
        public Nullable<System.DateTime> ConEdate { get; set; }
        public Nullable<bool> IsOWN { get; set; }
        public Nullable<int> ProductPayUseWay { get; set; }
        public string WebVer { get; set; }
        public string AppPage { get; set; }
        public string UIVer { get; set; }
        public string CatalogVer { get; set; }
        public string LBSVer { get; set; }
        public string NavigateFclr { get; set; }
        public string NavigateBclr { get; set; }
        public string LmenuFclr { get; set; }
        public string LmenuBclr { get; set; }
        public string BmenuFclr { get; set; }
        public string BmenuBclr { get; set; }
        public string BmenuOn { get; set; }
        public string PageFclr { get; set; }
        public string PageBclr { get; set; }
        public string HeadFclr { get; set; }
        public string HeadBclr { get; set; }
        public bool Online { get; set; }
        public string AndroidURL { get; set; }
        public string IOSURL { get; set; }
        public string AndroidIDKey { get; set; }
        public string IOSIDKey { get; set; }
        public string IOSFile { get; set; }
        public bool IsUseSMS { get; set; }
        public string UseSMStype { get; set; }
        public int UseSMSnums { get; set; }
        public bool IsUseBranch { get; set; }
        public int UseBranchNums { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKeywords { get; set; }
        public string ogTitle { get; set; }
        public string ogDesc { get; set; }
        public string ogURL { get; set; }
        public string ogIMG { get; set; }
        public string ogIMGpics { get; set; }
        public bool Isflag { get; set; }
    }
}