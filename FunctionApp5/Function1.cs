using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using ClassLibrary1;

namespace FunctionApp5
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var outputString = Class1.returnStr();
            log.Info(outputString);
            return Task.FromResult(req.CreateResponse(HttpStatusCode.OK, outputString));
        }
    }
}
