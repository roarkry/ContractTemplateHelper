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
    
    public partial class LoadFactorType
    {
        public LoadFactorType()
        {
            this.SiteServices = new HashSet<SiteService>();
        }
    
        public int LoadFactorId { get; set; }
        public string LoadFactorName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<SiteService> SiteServices { get; set; }
    }
}
