using Domain.Models;
using Domain.Interfaces;
using Domain.UseCases;

namespace Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            this._postRepository = postRepository;
        }

        public Post[] GetAllPosts()
        {
            return _postRepository.GetAllPosts();
        }

        public Post[] GetAllByAccountId(Guid id)
        {
            return _postRepository
                .GetAllPosts()
                .Where(x => x.AuthorId == id)
                .ToArray();
        }

        public Guid Create(CreatePostDto createPostDto)
        {
            return _postRepository.Create(createPostDto);
        }

        public Post Update(Guid id, UpdatePostDto updatePostDto)
        {
            return _postRepository.Update(id, updatePostDto);
        }

        public bool Delete(Guid id)
        {
            return _postRepository.Delete(id);
        }

    }
}
