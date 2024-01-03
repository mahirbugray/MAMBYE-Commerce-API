﻿using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ThumbnailImage { get; set; }
        public string ContentImage { get; set; }
        public string ContentImage2 { get; set; }
        public string ContentImage3 { get; set; }
        public string ContentImage4 { get; set; }
        public int Point { get; set; }
		public int CategoryId { get; set; }
		public CategoryDto? Category { get; set; }
        public List<CommandDto>? Commands { get; set; }
        public List<ProductFeatureDto>? ProductFeatures { get; set; }
	}
}
