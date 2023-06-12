using Domain.Models;

namespace Data.Databases
{
    internal static class PostDatabase
    {
        public static List<Post> Posts { get; set; } = new List<Post>()
        {
            new Post
            {
                Id = new Guid("5a3cae27-a030-49d2-b45e-b23bd1e88cc0"),
                Content = "Dette er et opslag",
                CreatedAt = DateTime.Now,
                AccountId = new Guid("b9ae56e7-1a96-46d5-96f9-88229d8cfad5")
            },

            new Post
            {
                Id = new Guid("5a3cae27-a030-49d2-b45e-b23bd1e88cc1"),
                Content = "Endnu et opslag!!!",
                CreatedAt = DateTime.Now,
                AccountId = new Guid("b9ae56e7-1a96-46d5-96f9-88229d8cfad5")
            }
        };
    }
}
