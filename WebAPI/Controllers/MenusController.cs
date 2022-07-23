using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        IMenuService _menuService;
        IPlaceService _placeService;

        public MenusController(IMenuService menuService, IPlaceService placeService)
        {
            _menuService = menuService;
            _placeService = placeService;   
        }

        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            var result = _menuService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Menu menu)
        {
            var result = _menuService.Add(menu);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }


        [HttpGet("getbyplaceid")]
        public IActionResult GetByPlaceId (int id)
        {
            var result = _menuService.GetByPlaceId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbymenudetail")]

        public IActionResult GetByMenuDetail(int placeId)
        {
            var result = _placeService.GetPlaceDetails(placeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
