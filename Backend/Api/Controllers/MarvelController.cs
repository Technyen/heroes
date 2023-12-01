//using Domain.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Application.Services;

//namespace Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MarvelController : ControllerBase
//    {
//        private readonly MarvelService _marvelService;
//        public MarvelController (MarvelService marvelService)
//        {
//            _marvelService = marvelService;
//        }
//        [HttpGet("getCreator")] 
//        public async Task<ActionResult<List<Creator>>> GetCreator()
//        {
//            try
//            {
//                var result = await _marvelService();
//                return result;
//            }
//            catch (Exception ex)
//            {
//                return Problem(ex.Message);
//            }

//        }
//    }
//}
