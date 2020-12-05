// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace GoLogs.Framework.Core.Options
{
    public class ExternalApisOptions
    {
        public const string EXTERNAL_APIS = "ExternalApis";
        public ExternalApiOptions[] ExternalApiOptions { get; set; }
    }
}