// -------------------------------------------------------------
// Copyright Go-Logs. All rights reserved.
// Proprietary and confidential.
// Unauthorized copying of this file is strictly prohibited.
// -------------------------------------------------------------

using Microsoft.AspNetCore.Http;

// ReSharper disable UnusedType.Global
namespace GoLogs.Framework.Core.Contexts
{
    /// <summary>
    ///     An implementation of <see cref="IHttpContextAccessor"/>.
    /// </summary>
    public class ScopedHttpContext
    {
        public ScopedHttpContext(IHttpContextAccessor httpContextAccessor)
        {
            Accessor = httpContextAccessor;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public IHttpContextAccessor Accessor { get; }
    }
}
