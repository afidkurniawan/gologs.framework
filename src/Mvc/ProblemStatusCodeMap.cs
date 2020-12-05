using Microsoft.AspNetCore.Http;

namespace GoLogs.Framework.Mvc
{
    public static class ProblemMapping
    {
        public static int GetStatusCode(ProblemType problemType)
        {
            return problemType switch
            {
                ProblemType.ERROR_NONE => StatusCodes.Status200OK,
                ProblemType.ERROR_MULTIPLE => StatusCodes.Status400BadRequest,
                ProblemType.ERROR_DATA_ALREADY_EXISTS => StatusCodes.Status409Conflict,
                _ => StatusCodes.Status400BadRequest
            };
        }

        public static string GetProblemDetailType(int statusCode)
        {
            return statusCode switch
            {
                400 => "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                401 => "https://tools.ietf.org/html/rfc7235#section-3.1",
                403 => "https://tools.ietf.org/html/rfc7231#section-6.5.3",
                404 => "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                406 => "https://tools.ietf.org/html/rfc7231#section-6.5.6",
                409 => "https://tools.ietf.org/html/rfc7231#section-6.5.8",
                415 => "https://tools.ietf.org/html/rfc7231#section-6.5.13",
                422 => "https://tools.ietf.org/html/rfc4918#section-11.2",
                500 => "https://tools.ietf.org/html/rfc7231#section-6.6.1",
                _ => $"https://httpstatuses.com/{statusCode}"
            };
        }
    }
}
