using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.EntityFluent
{
    class ProductsFluent : EntityTypeConfiguration<Products>
    {
        public ProductsFluent()
        {
            ToTable("APP_PRODUIT");
            HasKey(pr => pr.ProductId);

            Property(pr => pr.ProductId).HasColumnName("PRD_ID").IsRequired();
            Property(pr => pr.ProductCode).HasColumnName("PRD_CODE").HasMaxLength(255);
            Property(pr => pr.ProductLabel).HasColumnName("PRD_LIBELLE").IsRequired();
            Property(pr => pr.ProductDescription).HasColumnName("PRD_DESCRIPTION");
            Property(pr => pr.ProductActive).HasColumnName("PRD_ACTIF");
            Property(pr => pr.ProductStock).HasColumnName("PRD_STOCK");
            Property(pr => pr.ProductPrice).HasColumnName("PRD_PRIX");
            Property(pr => pr.ProductStockBuffer).HasColumnName("PRD_STOCK_BUFFER");

            HasRequired(pr => pr.ProductCategory).WithMany().HasForeignKey(pr => pr.ProductCategoryId);
        }
    }
}

