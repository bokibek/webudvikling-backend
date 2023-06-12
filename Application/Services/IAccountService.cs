using Application.ViewModels;
using Domain.Models;
using Domain.UseCases;

namespace Application.Services
{
    public interface IAccountService
    {
        public AccountViewModel[] GetAllAccounts();

        public Account GetAccountById(Guid id);

        public Guid Create(CreateAccountDto createAccount);

        public Account Update(Guid id, UpdateAccountDto updateAccount);

        public bool Delete(Guid id);
    }
}
