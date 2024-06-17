using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;

namespace MyFirstApi.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Post>> GetPosts()
        {
            return new List<Post>
            {
                new() { Id = 1, UserId = 1, Title = "Post1", Body = "The first post." },
                new() { Id = 2, UserId = 1, Title = "Post2", Body = "The second post." },
                new() { Id = 3, UserId = 1, Title = "Post3", Body = "The third post." }
            };
        }
    }
}
