namespace killwsp.Models
{
    using System;

    public class wspDomain
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string PhysicalPath { get; set; }
        public bool isSubDomain { get; set; }
        public bool isAlias { get; set; }
        public bool isDomainPointer { get; set; }
        public string RedirectionURL { get; set; }
        public bool EnableDomainUser { get; set; }
        public string DomainUserPassword { get; set; }

        public wspDomainLimits Limits { get; set; }
    }

    public class wspDomainLimits
    {
        public int MaxDomain { get; set; }
        public int DiskSpace { get; set; }
        public int MaxMailBox { get; set; }
        public int MaxFtpUser { get; set; }
        public int MaxFtpTraffic { get; set; }
        public int MaxMailTraffic { get; set; }

        public int MaxMySqlDb { get; set; }
        public int MaxMySqlDbSpace { get; set; }
        public int MaxMySqlUser { get; set; }

        public int MaxMsSqlDb { get; set; }
        public int MaxMsSqlDbSpace { get; set; }
        public int MaxMsSqlDbUser { get; set; }

        public int MaxDomainAlias { get; set; }
        public int MaxSubDomain { get; set; }


        public int MaxWebTraffic { get; set; }
        public int TotalMailBoxQuota { get; set; }

        public DateTime Expiration { get; set; }
    }
}
