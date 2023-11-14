using Microsoft.AspNetCore.Mvc;
using RestfulChess.Common.Contracts.Enumerations;

namespace RestfullChess.Api.Controllers;

[ApiVersion("1.0")]
[Route("api/game")]
[ApiController]
public class GameController : ControllerBase
{
    [HttpPost()]
    public async Task<IActionResult> StartNewGame()
    {
        await Task.CompletedTask;
        return NotFound();
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpGet("{column}/{row}/{player}")]
    public async Task<IActionResult> GetPossibleMovementsForSelectedFieldAndPlayer(
           int player,
           int column,
           int row)
    {
        var playerColor = (EPlayerColors)player;
        var columnTyp = (EColumnPosition)column;
        var rowPosition = (ERowPosition)row;
        return Ok();
    }
}
