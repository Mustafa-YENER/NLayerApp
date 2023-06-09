﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entity;

namespace NLayer.Repostory.Seads
{
    
    internal class CategorySead : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category() { Id = 1, Name = "Kalemler" , CreatedDate = DateTime.Now },
                new Category() { Id = 2, Name = "Defterler", CreatedDate = DateTime.Now },
                new Category { Id = 3, Name = "Kitaplar", CreatedDate = DateTime.Now });
        }
    }
    
}
