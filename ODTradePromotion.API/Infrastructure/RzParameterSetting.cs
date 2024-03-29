﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class RzParameterSetting
    {
        public Guid Id { get; set; }
        public string ParameterSettingCode { get; set; }
        public string LocationCode { get; set; }
        public string Description { get; set; }
        public string RouteZoneType { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ValidUntil { get; set; }
        public bool IsSpecific { get; set; }
        public string ReportDocumentNumber { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string ApplyTo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
