using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myFirstApi.BLL;
using myFirstApi.DTOs;

namespace myFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService service) : ControllerBase
    {
        private readonly IUserService _userService = service;
        [HttpPost]
        public IActionResult Add(UserToAddDto dto)
        {
            _userService.Add(dto);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get() 
        { 
            var data = _userService.GetAll();
            return Ok(data); 
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserToUpdateDto dto)
        {
            _userService.Update(dto);
            return Ok(new {Message = "User updated successfully!"});

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}
