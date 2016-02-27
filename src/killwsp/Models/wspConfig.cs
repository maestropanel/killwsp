namespace killwsp.Models
{
    public class wspConfig
    {
        public const string WEBSITEPANEL_WEBSITE_NAME = "WebsitePanel Enterprise Server";
        public const string WEBSITEPANEL_BASE_FILE = "WebsitePanel.EnterpriseServer.Base.dll";

        public string ConnectionString { get; set; }
        public string PhysicalPath { get; set; }
        public string Version { get; set; }

        public bool isInstalled { get; set; }
        public bool isUP { get; set; }

        public int DomainCount { get; set; }
        public int EmailCount { get; set; }
        public int ResellerCount { get; set; }
        public int SubDomainCount { get; set; }
        public int AliasCount { get; set; }
        public int WebDiskSpace { get; set; }
        public int EmailDiskSpace { get; set; }
        public int MsSQLDiskSpace { get; set; }
        public int MySQLDiskSpace { get; set; }
        public int SubDomainDiskSpace { get; set; }
    }
}
