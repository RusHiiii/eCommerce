using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.EntityFluent
{
    class LogProductFluent : EntityTypeConfiguration<LogProduct>
    {
        public LogProductFluent()
        {
            ToTable("APP_LOGPRODUIT");
            HasKey(log => log.LogId);

            Property(log=> log.LogId).HasColumnName("LOG_ID").IsRequired();
            Property(log => log.LogMessage).HasColumnName("LOG_MESSAGE").HasMaxLength(255);
            Property(log => log.LogDate).HasColumnName("LOG_DATE").IsRequired();

            HasRequired(log => log.LogProductEntity).WithMany().HasForeignKey(log => log.LogProductEntityId);
        }
    }
}
