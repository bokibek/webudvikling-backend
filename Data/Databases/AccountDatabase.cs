using Domain.Models;

namespace Data.Databases
{
    internal static class AccountDatabase
    {
        public static List<Account> Accounts { get; set; } = new List<Account>()
        {
            new Account
            {
                Id = new Guid("b9ae56e7-1a96-46d5-96f9-88229d8cfad1"),
                FirstName = "Bojanovic",
                LastName = "Bekic",
                Address = "Nørrebrox",
                Username = "bokibek",
                Email = "bojan_bek@hotmail.com",
            },

            new Account
            {
                Id = new Guid("b9ae56e7-1a96-46d5-96f9-88229d8cfad2"),
                FirstName = "Mads",
                LastName = "",
                Address = "Folketinget",
                Username = "madsfolke",
                Email = "madsmads@gmail.com",
            },

            new Account
            {
                Id = new Guid("b9ae56e7-1a96-46d5-96f9-88229d8cfad3"),
                FirstName = "Anita",
                LastName = "",
                Address = "Folketinget",
                Username = "anitafolke",
                Email = "anitaanita@gmail.com",
            }
        };


    }
}
