using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pocASMX;
using SoapCoreReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wcfServer;

namespace ASMXClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoapTestController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SoapTestController> _logger;

        public SoapTestController(ILogger<SoapTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet("net-core-asmx-test")]
        public async  Task<ActionResult<MyCustomModel>> Get()
        {
            var model = new MyCustomModel()
            {
                Id = 2,
                Email = "soapCoreTested@gmail.com",
                Name = "Arvind",
            };

            var client = new SampleServiceClient(SampleServiceClient.EndpointConfiguration.BasicHttpBinding_ISampleService);
            var ress = await client.TestCustomModelAsync(model);
            return Ok(ress);
        }


        [HttpGet("net-asmx-test")]
        public async Task<ActionResult<HelloWorldResponse>> GetAsmx()
        {

            var client = new SoupDemoSoapClient(pocASMX.SoupDemoSoapClient.EndpointConfiguration.SoupDemoSoap);
            var ress = await client.HelloWorldAsync();
            return Ok(ress.Body.HelloWorldResult);
        }

        [HttpGet("wcf-test")]
        public async Task<ActionResult<HelloWorldResponse>> GetWCF()
        {

            var client = new Service1Client(wcfServer.Service1Client.EndpointConfiguration.BasicHttpBinding_IService1);
            var ress = await client.GetDataAsync(100);
            return Ok(ress);
        }
    }
}
