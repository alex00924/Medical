﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Models
{
    public class ProductModel
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_image { get; set; }
        public float product_price { get; set; }
        public string product_description { get; set; }
        public int product_category { get; set; }
    }
}
