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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.UserName).IsUnique();


            builder.HasIndex(x => x.PhoneNumber).IsUnique();

            builder.Property(x => x.UserName)
                .IsRequired();

            builder.Property(x => x.PhoneNumber)
               .IsRequired();

            builder.Property(x => x.PasswordHash)
               .IsRequired();
        }
    }
}
