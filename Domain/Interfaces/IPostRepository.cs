using Domain.Models;
using Domain.UseCases;

namespace Domain.Interfaces
{
    public interface IPostRepository
    {
        public Post[] GetAllPosts();

        public Post Update(Guid id, UpdatePostDto updatePostDto);

        public Guid Create(CreatePostDto createPostDto);

        public bool Delete(Guid id);
    }
}
