﻿
using System.Data.Entity.ModelConfiguration;
using Jobney.Casm.Domain.Entities;

namespace Jobney.Casm.Data.EntityTypeConfigurations
{
    public class PilotEntityTypeConfiguration : EntityTypeConfiguration<Pilot>
    {
        public PilotEntityTypeConfiguration()
        {
            Property(x => x.Id)
                .IsRequired();

            Property(x => x.EmailAddress)
                .IsRequired();

            HasMany(m => m.Trips);
        }
    }
}
