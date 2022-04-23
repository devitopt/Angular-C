using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class Tenant
    {
        public Tenant()
        {
            AdditionalOrderInformations = new HashSet<AdditionalOrderInformation>();
        }

        public int TenantId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<AdditionalOrderInformation> AdditionalOrderInformations { get; set; }
    }
}
