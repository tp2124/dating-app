using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // This will automatically be reading the attributes, as well as others, from the DTO and returning errors
    // in following the attributes's rules.
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo) {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(/*[FromBody] Used to parse data from body*/UserForRegisterDto userForRegisterDto) {
            // This can be done if the [ApiController] is removed to allow for the same ModelState error messages
            // // Coming back from the requests
            // if (!ModelState.IsValid) 
            //     return BadRequest(ModelState);

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repo.UserExists(userForRegisterDto.Username)) {
                return BadRequest("Username already exists");
            }

            var userToCreate = new User {
                Username = userForRegisterDto.Username
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            // Tells the user where to access the newly created entity
            // return CreatedAtRoute()
            return StatusCode(201);
        }
    }
}