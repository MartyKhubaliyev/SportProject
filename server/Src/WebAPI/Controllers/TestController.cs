using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class TestController : ApiControllerBase
    {
        [HttpGet]
        public string Ping()
        {
            return "pong";
        }
    }
}
