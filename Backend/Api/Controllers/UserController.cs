//using Domain.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        [HttpPost("create")]
//        public async Task<ActionResult> CreateAsync([FromForm] CreateStoryModel createStoryModel)
//        {
//            try
//            {
//                var story = _mapper.Map<Story>(createStoryModel);
//                var result = await _storyService.CreateStoryAsync(story, createStoryModel.FormFile);
//                if (result == CreateResult.Success)
//                {
//                    return Ok(story.Id);
//                }
//                else
//                {
//                    return Conflict();
//                }
//            }
//            catch (Exception ex)
//            {

//                return Problem(ex.Message);
//            }
//        }

//        [HttpGet("getAll")]
//        public async Task<ActionResult<List<User>>> GetCreators()
//        {
//            try
//            {
//                var result = await _marvelService.GetStoriesAsync();
//                return result;
//            }
//            catch (Exception ex)
//            {
//                return Problem(ex.Message);
//            }
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<User>?> GetStoryAsync(string id)
//        {
//            try
//            {
//                var result = await _storyService.GetStoryAsync(id);
//                if (result != null)
//                {
//                    return result;
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            catch (Exception ex)
//            {
//                return Problem(ex.Message);
//            }
//        }

//        [HttpPut("edit")]
//        public async Task<ActionResult> EditStoryAsync()
//        {
//            try
//            {
//                var story = _mapper.Map<Story>(editStoryModel);
//                var result = await _storyService.EditStoryAsync(story, editStoryModel.FormFile);

//                if (result == EditResult.Success)
//                {
//                    return Ok();
//                }
//                else
//                {
//                    return NotFound();
//                }
//            }
//            catch (Exception ex)
//            {

//                return Problem(ex.Message);
//            }
//        }

//        [HttpDelete("{storyId}")]
//        public async Task<ActionResult> DeleteStoryAsync(string storyId)
//        {
//            try
//            {
//                var response = await _storyService.DeleteStoryAsync(storyId);

//                if (response == DeleteResult.Success)
//                {
//                    return Ok();
//                }
//                else
//                {
//                    return NotFound();
//                }
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//    }
//}

    

