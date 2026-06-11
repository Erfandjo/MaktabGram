using MaktabGram.Domain.ChatEntities;
using MaktabGram.Domain.ChatMemmberEntities;
using MaktabGram.Domain.MessageEntities;
using MaktabGram.Domain.UserEntities;
using MaktabGram.Infrastructure.Persistence.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence
{
    public class MaktabGramContext : DbContext
    {
        #region DbSets

        public DbSet<User> Users { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<UserBlock> UserBlocks { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<ChatMember> ChatMembers { get; set; }

        public DbSet<Message> Messages { get; set; }

        #endregion

        public MaktabGramContext(DbContextOptions<MaktabGramContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MaktabGramContext).Assembly);

            modelBuilder.Entity<User>().HasData(UserSeedData.Data);
            modelBuilder.Entity<UserProfile>().HasData(UserProfileSeedData.Data);
            modelBuilder.Entity<Chat>().HasData(ChatSeedData.Data);
            modelBuilder.Entity<ChatMember>().HasData(ChatMemberSeedData.Data);
            modelBuilder.Entity<Message>().HasData(MessageSeedData.Data);
            modelBuilder.Entity<UserBlock>().HasData(UserBlockSeedData.Data);

        }
    }
}
