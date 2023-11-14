namespace RestfullChess.Api;

/// <summary>
/// Extension methods for the <see cref="HttpContext"/>
/// </summary>
public static class HttpContextExtensions
{
    /// <summary>
    /// If Responsecode is in range between 200-299 it is considered successful.
    /// </summary>
    public static bool IsResponseSuccessful(this HttpContext context)
    {
        if (context.Response.StatusCode >= 200 
        &&  context.Response.StatusCode <= 299) {
            return true;
        }
        return false;
    }
}
