using Microsoft.AspNetCore.Mvc;

namespace Cweb01.Controllers
{
    [Route("/api/[controller]/")]
    [ApiController]
    public class TestController:ControllerBase
    {
        [HttpGet("1")]
        public string Test1()
        {
            return "你好你好";
        }
        [HttpGet("2/{parm_a}/{parm_b}")]
        public string Test2([FromRoute(Name = "parm_a")] string parm_a,
                            [FromRoute(Name = "parm_b")] string parm_b)
        {
            return $"A={parm_a},B={parm_b}";
        }
    }
}