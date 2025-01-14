using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Scl.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var post = new Post { Id = id, Text = "Hello, world" };
            return Ok(post);
        }
    }
}
