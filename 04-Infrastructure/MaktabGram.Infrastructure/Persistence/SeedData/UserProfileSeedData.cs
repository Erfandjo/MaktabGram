using MaktabGram.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGram.Infrastructure.Persistence.SeedData
{
    public static class UserProfileSeedData
    {
        public static IEnumerable<UserProfile> Data => new List<UserProfile>
    {
        new()
        {
            Id = SeedIds.Profile1Id,
            UserId = SeedIds.User1Id,
            DisplayName = "Erfan Joharzadeh",
            Bio = ".NET Developer"
        },
        new()
        {
            Id = SeedIds.Profile2Id,
            UserId = SeedIds.User2Id,
            DisplayName = "Ali Ahmadi",
            Bio = "Backend Developer"
        },
        new()
        {
            Id = SeedIds.Profile3Id,
            UserId = SeedIds.User3Id,
            DisplayName = "Sara Mohammadi",
            Bio = "UI Designer"
        },
        new()
        {
            Id = SeedIds.Profile4Id,
            UserId = SeedIds.User4Id,
            DisplayName = "Maryam Karimi",
            Bio = "Student"
        },
        new()
        {
            Id = SeedIds.Profile5Id,
            UserId = SeedIds.User5Id,
            DisplayName = "Reza Moradi",
            Bio = "Software Engineer"
        }
    };
    }
}
