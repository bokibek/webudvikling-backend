namespace Domain.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Content { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public Guid? ParentPostId { get; set; }

        public Guid AuthorId { get; set; }
    }
}
