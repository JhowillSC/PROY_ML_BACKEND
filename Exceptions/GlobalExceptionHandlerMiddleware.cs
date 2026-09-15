using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;
using System;
using System.Threading.Tasks;

namespace ML_PROY_BACKEND.Exceptions
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode status;
            string message;
            
            var exceptionType = exception.GetType();

            if (exceptionType == typeof(BadRequestException))
            {
                status = HttpStatusCode.BadRequest;
                message = exception.Message;
            }
            else if (exceptionType == typeof(NotFoundException))
            {
                status = HttpStatusCode.NotFound;
                message = exception.Message;
            }
            else
            {
                status = HttpStatusCode.InternalServerError;
                message = exception.Message;
            }

            var result = JsonSerializer.Serialize(new { error = message });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)status;
            return context.Response.WriteAsync(result);
        }
    }
}
