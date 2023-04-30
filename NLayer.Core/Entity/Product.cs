using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entity
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock{ get; set; }
        public ProductFeature ProductFeature { get; set; }
        public ProductFeature Category { get; set; }

    }
}
