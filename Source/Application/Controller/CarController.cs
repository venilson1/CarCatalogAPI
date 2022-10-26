using CarCatalogAPI.Source.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogAPI.Source.Application.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<CarEntity>> FindAll()
        {
            return Ok();
        }
    }
}
