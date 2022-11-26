using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionExample.Domain.DTOes;
using OnionExample.Services.Interfaces;

namespace OnionExmaple.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalloonController : ControllerBase
    {
        private ISalloonService service;
        public SalloonController(ISalloonService _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(service.GetSaloon(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetAllSaloon());
        }
        [HttpPost]
        public IActionResult Add(AddSalloonDto salloonDto)
        {
            try
            {
                if (salloonDto == null) return BadRequest();
                service.Add(salloonDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPut]
        public IActionResult Update(SalloonDto salloonDto)
        {
            try
            {
                if (salloonDto != null) return BadRequest();
                service.Update(salloonDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpDelete]
        public IActionResult Delete(SalloonDto salloonDto)
        {
            try
            {
                if (salloonDto != null) return BadRequest();
                service.Delete(salloonDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
