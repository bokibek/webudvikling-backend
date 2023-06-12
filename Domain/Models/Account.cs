namespace Domain.Models
{
    public class Account
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }  

        public string? LastName { get; set;}

        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;   
        
        public string Password { get; set; } = null!;

        public string? Address { get; set; }

        public int? PostalCode { get; set; }

        public string? City { get; set; }

    }
}
