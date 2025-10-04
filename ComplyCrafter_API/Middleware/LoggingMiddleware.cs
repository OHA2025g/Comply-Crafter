using Org.BouncyCastle.Asn1.Ocsp;
using System.Text;

namespace ComplyCrafter_API.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;
        private readonly string _filePath = "Logs";
        private static object _fileLock = new();

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await LogRequest(context);

            var originalBodyStream = context.Response.Body;
            using var responseBody = new MemoryStream();
            context.Response.Body = responseBody;

            await _next(context);

            context.Response.Body.Seek(0, SeekOrigin.Begin);
            var responseText = await new StreamReader(context.Response.Body).ReadToEndAsync();
            if (!responseText.Contains("<title>Swagger UI</title>")
                && !responseText.Contains("\"title\": \"ComplyCrafter_API\""))
            {
                LogResponse(context, responseText);
            }

            context.Response.Body.Seek(0, SeekOrigin.Begin);
            await responseBody.CopyToAsync(originalBodyStream);
            context.Response.Body = originalBodyStream;
        }

        private async Task LogRequest(HttpContext httpContext)
        {
            var request = httpContext.Request;
            var routeData = httpContext.GetRouteData();

            var controller = routeData.Values["controller"]?.ToString() ?? "UnknownController";
            var action = routeData.Values["action"]?.ToString() ?? "UnknownAction";

            var requestBody = await GetRequestBody(httpContext);

            var requestLog = new StringBuilder();
            requestLog.AppendLine("----- Incoming Request -----");
            requestLog.AppendLine($"Timestamp: {DateTime.Now} \n");
            requestLog.AppendLine($"Controller: {controller} \n");
            requestLog.AppendLine($"Action: {action} \n");
            requestLog.AppendLine($"Method: {request.Method} \n");
            requestLog.AppendLine($"Path: {request.Path}  \n");
            requestLog.AppendLine($"QueryString: {request.QueryString}");
            requestLog.AppendLine($"Body: {requestBody}  \n");
            requestLog.AppendLine($"Content-Type: {request.ContentType ?? "N/A"}  \n");
            requestLog.AppendLine($"Content-Length: {request.ContentLength?.ToString() ?? "N/A"}  \n");
            requestLog.AppendLine("----------------------------");
            if (request.Path != "/swagger/index.html")
                WriteToFile(requestLog.ToString());
            //_logger.LogInformation(requestLog.ToString());
        }

        public void LogResponse(HttpContext httpContext, string responseBody)
        {
            var routeData = httpContext.GetRouteData();
            var controller = routeData.Values["controller"]?.ToString() ?? "UnknownController";
            var action = routeData.Values["action"]?.ToString() ?? "UnknownAction";
            var responseLog = new StringBuilder();
            responseLog.AppendLine("----- Outgoing Response -----");
            responseLog.AppendLine($"Timestamp: {DateTime.Now} \n");
            responseLog.AppendLine($"Controller: {controller}  \n");
            responseLog.AppendLine($"Action: {action}");
            responseLog.AppendLine($"StatusCode: {httpContext.Response.StatusCode}  \n");
            responseLog.AppendLine($"Body: {responseBody}  \n");
            responseLog.AppendLine($"Content-Type: {httpContext.Response.ContentType ?? "N/A"}  \n");
            responseLog.AppendLine("-----------------------------");
            if (responseBody.Contains("<title>Swagger UI</title>") == false || responseBody.Contains("\"title\": \"ComplyCrafter_API\"") == false)
                WriteToFile(responseLog.ToString());
            //_logger.LogInformation(responseLog.ToString());
        }

        public async Task<string> GetRequestBody(HttpContext httpContext)
        {
            httpContext.Request.EnableBuffering();
            httpContext.Request.Body.Seek(0, SeekOrigin.Begin);
            using var reader = new StreamReader(httpContext.Request.Body, Encoding.UTF8, leaveOpen: true);
            var body = await reader.ReadToEndAsync();
            httpContext.Request.Body.Seek(0, SeekOrigin.Begin);
            return body;
        }

        private void WriteToFile(string message)
        {
            var logDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            var logFile = Path.Combine(logDirectory, $"log-{DateTime.Now:yyyy-MM-dd}.txt");
            if (!File.Exists(logFile))
            {
                using (File.Create(logFile)) { }
            }
            lock (_fileLock)
                File.AppendAllText(logFile, message + Environment.NewLine);
        }
    }

}