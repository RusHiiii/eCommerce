using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.EntityFluent
{
    class OrderFluent : EntityTypeConfiguration<Order>
    {
        public OrderFluent()
        {
            ToTable("APP_COMMANDE");
            HasKey(o => o.OrderId);

            Property(o => o.OrderId).HasColumnName("CMD_ID").IsRequired();
            Property(o => o.OrderDate).HasColumnName("CMD_DATECOMMANDE").IsRequired();
            Property(o => o.OrderObservation).HasColumnName("CMD_OBSERVATION").IsRequired().HasMaxLength(250);
            Property(o => o.OrderStatusEntityId).HasColumnName("CMD_STATUTID").IsRequired();
            Property(o => o.OrderClientEntityId).HasColumnName("CMD_CLIENTID").IsRequired();

            HasRequired(o => o.OrderStatusEntity).WithMany().HasForeignKey(s => s.OrderStatusEntityId);
            HasRequired(o => o.OrderClientEntity).WithMany().HasForeignKey(c => c.OrderClientEntityId);
        }
    }
}
