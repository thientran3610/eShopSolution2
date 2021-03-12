using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyForAll { get; set; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public Status Status { set; get; }

        public string ProductIds { set; get; }
        public string ProductCategoryIds { set; get; }
    }
}
