﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class AuditLog
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Fields { get; set; }
        public string FeatureCode { get; set; }
        public string ObjectFullName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
