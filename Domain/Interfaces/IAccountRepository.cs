using Domain.UseCases;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IAccountRepository
    {
        public Account[] GetAllAccounts();

        public Guid Create(CreateAccountDto createAccountDto);

        public Account Update(Guid id, UpdateAccountDto updateAccountDto);

        public bool Delete(Guid id);
    }
}
