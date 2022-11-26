using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionExample.Services.Interfaces;

namespace OnionExmaple.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService service;
        public MovieController(IMovieService _service)
        {
            service = _service;
        }
        [HttpGet(nameof(Get))]
        public ActionResult Get(int id)
        {
            return Ok(service.GetMovie(id));
        }
        [HttpGet(nameof(GetAll))]
        public ActionResult GetAll()
        {
            return Ok(service.GetAllMovie());
        }

        [HttpGet(nameof(GetMovieByDto))]
        public ActionResult GetMovieByDto()
        {

            return Ok(service.GetAllMovieByDto());
        }
    }
}
