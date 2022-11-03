using Microsoft.AspNetCore.Mvc;

namespace forumThreadEF.Controllers
{
    [ApiController]
    [Route("api/forumThread")]
    public class ForumThreadController : ControllerBase
    {
        public ForumThreadController()
        {
            
        }

        [HttpGet("abc")]
        public ActionResult<int> Get()
        {
            return Ok(0);
        }
    }
}