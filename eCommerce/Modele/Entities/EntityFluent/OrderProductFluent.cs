using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.EntityFluent
{
    class OrderProductFluent : EntityTypeConfiguration<OrderProduct>
    {
        public OrderProductFluent()
        {
            ToTable("APP_COMMANDEPRODUIT");
            HasKey(cp => new { cp.OrderProductOrderEntityId, cp.OrderProductProductsEntityId });

            Property(cp => cp.OrderProductOrderEntityId).HasColumnName("CPD_COMMANDEID").IsRequired();
            Property(cp => cp.OrderProductProductsEntityId).HasColumnName("CPD_PRODUITID").IsRequired();
            Property(cp => cp.OrderProductQuantity).HasColumnName("CPD_QUANTITE").IsRequired();

            HasRequired(cp => cp.OrderProductOrderEntity).WithMany().HasForeignKey(o => o.OrderProductOrderEntityId);
            HasRequired(cp => cp.OrderProductProductsEntity).WithMany().HasForeignKey(o => o.OrderProductProductsEntityId);
        }
    }
}
