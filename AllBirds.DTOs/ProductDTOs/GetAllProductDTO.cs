﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBirds.DTOs.ProductDTOs
{
    public class GetAllProductDTO
    {
        public int Id { get; set; }
        public string? MainImagePath { get; set; }
        public string? MainColorCode { get; set; }
        public string? ProductNo { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public bool FreeShipping { get; set; }
        public bool IsDeleted { get; set; }
    }
}
