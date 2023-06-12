namespace Domain.UseCases
{

    public class UpdateAccountDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;

        public int PostalCode { get; set; }

        public string City { get; set; } = null!;
    }
}
