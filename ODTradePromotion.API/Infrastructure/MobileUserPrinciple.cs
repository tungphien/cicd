﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class MobileUserPrinciple
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? PrincipleId { get; set; }
        public string Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
