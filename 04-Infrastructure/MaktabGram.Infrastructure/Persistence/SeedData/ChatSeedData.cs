using MaktabGram.Domain.ChatEntities;
using MaktabGram.Domain.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence.SeedData
{
    public static class ChatSeedData
    {
        public static IEnumerable<Chat> Data => new List<Chat>
    {
        new()
        {
            Id = SeedIds.PrivateChatId,
            Type = ChatTypeEnum.Private,
            CreatedByUserId = SeedIds.User1Id
        },
        new()
        {
            Id = SeedIds.GroupChatId,
            Title = "Maktab Group",
            Type = ChatTypeEnum.Group,
            CreatedByUserId = SeedIds.User1Id
        },
        new()
        {
            Id = SeedIds.ChannelId,
            Title = "Maktab News",
            Type = ChatTypeEnum.Channel,
            CreatedByUserId = SeedIds.User2Id
        }
    };
    }
}
