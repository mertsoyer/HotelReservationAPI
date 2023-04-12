using HotelReservation.BusinessLayer.Abstract;
using HotelReservation.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var staffs = _staffService.TGetList();

            return Ok(staffs);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var staff=_staffService.TGetById(id);
            _staffService.TDelete(staff);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffById(int id)
        {
          var staff=  _staffService.TGetById(id);
            return Ok(staff);
        }
    }
}
