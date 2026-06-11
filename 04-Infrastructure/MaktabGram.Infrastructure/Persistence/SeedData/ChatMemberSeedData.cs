using MaktabGram.Domain.ChatMemmberEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence.SeedData
{
    public static class ChatMemberSeedData
    {
        public static IEnumerable<ChatMember> Data => new List<ChatMember>
    {
        new()
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000001"),
            ChatId = SeedIds.PrivateChatId,
            UserId = SeedIds.User1Id
        },
        new()
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000002"),
            ChatId = SeedIds.PrivateChatId,
            UserId = SeedIds.User2Id
        },

        new()
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000003"),
            ChatId = SeedIds.GroupChatId,
            UserId = SeedIds.User1Id,
            IsAdmin = true
        },
        new()
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000004"),
            ChatId = SeedIds.GroupChatId,
            UserId = SeedIds.User2Id
        },
        new()
        {
            Id = Guid.Parse("10000000-0000-0000-0000-000000000005"),
            ChatId = SeedIds.GroupChatId,
            UserId = SeedIds.User3Id
        }
    };
    }
}
