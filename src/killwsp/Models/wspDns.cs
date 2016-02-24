namespace killwsp.Models
{

    public class wspDns
    {
        public string SerialNumber { get; set; }
        public string PrimaryServer { get; set; }
        public string ResponsiblePerson { get; set; }
        public int RefreshInterval { get; set; }
        public int RetryInterval { get; set; }
        public int ExpiresAfter { get; set; }
        public int MinimumTTL { get; set; }

        public wspDnsRecord[] Records { get; set; }
    }

    public class wspDnsRecord
    {
        public string Name { get; set; }
        public string RecordType { get; set; }
        public string Data { get; set; }
    }

}
