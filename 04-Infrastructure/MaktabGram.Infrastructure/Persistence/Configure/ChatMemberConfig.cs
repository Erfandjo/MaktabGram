using MaktabGram.Domain.ChatMemmberEntities;
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
    public class ChatMemberConfig : IEntityTypeConfiguration<ChatMember>
    {
        public void Configure(EntityTypeBuilder<ChatMember> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasIndex(x => new { x.ChatId, x.UserId }).IsUnique();


            builder.HasOne(x => x.User)
                .WithMany(x => x.ChatMembers)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(x => x.Chat)
                .WithMany(x => x.ChatMembers)
                .HasForeignKey(x => x.ChatId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
