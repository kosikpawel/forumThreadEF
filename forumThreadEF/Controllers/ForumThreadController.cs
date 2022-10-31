using Microsoft.AspNetCore.Mvc;

namespace forumThreadEF.Controllers
{
    [ApiController]
    [Route("api/forumThread")]
    public class ForumThreadController : ControllerBase
    {
        private readonly ILogger<ForumThreadController> _logger;

        public ForumThreadController(ILogger<ForumThreadController> logger)
        {
            _logger = logger;
        }

        [HttpGet("abc")]
        public ActionResult<int> Get()
        {
            return Ok(0);
        }
    }
}