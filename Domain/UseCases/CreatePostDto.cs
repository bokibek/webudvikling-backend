using System.ComponentModel.DataAnnotations;

namespace Domain.UseCases
{
    public class CreatePostDto
    {
        public Guid? ParentPostId { get; set; }

        [Required(ErrorMessage = "Please publish something!")]
        public string Content { get; set; } = null!;

        public Guid AuthorId { get; set; }
    }
}
