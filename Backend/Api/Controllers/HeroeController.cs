//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Domain.Entities;

//namespace Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class HeroeController : ControllerBase
//    {
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
