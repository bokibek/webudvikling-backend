using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Domain.UseCases;
using Application.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            this._postService = postService;
        }

        [HttpGet]
        public Post[] GetAllPosts()
        {
            return this._postService.GetAllPosts();
        }

        [HttpPost]
        public Guid Create([FromBody] CreatePostDto createPost)
        {
            return this._postService.Create(createPost);
        }

        [HttpPut("{id:guid}")]
        public Post Create(Guid id, [FromBody] UpdatePostDto updatePost)
        {
            return this._postService.Update(id, updatePost);
        }

        [HttpDelete("{id:guid}")]
        public bool Delete(Guid id)
        {
            return this._postService.Delete(id);
        }
    }
}
