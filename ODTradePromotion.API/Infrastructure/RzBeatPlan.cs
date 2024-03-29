﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class RzBeatPlan
    {
        public Guid Id { get; set; }
        public string BeatPlanCode { get; set; }
        public string RouteZoneCode { get; set; }
        public string BeatPlanType { get; set; }
        public string Description { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string Status { get; set; }
        public string BypassStatus { get; set; }
        public string LegalDocumentNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string ValidStatus { get; set; }
    }
}
