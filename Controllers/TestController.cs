using Microsoft.AspNetCore.Mvc;

namespace Cweb01.Controllers
{
    [Route("/test")]
    [ApiController]
    class TestController:ControllerBase
    {
        [HttpGet]
        public string Test1()
        {
            return "你好你好";
        }
    }
}