using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Models;

namespace MyAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PanicController : ControllerBase
{
   
    [HttpPost]
    [Authorize(Roles = "teller")]
    public PanicResponse Post()
    {
        return new PanicResponse("We've called the police!");
    }
}
