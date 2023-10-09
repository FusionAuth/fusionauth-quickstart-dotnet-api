using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PanicController : ControllerBase
{
   
    [HttpGet]
    [Authorize(Roles = "teller")]
    [Authorize]
    public string Get()
    {
        return "We've called the police!";
    }
}
