﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ODTradePromotion.API.Infrastructure
{
    public partial class Localization
    {
        public int Id { get; set; }
        public string Resourceid { get; set; }
        public string Value { get; set; }
        public string Localeid { get; set; }
        public string Resourceset { get; set; }
        public string Type { get; set; }
        public byte[] Binfile { get; set; }
        public string Textfile { get; set; }
        public string Filename { get; set; }
        public string Comment { get; set; }
        public int Valuetype { get; set; }
        public DateTime Updated { get; set; }
    }
}
