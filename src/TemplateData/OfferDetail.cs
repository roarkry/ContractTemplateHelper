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
    
    public partial class OfferDetail
    {
        public OfferDetail()
        {
            this.OfferPricingResults = new HashSet<OfferPricingResult>();
        }
    
        public long OfferDetailId { get; set; }
        public int OfferId { get; set; }
        public int SiteServiceId { get; set; }
        public int UomId { get; set; }
        public decimal UsageAmount { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> ModifyUserId { get; set; }
    
        public virtual SiteService SiteService { get; set; }
        public virtual Offer Offer { get; set; }
        public virtual ICollection<OfferPricingResult> OfferPricingResults { get; set; }
        public virtual UnitOfMeasureType UnitOfMeasureType { get; set; }
    }
}
