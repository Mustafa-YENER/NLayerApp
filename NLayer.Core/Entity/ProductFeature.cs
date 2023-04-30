﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entity
{
    public class ProductFeature : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Color { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
    }
}
