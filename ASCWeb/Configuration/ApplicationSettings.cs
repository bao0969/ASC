namespace ASCWeb.Configuration
{
    public class ApplicationSettings
    {
        public string ApplicationTitle { get; set; } = string.Empty;
        public string Roles { get; set; } = string.Empty;
        public string AdminEmail { get; internal set; } = string.Empty;
        public string AdminName { get; internal set; } = string.Empty;
        public string AdminPassword { get; internal set; } = string.Empty;
        public string EngineerEmail { get; internal set; } = string.Empty;
        public string EngineerName { get; internal set; } = string.Empty;
        public string EngineerPassword { get; internal set; } = string.Empty;
    }
}
