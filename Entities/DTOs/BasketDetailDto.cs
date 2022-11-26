﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BasketDetailDto : IDtos
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string UserFullName { get; set; }
        public decimal Price { get; set; }
        public List<string> Images { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}