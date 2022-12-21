using BigOn.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOn.Domain.Models.DataContexts.Configurations
{
    public class BigOnRoleClaimEntityTypeConfiguration : IEntityTypeConfiguration<BigOnRoleClaim>
    {
        public void Configure(EntityTypeBuilder<BigOnRoleClaim> builder)
        {
            builder.ToTable("RoleClaims", "Membership");
        }
    }
}
