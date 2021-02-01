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
    public class ExternalApiOptions
    {
        public string Name { get; set; }

        public string BaseUri { get; set; }

        public KeyValue[] RequestHeaders { get; set; }

        public KeyValue[] RelativeUris { get; set; }
    }
}
