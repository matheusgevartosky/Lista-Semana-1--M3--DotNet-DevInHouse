using Lista_Semana_1__M3__DotNet_DevInHouse.DTO;
using Lista_Semana_1__M3__DotNet_DevInHouse.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lista_Semana_1__M3__DotNet_DevInHouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandController : ControllerBase
    {

        private readonly IBandService _bandService;

        public BandController(IBandService bandService)
        {
            _bandService = bandService;
        }

        [HttpGet]
        public ActionResult<IList<BandGetDTO>> Get()
        {
            try
            {
                return Ok(_bandService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
            
        }


        [HttpPost]
        public ActionResult<BandPostDTO> Post([FromBody] BandPostDTO request)
        {
            try
            {
                var returns = _bandService.Add(request);
                return request;
            }
            catch (Exception e)
            {
                return NotFound(e);
            }

        }


        [HttpPut("{id}")]
        public ActionResult<bool> Put(BandPutDTO request)
        {
            try
            {
                return _bandService.Update(request);
            }
            catch(Exception e)
            {
                return NotFound(e);
            };
        }


        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            try
            {
                return Ok(_bandService.Delete(id));

            }
            catch(Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
