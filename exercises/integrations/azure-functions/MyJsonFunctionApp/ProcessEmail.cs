using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text;
using System.Text.Json;

namespace MyJsonFunctionApp
{

    public class ProcessEmail
    {
        private readonly ILogger _logger;

        public ProcessEmail(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ProcessEmail>();
        }

        [Function("ProcessEmail")]
            public async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
            {
                _logger.LogInformation("ProcessEmail triggered.");

                var body = await req.ReadAsStringAsync();
                InputModel data = JsonSerializer.Deserialize<InputModel>(body);

                if (data == null || string.IsNullOrWhiteSpace(data.Email))
                {
                    var badResponse = req.CreateResponse(HttpStatusCode.BadRequest);
                    badResponse.Headers.Add("Content-Type", "text/plain; charset=utf-8");
                    var bytes = Encoding.UTF8.GetBytes("Email is missing.");
                    await badResponse.Body.WriteAsync(bytes, 0, bytes.Length);
                    return badResponse;
                }

                _logger.LogInformation($"Received email: {data.Email}");

                var okResponse = req.CreateResponse(HttpStatusCode.OK);
                okResponse.Headers.Add("Content-Type", "text/plain; charset=utf-8");
                var okBytes = Encoding.UTF8.GetBytes("Email accepted.");
                await okResponse.Body.WriteAsync(okBytes, 0, okBytes.Length);
                return okResponse;
            }
        }
}
