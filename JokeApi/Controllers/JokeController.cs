using Microsoft.AspNetCore.Mvc;

namespace JokeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : ControllerBase
    {

        private readonly JokeService _JokeService;

        public JokeController(JokeService jokeService)
        {
            _JokeService = jokeService;
        }

        [HttpGet(Name = "Random")]
        public Joke Get()
        {
            return _JokeService.GetRandomJoke();
        }
    }
}