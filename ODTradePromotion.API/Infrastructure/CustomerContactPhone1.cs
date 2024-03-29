﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class CustomerContactPhone1
    {
        public Guid Id { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public Guid CustomerContactId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual CustomerContact1 CustomerContact { get; set; }
    }
}
