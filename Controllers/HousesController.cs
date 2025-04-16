namespace gregslist_dotnet.Controllers;


[ApiController]
[Route("api/houses")]
public class HousesController : ControllerBase
{
  [HttpGet]
  public string Test()
  {
    return "houses Conroller works";
  }
}