using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionExample.Application.Services;
using OnionExample.Domain.DTOes;
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

        [HttpPost]
        public IActionResult Search(SearchDto model)
        {
            return Ok(service.SearchMovie(model));
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovieDto movieDto)
        {
            try
            {
                if (movieDto == null) return BadRequest();
                service.Add(movieDto);
                return Ok();

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPut]
        public IActionResult UpdateMovie(MovieDto movieDto)
        {
            try
            {
                if (movieDto == null) return BadRequest();
                service.Update(movieDto);
                return Ok();

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpDelete]
        public IActionResult DeleteMovie(MovieDto movieDto)
        {
            try
            {
                if (movieDto == null) return BadRequest();
                service.Delete(movieDto);
                return Ok();

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
