using Domain.Models;

namespace Application.ViewModels
{
    public class AccountViewModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public static AccountViewModel From(Account account)
        {
            return new AccountViewModel
            {
                Id = account.Id,
                Username = account.Username,
                FullName = $"{account.FirstName} {account.LastName}",
                Email = account.Email,
            };
        }
    }
}
