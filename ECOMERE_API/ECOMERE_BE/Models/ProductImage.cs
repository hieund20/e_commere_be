﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ECOMERE_BE.Models
{
    public partial class ProductImage
    {
        public string Id { get; set; }
        public string Path { get; set; }
        public string ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}