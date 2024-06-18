using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;
using MyFirstApi.Services;
namespace MyFirstApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly PostsServices _postsService;

    public PostsController()
    {
        _postsService = new PostsServices();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Post>> GetPost(int id) {
        var post = await _postsService.GetPost(id);
        if (post == null) {
            return NotFound();
        }

        return Ok(post);
    }
    [HttpPost]
    public async Task<ActionResult<Post>> CreatePost(Post post) {
        await _postsService.CreatePost(post);
        return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
    }
}

