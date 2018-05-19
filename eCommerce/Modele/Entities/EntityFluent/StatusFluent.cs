using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.EntityFluent
{
    class StatusFluent : EntityTypeConfiguration<Status>
    {
        public StatusFluent()
        {
            ToTable("APP_STATUT");
            HasKey(st => st.StatusId);

            Property(st => st.StatusId).HasColumnName("STA_ID").IsRequired();
            Property(st => st.StatusLabel).HasColumnName("STA_LIBELLE").IsRequired().HasMaxLength(50);
        }
    }
}
