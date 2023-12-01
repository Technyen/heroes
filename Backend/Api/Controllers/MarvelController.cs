using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarvelController : ControllerBase
    {
        private readonly CreatorService _creatorService;

        public MarvelController(CreatorService creatorService)
        {
            _creatorService = creatorService;
        }

        [HttpGet("getCreators")]
        public async Task<ActionResult<List<Creator>>> GetCreators()
        {
            try
            {
                var result = await _creatorService.GetCreatorsAsync();
                return result;
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }
    }
}
