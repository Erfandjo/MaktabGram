using MaktabGram.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence.SeedData
{
    public static class UserSeedData
    {
        public static IEnumerable<User> Data => new List<User>
    {
        new()
        {
            Id = SeedIds.User1Id,
            UserName = "erfan",
            PhoneNumber = "09111111111",
            PasswordHash = "Hash123",
            CreatedDate = new DateTime(2025,1,1)
        },
        new()
        {
            Id = SeedIds.User2Id,
            UserName = "ali",
            PhoneNumber = "09222222222",
            PasswordHash = "Hash123",
            CreatedDate = new DateTime(2025,1,1)
        },
        new()
        {
            Id = SeedIds.User3Id,
            UserName = "sara",
            PhoneNumber = "09333333333",
            PasswordHash = "Hash123",
            CreatedDate = new DateTime(2025,1,1)
        },
        new()
        {
            Id = SeedIds.User4Id,
            UserName = "maryam",
            PhoneNumber = "09444444444",
            PasswordHash = "Hash123",
            CreatedDate = new DateTime(2025,1,1)
        },
        new()
        {
            Id = SeedIds.User5Id,
            UserName = "reza",
            PhoneNumber = "09555555555",
            PasswordHash = "Hash123",
            CreatedDate = new DateTime(2025,1,1)
        }
    };
    }
}
