namespace chore_score.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{
  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }
  private readonly ChoresService _choresService;



  [HttpGet]
  public ActionResult<List<Chore>> GetAllChores()
  {
    try
    {
      List<Chore> chores = _choresService.GetAllChores();
      return Ok(chores);
    }
    catch (Exception error)
    {

      return BadRequest(error.Message);
    }
  }


  [HttpGet("{choreId}")]
  public ActionResult<List<Chore>> GetChoreById(int choreId)
  {
    try
    {
      Chore chore = _choresService.GetChoreById(choreId);
      return Ok(chore);
    }
    catch (Exception error)
    {

      return BadRequest(error.Message);
    }
  }

}
