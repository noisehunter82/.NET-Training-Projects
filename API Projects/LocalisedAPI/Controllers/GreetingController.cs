using LocalisedAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LocalisedAPI.Controllers;

[ApiController]
[Route("{region}/[controller]")]
public class GreetingController : ControllerBase
{
    [HttpGet(Name = "GetGreeting")]
    [Produces("text/plain")]
    public ActionResult<string> GetGreeting([FromRoute] Region region)
    {
        var service = HttpContext.RequestServices.GetKeyedService<IScripService>(region.ToString().ToLower());
        var response = service?.Greeting();

        if (response is null)
            return BadRequest();

        return Ok(response);
    }
}

public enum Region
{
    EMEA,
    AU,
    NA
}