using System;
using Modele.Entities.Entity;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.EntityFluent
{
    
    class CategoryFluent : EntityTypeConfiguration<Category>
    {
        public CategoryFluent()
        {
            ToTable("APP_CATEGORIE");
            HasKey(cat => cat.CategoryId);

            Property(cat => cat.CategoryId).HasColumnName("CAT_ID").IsRequired();
            Property(cat => cat.CategoryLabel).HasColumnName("CAT_LIBELLE").HasMaxLength(255);
            Property(cat => cat.CategoryActive).HasColumnName("CAT_ACTIF");
        }
    }
}
