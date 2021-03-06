﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andoromeda.Kyubey.Models
{
    public class Bancor
    {
        [Key]
        [MaxLength(16)]
        [ForeignKey("Token")]
        public string Id { get; set; }

        public virtual Token Token { get; set; }

        public Status Status { get; set; }

        public long Transactions { get; set; }

        public double BuyPrice { get; set; }

        public double SellPrice { get; set; }

        public double Change { get; set; }

        public string TradeJavascript { get; set; }

        [MaxLength(32)]
        public string Table { get; set; }

        [MaxLength(32)]
        public string Scope { get; set; }

        public string CurrentBuyPriceJavascript { get; set; }

        public string CurrentSellPriceJavascript { get; set; }
    }
}
