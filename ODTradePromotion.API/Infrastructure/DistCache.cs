﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class DistCache
    {
        public string Id { get; set; }
        public byte[] Value { get; set; }
        public DateTime? ExpiresAtTime { get; set; }
        public double? SlidingExpirationInSeconds { get; set; }
        public DateTime? AbsoluteExpiration { get; set; }
    }
}
