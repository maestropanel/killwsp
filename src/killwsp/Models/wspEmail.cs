namespace killwsp.Models
{
    public class wspEmail
    {
        public int ItemID { get; set; }
        public int UserID { get; set; }
        public string DomainName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isForwarding { get; set; }
        public string ForwardEmail { get; set; }
        public int Quota { get; set; }
        public int Status { get; set; }
    }
}
