using HotelReservation.BusinessLayer.Abstract;
using HotelReservation.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var testimonial = _testimonialService.TGetList();

            return Ok(testimonial);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var testimonial = _testimonialService.TGetById(id);
            _testimonialService.TDelete(testimonial);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonialById(int id)
        {
            var testimonial = _testimonialService.TGetById(id);
            return Ok(testimonial);
        }
    }
}
