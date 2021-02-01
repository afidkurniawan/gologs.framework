// -------------------------------------------------------------
// Copyright Go-Logs. All rights reserved.
// Proprietary and confidential.
// Unauthorized copying of this file is strictly prohibited.
// -------------------------------------------------------------

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
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
