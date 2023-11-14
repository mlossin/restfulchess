using Microsoft.AspNetCore.Diagnostics;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace RestfullChess.Api.Middlewares;

/// <summary>
/// Class produces output for any fails within the pipeline
/// </summary>
public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, ILogger<ExceptionMiddleware> logger)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            //System.Diagnostics.Debug.WriteLine($"An error occured: {ex.Message}",ex); //TODO: Replace with real logging
            logger.LogError($"An error occured: {ex.Message}",ex);
            context.Response.StatusCode = 500;
            context.Response.ContentType = "text/html";
        }
    }
}
