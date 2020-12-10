using Microsoft.AspNetCore.Http;

namespace GoLogs.Framework.Core.Contexts
{
    /// <summary>
    ///     An implementation of <see cref="IHttpContextAccessor"/>.
    /// </summary>
    public class ScopedHttpContext
    {
        public IHttpContextAccessor Accessor { get; }

        public ScopedHttpContext(IHttpContextAccessor httpContextAccessor)
        {
            Accessor = httpContextAccessor;
        }
    }
}