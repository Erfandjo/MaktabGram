using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence.SeedData
{
    public static class SeedIds
    {
        // Users
        public static readonly Guid User1Id = Guid.Parse("11111111-1111-1111-1111-111111111111");
        public static readonly Guid User2Id = Guid.Parse("22222222-2222-2222-2222-222222222222");
        public static readonly Guid User3Id = Guid.Parse("33333333-3333-3333-3333-333333333333");
        public static readonly Guid User4Id = Guid.Parse("44444444-4444-4444-4444-444444444444");
        public static readonly Guid User5Id = Guid.Parse("55555555-5555-5555-5555-555555555555");

        // Profiles
        public static readonly Guid Profile1Id = Guid.Parse("aaaaaaaa-1111-1111-1111-111111111111");
        public static readonly Guid Profile2Id = Guid.Parse("aaaaaaaa-2222-2222-2222-222222222222");
        public static readonly Guid Profile3Id = Guid.Parse("aaaaaaaa-3333-3333-3333-333333333333");
        public static readonly Guid Profile4Id = Guid.Parse("aaaaaaaa-4444-4444-4444-444444444444");
        public static readonly Guid Profile5Id = Guid.Parse("aaaaaaaa-5555-5555-5555-555555555555");

        // Chats
        public static readonly Guid PrivateChatId = Guid.Parse("66666666-6666-6666-6666-666666666666");
        public static readonly Guid GroupChatId = Guid.Parse("77777777-7777-7777-7777-777777777777");
        public static readonly Guid ChannelId = Guid.Parse("88888888-8888-8888-8888-888888888888");

        // Messages
        public static readonly Guid Message1Id = Guid.Parse("99999999-1111-1111-1111-111111111111");
        public static readonly Guid Message2Id = Guid.Parse("99999999-2222-2222-2222-222222222222");
        public static readonly Guid Message3Id = Guid.Parse("99999999-3333-3333-3333-333333333333");
        public static readonly Guid Message4Id = Guid.Parse("99999999-4444-4444-4444-444444444444");

        // UserBlocks
        public static readonly Guid Block1Id = Guid.Parse("bbbbbbbb-1111-1111-1111-111111111111");
    }
}
