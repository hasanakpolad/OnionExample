using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionExample.Domain.DTOes;
using OnionExample.Services.Interfaces;

namespace OnionExmaple.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private ISessionService service;
        public SessionController(ISessionService _service)
        {
            service = _service;
        }

        [HttpGet(nameof(Get))]
        public IActionResult Get(int id)
        {
            return Ok(service.GetSession(id));
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            return Ok(service.GetAllSession());
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(AddSessionDto sessionDto)
        {
            try
            {
                if (sessionDto == null) return BadRequest();
                service.Add(sessionDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut(nameof(Update))]
        public IActionResult Update(SessionDto sessionDto)
        {
            try
            {
                if (sessionDto == null) return BadRequest();
                service.Update(sessionDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete(nameof(Delete))]
        public IActionResult Delete(SessionDto sessionDto)
        {
            try
            {
                if (sessionDto == null) return BadRequest();
                service.Delete(sessionDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
