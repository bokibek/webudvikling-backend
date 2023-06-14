using Data.Databases;
using Domain.Interfaces;
using Domain.Models;
using Domain.UseCases;
using System.Data;

namespace Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private Account? FindAccountById(Guid id)
        {
            return AccountDatabase.Accounts.Find(x => x.Id == id);
        }

        public Account[] GetAllAccounts()
        {

            return AccountDatabase.Accounts.ToArray();
        }

        public Guid Create(CreateAccountDto createAccountDto)
        {
            var account = new Account
            {
                Id = Guid.NewGuid(),
                Username = createAccountDto.Username,
                Email = createAccountDto.Email,
                Password = createAccountDto.Password
            };

            AccountDatabase.Accounts.Add(account);

            return account.Id;
        }

        public Account Update(Guid id, UpdateAccountDto updateAccountDto)
        {
            var account = FindAccountById(id);
            if (account == null)
            {
                throw new Exception("Account does not exist.");
            }

            account.FirstName = updateAccountDto.FirstName;
            account.LastName = updateAccountDto.LastName;
            account.Email = updateAccountDto.Email;
            account.Address = updateAccountDto.Address;  
            account.PostalCode = updateAccountDto.PostalCode;
            account.City = updateAccountDto.City;

            if (updateAccountDto.PostalCode >= 1000 && updateAccountDto.PostalCode <= 9990)
            {
                account.PostalCode = updateAccountDto.PostalCode;
            }
            else
            {
                throw new Exception("Postal code must be a four-digit number.");
            }

            return account;
        }

        public bool Delete(Guid id)
        {
            var account = FindAccountById(id);
            if (account == null)
            {
                throw new Exception("Account does not exist.");
            }

            return AccountDatabase.Accounts.Remove(account);
        }
    }
}
