using Domain.Models;
using Domain.UseCases;

namespace Application.Services
{
    public interface IPostService
    {
        public Post[] GetAllPosts();

        public Post[] GetAllByAccountId(Guid id);

        public Guid Create(CreatePostDto createPostDto);

        public Post Update(Guid id, UpdatePostDto updatePostDto);

        public bool Delete(Guid id);
    }
}
