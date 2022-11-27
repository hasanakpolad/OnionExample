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

        [HttpGet(nameof(Get))]
        public IActionResult Get(int id)
        {
            return Ok(service.GetSaloon(id));
        }
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            return Ok(service.GetAllSaloon());
        }
        [HttpPost((nameof(Add)))]
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
        [HttpPut(nameof(Update))]
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
        [HttpDelete(nameof(Delete))]
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
