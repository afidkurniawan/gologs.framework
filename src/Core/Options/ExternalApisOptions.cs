// -------------------------------------------------------------
// Copyright Go-Logs. All rights reserved.
// Proprietary and confidential.
// Unauthorized copying of this file is strictly prohibited.
// -------------------------------------------------------------

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
namespace GoLogs.Framework.Core.Options
{
    public class ExternalApisOptions
    {
        public const string ExternalApis = "ExternalApis";

        public ExternalApiOptions[] ExternalApiOptions { get; set; }
    }
}
