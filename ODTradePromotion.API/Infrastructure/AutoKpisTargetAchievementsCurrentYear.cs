﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class AutoKpisTargetAchievementsCurrentYear
    {
        public Guid Id { get; set; }
        public string AutoKpisTargetCode { get; set; }
        public string BusinessModel { get; set; }
        public decimal? NumberofOutlet { get; set; }
        public decimal? Vpo { get; set; }
        public decimal? Pc { get; set; }
        public decimal? Aso { get; set; }
        public decimal? Lppc { get; set; }
        public decimal? Lppcvalue { get; set; }
        public decimal? DropSize { get; set; }
        public string Source { get; set; }
        public string TerritoryStructureCode { get; set; }
        public string TerritoryValueBySource { get; set; }
        public int Year { get; set; }
        public string BusinessModelDescription { get; set; }
    }
}
