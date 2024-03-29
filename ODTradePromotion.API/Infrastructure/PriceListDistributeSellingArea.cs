﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class PriceListDistributeSellingArea
    {
        public Guid Id { get; set; }
        public string SellingAreaCode { get; set; }
        public string SellingAreaDescription { get; set; }
        public bool IsDeleted { get; set; }
        public Guid PriceListId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual PriceList PriceList { get; set; }
    }
}
