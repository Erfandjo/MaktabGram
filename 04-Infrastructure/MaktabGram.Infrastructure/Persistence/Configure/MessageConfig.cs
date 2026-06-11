using MaktabGram.Domain.MessageEntities;
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
    public class MessageConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Text)
                .HasMaxLength(2000);

            builder.HasOne(x => x.Chat)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.ChatId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(x => x.Sender)
                    .WithMany(x => x.SentMessages)
                    .HasForeignKey(x => x.SenderId)
                    .OnDelete(DeleteBehavior.Restrict);
            


            builder.HasOne(x => x.ReplyToMessage)
                   .WithMany()
                   .HasForeignKey(x => x.ReplyToMessageId)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(x => x.ForwardFromMessage)
                .WithMany()
                .HasForeignKey(x => x.ForwardFromMessageId)
                .OnDelete(DeleteBehavior.Restrict);




        }
    }
}
