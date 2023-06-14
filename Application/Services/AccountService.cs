using Application.ViewModels;
using Domain.Interfaces;
using Domain.Models;
using Domain.UseCases;

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        //IAccountRepository injekteret igennem en constructor
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
        }

        //Abstraction mellem AccountRepository og koden
        public AccountViewModel[] GetAllAccounts()
        {
            return _accountRepository.GetAllAccounts()
                .Select(account => AccountViewModel.From(account))
                .ToArray();
        }

        public Account GetAccountById(Guid id)
        {
            return _accountRepository.GetAllAccounts().First(x => x.Id == id);

        }

        public Guid Create(CreateAccountDto createAccount)
        {
            return _accountRepository.Create(createAccount);
        }

        public Account Update(Guid id, UpdateAccountDto updateAccount)
        {
            return _accountRepository.Update(id, updateAccount);
        }

        public bool Delete(Guid id)
        {
            return _accountRepository.Delete(id);
        }

    }
}
