namespace killwsp.Models
{
    public class wspInfo
    {
        public const string WEBSITEPANEL_WEBSITE_NAME = "WebsitePanel Enterprise Server";

        public string ConnectionString { get; set; }
        public string PhysicalPath { get; set; }
        public string Version { get; set; }
        public bool isInstalled { get; set; }
        public bool isUP { get; set; }
    }
}
