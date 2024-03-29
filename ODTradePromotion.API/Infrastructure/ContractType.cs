﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class ContractType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime EffectDate { get; set; }
        public DateTime? UntilDate { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
