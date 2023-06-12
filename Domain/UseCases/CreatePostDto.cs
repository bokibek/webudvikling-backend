namespace Domain.UseCases
{
    public class CreatePostDto
    {
        public Guid? ParentPostId { get; set; }

        public string Content { get; set; } = null!;

        public Guid AuthorId { get; set; }
    }
}
