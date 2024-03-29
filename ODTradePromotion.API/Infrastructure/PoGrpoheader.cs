﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class PoGrpoheader
    {
        public Guid Id { get; set; }
        public string Grponumber { get; set; }
        public DateTime Grpodate { get; set; }
        public string Type { get; set; }
        public string PurchaseOrderConfirmNumber { get; set; }
        public string PrincipalWareHouseCode { get; set; }
        public string PrincipalRefNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorShiptoCode { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
