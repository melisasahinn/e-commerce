﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDtos
    {
        public int Id { get; set; }
        public long BrandId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public List<ProductImage> Image { get; set; }
        public List<string> Images { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public int DiscountRate { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}
