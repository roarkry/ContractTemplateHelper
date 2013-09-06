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
    
    public partial class OfferPricingSubmission
    {
        public OfferPricingSubmission()
        {
            this.Contracts = new HashSet<Contract>();
            this.OfferPricingResults = new HashSet<OfferPricingResult>();
            this.OfferSheetPricings = new HashSet<OfferSheetPricing>();
        }
    
        public long OfferPricingSubmissionId { get; set; }
        public int OfferId { get; set; }
        public System.DateTime SubmitDateStamp { get; set; }
        public decimal Price { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUserId { get; set; }
    
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<OfferPricingResult> OfferPricingResults { get; set; }
        public virtual ICollection<OfferSheetPricing> OfferSheetPricings { get; set; }
    }
}