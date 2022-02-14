using SeleniumDocker;

namespace SeleniumGridDocker
{
    public static class GlobalRunSettings
    {
        public static BrowserType BrowserName { get; set; }
        public static bool IsRemoteRun { get; set; }
        public static string RemoteDriverUrl { get; set; }
        public static string StartUrl { get; set; }
        public static int TimeoutSeconds { get; set; }
    }
}
