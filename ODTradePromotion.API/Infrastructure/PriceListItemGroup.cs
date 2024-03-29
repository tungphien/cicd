﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class PriceListItemGroup
    {
        public Guid Id { get; set; }
        public string ItemGroupCode { get; set; }
        public string Description { get; set; }
        public string UoM { get; set; }
        public decimal FreightCost { get; set; }
        public decimal DeductedValue { get; set; }
        public bool IsDeleted { get; set; }
        public Guid PriceListId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual PriceList PriceList { get; set; }
    }
}
