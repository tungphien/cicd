﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class DsaGeographicalMapping
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Dsacode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string ValueMasterCode { get; set; }
        public Guid ValueId { get; set; }
        public Guid ParentId { get; set; }
        public string GeographicalMaster { get; set; }
        public string Description { get; set; }
        public string ValueCode { get; set; }
        public string ValueMasterDescription { get; set; }
    }
}
