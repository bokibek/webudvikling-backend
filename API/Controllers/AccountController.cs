using Application.Services;
using Application.ViewModels;
using Domain.Models;
using Domain.UseCases;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IPostService _postService;

        public AccountsController(IAccountService accountService, IPostService postService)
        {
            this._accountService = accountService;
            this._postService = postService;

        }

        [HttpGet]
        public AccountViewModel[] GetAllAccounts()
        {
            return this._accountService.GetAllAccounts();
        }

        [HttpGet("{id:guid}")]
        public Account GetAccountById(Guid id)
        {
            return this._accountService.GetAccountById(id);
        }

        [HttpGet("{id:guid}/posts")]
        public Post[] Get(Guid id)
        {
            return this._postService.GetAllByAccountId(id);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateAccountDto createAccountDto)
        {
            if (createAccountDto.Password.Contains(createAccountDto.Username))
            {
                ModelState.AddModelError("Password", "Password must not be equal to username.");
            }

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            return Ok(this._accountService.Create(createAccountDto));
        }

        [HttpPut("{id:guid}")]
        public Account Update(Guid id, [FromBody] UpdateAccountDto updateAccount)
        {
            return this._accountService.Update(id, updateAccount);
        }

        [HttpDelete("{id:guid}")]
        public bool Delete(Guid id)
        {
            return this._accountService.Delete(id);
        }
    }

}
