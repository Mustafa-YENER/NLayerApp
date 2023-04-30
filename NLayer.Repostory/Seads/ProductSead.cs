using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repostory.Seads
{   
    internal class ProductSead : IEntityTypeConfiguration<ProductSead>
    {
        public void Configure(EntityTypeBuilder<ProductSead> builder)
        {
            builder.HasData(
                new Product() { Id = 1, Name = "" },
                new Product() { Id = 2, Name = "Defter 1" },
                new Product { Id = 3, Name = "Kitaplar" });
        }
    }
}
