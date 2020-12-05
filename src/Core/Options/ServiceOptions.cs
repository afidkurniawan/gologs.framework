// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace GoLogs.Framework.Core.Options
{
    public class ServiceOptions
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public int? Port { get; set; }
        public string VirtualHost { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UseSsl { get; set; }
        public string SslThumbprint { get; set; }
    }
}
