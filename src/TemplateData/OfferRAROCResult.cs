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
    
    public partial class OfferRAROCResult
    {
        public int RAROCResultId { get; set; }
        public int OfferId { get; set; }
        public decimal ApprovalRequired { get; set; }
        public decimal Approved { get; set; }
        public decimal StretchGoal { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Offer Offer { get; set; }
    }
}
