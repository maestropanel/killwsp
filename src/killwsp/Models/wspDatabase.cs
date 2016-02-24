namespace killwsp.Models
{
    public class wspDatabase
    {
        public string DomainName { get; set; }
        public string Name { get; set; }
        public int Quota { get; set; }
        public string DatabaseType { get; set; }

        public wspDatabseUser[] Users { get; set; }
    }


    public class wspDatabseUser
    {
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
