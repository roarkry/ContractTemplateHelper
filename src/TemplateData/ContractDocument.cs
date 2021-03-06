//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemplateData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContractDocument
    {
        public int ContractDocumentId { get; set; }
        public string DescriptiveName { get; set; }
        public int ContractDocTypeId { get; set; }
        public Nullable<int> OfferSheetId { get; set; }
        public Nullable<int> ContractId { get; set; }
        public bool IsActive { get; set; }
        public byte[] Document { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool CreateUserId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUserId { get; set; }
        public string ContentType { get; set; }
        public Nullable<bool> IsDigitallySigned { get; set; }
        public Nullable<int> SignaturePage { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual ContractDocumentType ContractDocumentType { get; set; }
        public virtual OfferSheet OfferSheet { get; set; }
    }
}
