using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        IPlaceService _placeService;
        public PlacesController(IPlaceService placeService)
        {
            _placeService = placeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _placeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int placeId)
        {
            var result = _placeService.GetPlaceById(placeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbycategoryid")]
        public IActionResult GetAllByCategoryId(int categoryId)
        {
            var result = _placeService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getplacebyuserid")]
        public IActionResult GetPlaceByUserId(int userId)
        {
            var result = _placeService.GePlaceByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("getmenudetail")]
        //public IActionResult GetMenuDetail()
        //{

        //}

        [HttpPost("add")]
        public IActionResult Add(Place place)
        {
            var result = _placeService.Add(place);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}