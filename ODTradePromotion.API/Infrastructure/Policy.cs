﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class Policy
    {
        public Policy()
        {
            UserPolicies = new HashSet<UserPolicy>();
        }

        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<UserPolicy> UserPolicies { get; set; }
    }
}
