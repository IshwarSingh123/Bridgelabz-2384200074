
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IshwarSinghController:ControllerBase
    {
        [HttpGet]
        public string HelloApp()
        {
            return "Hello World";
        }
    }
}
