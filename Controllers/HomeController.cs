using apiPersonaNet.Models;
using GateWayApi.Models;
using GateWayApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GateWayApi.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private SalesReport services = new SalesReport();

        [HttpPost("report1")]
        public async Task<List<Register>> report([FromBody] int[] year)
        {
            Console.WriteLine("api/home/report");
            return await services.salesReport(year);
        }

        [HttpPost("report2")]
        public async Task<List<Register>> report2([FromBody] int[] year)
        {
            Console.WriteLine("api/home/report2");
            return await services.salesReport2(year);
        }

        [HttpPost("auth")]
        public async Task<UserModel> auth(LoginCredentials auth)
        {
            Console.WriteLine(auth);
            return await services.auth(auth);
        }


        [HttpGet("index")]
        public string index(){
            return "index";
        }
    }
}
