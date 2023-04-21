using Microsoft.AspNetCore.Mvc;

namespace GrpcWithRest.Controllers;

[ApiController]
[Route("test")]
public class TestControllers : ControllerBase 
{
    [Route("test-me")]
    public IActionResult TestMe()
    {
        return Ok("test-me");
    }
}