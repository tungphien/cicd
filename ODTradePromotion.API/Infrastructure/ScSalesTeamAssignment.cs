﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class ScSalesTeamAssignment
    {
        public Guid Id { get; set; }
        public string Channel { get; set; }
        public bool IsSalesForce { get; set; }
        public string SostructureCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string SellingCategoryCode { get; set; }
        public string EmployeeCode { get; set; }
        public bool IsBase { get; set; }
        public bool? IsSicbase { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? UntilDate { get; set; }
        public bool IsDeleted { get; set; }
        public string MappingNode { get; set; }
    }
}
