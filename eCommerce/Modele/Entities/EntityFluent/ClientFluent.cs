using Modele.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Entities.EntityFluent
{
    public class ClientFluent : EntityTypeConfiguration<Client>
    {
        public ClientFluent()
        {
            ToTable("APP_CLIENT");
            HasKey(c => c.ClientId);

            Property(c => c.ClientId).HasColumnName("CLI_ID").IsRequired();
            Property(c => c.ClientActive).HasColumnName("CLI_ACTIF").IsRequired();
            Property(c => c.ClientLastname).HasColumnName("CLI_NOM").IsRequired().HasMaxLength(50);
            Property(c => c.ClientName).HasColumnName("CLI_PRENOM").IsRequired().HasMaxLength(50);
        }
    }
}
