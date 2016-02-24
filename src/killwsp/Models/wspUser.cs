namespace killwsp.Models
{
    using System;

    public class wspUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string PrimaryPhone { get; set; }
        public string CompanyName { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
