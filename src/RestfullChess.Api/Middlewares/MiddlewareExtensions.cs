namespace RestfullChess.Api.Middlewares;

/// <summary>
/// Extensionmethods for Middleware, especially registration in pipeline.
/// </summary>
public static class MiddlewareExtensions
{
    /// <summary>
    /// Integrate ExceptionMiddleware into pipeline
    /// </summary>
    /// <param name="appBuilder"></param>
    /// <returns></returns>
    public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder appBuilder)
    {
        return appBuilder.UseMiddleware<ExceptionMiddleware>();
    }
}
