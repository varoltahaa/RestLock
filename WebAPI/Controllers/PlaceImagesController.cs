using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceImagesController : ControllerBase
    {

        IPlaceImageService _placeImageService;

        public PlaceImagesController(IPlaceImageService placeImageService)
        {
            _placeImageService = placeImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] PlaceImage placeImage)
        {
            var result = _placeImageService.Add(file, placeImage);
            if (result.Success)
            {
                return Ok(result);
            }
            
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _placeImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyplaceid")]

        public IActionResult GetByPlaceId(int placeId)
        {
            var result = _placeImageService.GetByPlaceId(placeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId)
        {
            var result = _placeImageService.GetByImageId(imageId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getimage")]
        public IActionResult GetImage(string imagePath)
        {
            Byte[] b;

            b = System.IO.File.ReadAllBytes("C:/Users/Taha/Desktop/RestLock/RestLock/WebAPI/wwwroot/Uploads/Images/" + imagePath);
          
            return File(b, "image/jpeg");
        }


    }
}
