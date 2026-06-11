using MaktabGram.Domain.Common.Enum;
using MaktabGram.Domain.MessageEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence.SeedData
{
    public static class MessageSeedData
    {
        public static IEnumerable<Message> Data => new List<Message>
    {
        new()
        {
            Id = SeedIds.Message1Id,
            ChatId = SeedIds.PrivateChatId,
            SenderId = SeedIds.User1Id,
            Text = "سلام علی",
            StatusMessage = StatusMessageEnum.Sent
        },
        new()
        {
            Id = SeedIds.Message2Id,
            ChatId = SeedIds.PrivateChatId,
            SenderId = SeedIds.User2Id,
            Text = "سلام عرفان",
            StatusMessage = StatusMessageEnum.Sent,
            IsReply = true,
            ReplyToMessageId = SeedIds.Message1Id
        },
        new()
        {
            Id = SeedIds.Message3Id,
            ChatId = SeedIds.GroupChatId,
            SenderId = SeedIds.User3Id,
            Text = "سلام به همه",
            StatusMessage = StatusMessageEnum.Sent
        },
        new()
        {
            Id = SeedIds.Message4Id,
            ChatId = SeedIds.GroupChatId,
            SenderId = SeedIds.User1Id,
            Text = "پیام فوروارد شده",
            StatusMessage = StatusMessageEnum.Sent,
            IsForward = true,
            ForwardFromMessageId = SeedIds.Message3Id,
            ForwardNumber = 1
        }
    };
    }
}
