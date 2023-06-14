using Domain.Models;
using Domain.Interfaces;
using Domain.UseCases;
using Data.Databases;

namespace Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        private static Post? FindPostById(Guid id)
        {
            return PostDatabase.Posts.Find(x => x.Id == id);
        }

        public Post[] GetAllPosts()
        {
            return PostDatabase.Posts.ToArray();
        }

        public Guid Create(CreatePostDto createPostDto)
        {
            var account = AccountDatabase.Accounts.Find(x => x.Id == createPostDto.AuthorId);
            
            if (account == null)
            {
                throw new Exception("Account does not exists");
            }

            var post = new Post
            {
                Id = Guid.NewGuid(),
                Content = createPostDto.Content,
                AuthorId = createPostDto.AuthorId,
                ParentPostId = createPostDto.ParentPostId,
            };

            PostDatabase.Posts.Add(post);
            return post.Id;
        }

        public Post Update(Guid id, UpdatePostDto updatePostDto)
        {
            var post = FindPostById(id);
            if (post == null)
            {
                throw new Exception("Post not found.");
            }

            post.Content = updatePostDto.Content;

            return post;
        }

        public bool Delete(Guid id)
        {
            var post = FindPostById(id);
            if (post == null)
            {
                throw new Exception("Post not found.");
            }

            return PostDatabase.Posts.Remove(post);
        }

    }
}
