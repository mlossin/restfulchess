using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestfulChess.Api.Contracts.Transfers.Parameters;
using RestfulChess.Business.Implementation;
using RestfulChess.Common.Contracts.Enumerations;
using RestfulChess.Common.Contracts.Games;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestfullChess.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private IMapper mapper;
        private readonly LinkGenerator linkGenerator;

        public BoardController(IMapper mapper,
            LinkGenerator linkGenerator)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.linkGenerator = linkGenerator ?? throw new ArgumentNullException(nameof(linkGenerator));
        }

        // GET: api/<BoardController>
        [HttpGet("empty")]
        public async Task<IActionResult> GetEmptyBoardAsync()
        {
            var chessBoard = new ChessBoardCreator().CreateChessBoard(); //ToDo: DI
            var result = mapper.Map<ChessBoardDto>(chessBoard);
            await Task.CompletedTask;
            return Ok(result);
        }

        [HttpGet("new")]
        public async Task<IActionResult> GetNewBoardAsync()
        {
            var chessBoard = new ChessBoardCreator().CreateChessBoard(); //ToDo: DI
            var boardEnricher = new ChessBoardEnricher(new ChessBoardFigureMover());//ToDo: DI
            boardEnricher.FillChessBoard(chessBoard);
            var result = mapper.Map<ChessBoardDto>(chessBoard);
            await Task.CompletedTask;
            return Ok(result);
        }

        [HttpGet("{column}/{row}/{player}")]
        public async Task<IActionResult> GetByFieldAsync(
            int player,
            int column,
            int row)
        {
            var playerColor = (EPlayerColors)player;
            var columnTyp = (EColumnPosition)column;
            var rowPosition = (ERowPosition)row;
            return Ok();
        }

        //// GET api/<BoardController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<BoardController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<BoardController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<BoardController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
