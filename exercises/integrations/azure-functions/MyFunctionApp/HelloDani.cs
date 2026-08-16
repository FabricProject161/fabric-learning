using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace MyFunctionApp
{
    public class HelloDani
    {
        private readonly ILogger _logger;

        public HelloDani(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HelloDani>();
        }

        [Function("HelloDani")]
        public HttpResponseData Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("HelloDani Function executed.");

            var response = req.CreateResponse(System.Net.HttpStatusCode.OK);
            response.WriteString("Hallo Dani – deine erste Azure Function läuft!");

            return response;
        }
    }
}
