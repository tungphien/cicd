﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class PrimarySicIncludeDetail
    {
        public Guid Id { get; set; }
        public Guid PrimarySicId { get; set; }
        public Guid HierarchyValueId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public int? DeleteFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ItemAttribute HierarchyValue { get; set; }
        public virtual PrimarySic PrimarySic { get; set; }
    }
}
