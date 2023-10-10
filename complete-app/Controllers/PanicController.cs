using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PanicController : ControllerBase
{
   
    [HttpPost]
    [Authorize(Roles = "teller")]
    [Authorize]
    public string Post()
    {
        return "We've called the police!";
    }
}
