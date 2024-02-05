using BlazorWasmDotNetShared.Entities;
using DotNet8BlazorWebAssembly.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet8BlazorWebAssembly.Controllers
{
	[Route("api/videogames")]
	[ApiController]
	public class VideoGamesController : ControllerBase
	{
		private readonly DataContext _context;

		public VideoGamesController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<VideoGame>>> GetAllVideoGamesAsync()
		{
			return await _context.VideoGames.ToListAsync();
		}
        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetGameByIdAsync(int id)
        {
            var result = await _context.VideoGames.FindAsync(id);
			if (result == null)
			{
				return NotFound("Why Why ?");
			}else
			{
				return Ok(result);
			}
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameAsync(int id)
        {
            var result = await _context.VideoGames.FindAsync(id);
            if (result == null) 
			    return NotFound("The Game Not Found");
			
			_context.Remove(result);
			await _context.SaveChangesAsync();
		           
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<VideoGame>> UpdateGameAsync(int id, VideoGame updatedGame)
        {
            var dbGame = await _context.VideoGames.FindAsync(id);
            if (dbGame == null)
                return NotFound("The Game Not Found");

			dbGame.Title = updatedGame.Title;
			dbGame.Publisher = updatedGame.Publisher;
			dbGame.ReleaseYear = updatedGame.ReleaseYear;

            await _context.SaveChangesAsync();

            return Ok(dbGame);
        }
        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddGameAsync(VideoGame newGame )
        {
            _context.Add(newGame);

            await _context.SaveChangesAsync();

            return Ok(newGame);
        }
    }
}
