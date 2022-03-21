using Microsoft.AspNetCore.Mvc;

namespace _5I_Marcatelli_Crossword.Controllers;

[ApiController]
[Route("[controller]")]
public class CruciverbaController : ControllerBase
{

    DbCruciverba _context;

    public CruciverbaController(DbCruciverba context)
    {
        _context = context;
    }

    //[HttpGet]
    // public async Task<ActionResult<CruciverbaDTO>> GetCruciverba()
    // {
        
    // }
}

