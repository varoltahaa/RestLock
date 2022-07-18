using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class PlaceCategoryController : ControllerBase
    {

        IPlaceCategoryService _placeCategoryService;

        public PlaceCategoryController(IPlaceCategoryService placeCategoryService)
        {
            _placeCategoryService = placeCategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _placeCategoryService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
