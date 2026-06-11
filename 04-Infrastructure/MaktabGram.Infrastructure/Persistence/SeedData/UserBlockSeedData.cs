using MaktabGram.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence.SeedData
{
    public static class UserBlockSeedData
    {
        public static IEnumerable<UserBlock> Data => new List<UserBlock>
    {
        new()
        {
            Id = SeedIds.Block1Id,
            BlockerUserId = SeedIds.User1Id,
            BlockedUserId = SeedIds.User5Id
        }
    };
    }

}
