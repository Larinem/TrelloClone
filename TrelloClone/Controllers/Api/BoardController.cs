using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrelloClone.Services;
using TrelloClone.ViewModel;

namespace TrelloClone.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly BoardService _boardService;
        public BoardController(BoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpPost("movecard")]
        public IActionResult MoveCard([FromBody] MoveCardCommand command)
        {
            return Ok(new
            {
                Moved = true
            });
        }
    }
}