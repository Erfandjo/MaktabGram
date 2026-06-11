using MaktabGram.Domain.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence.Configure
{
    public class UserBlockConfig : IEntityTypeConfiguration<UserBlock>
    {
        public void Configure(EntityTypeBuilder<UserBlock> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => new { x.BlockedUserId, x.BlockerUserId }).IsUnique();
        }
    }
}
