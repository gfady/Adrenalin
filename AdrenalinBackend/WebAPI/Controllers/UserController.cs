using Application.Interfaces;
using Domain.DTOs.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("Register/{userName}, {password}")] 
        [AllowAnonymous]
        public async Task<ActionResult> Register(string userName, string password)
        {
            if (userName == null || password == null) 
                return BadRequest("Passed u or password is invalid");

            var loginResponse = await userService.RegisterUserAsync(userName, password);

            if (loginResponse == null) return BadRequest("Passed userName already exists");

            return Ok(loginResponse);
        }

        [HttpPost("Login")] 
        [AllowAnonymous]
        public async Task<ActionResult> Login([FromBody]LoginRequest loginRequest)
        {
            var isExists = await userService.GetUserByName(loginRequest.UserName);

            if (!isExists) return BadRequest("User with passed user name isn't exists");

            var response = await userService.LoginUserAsync(loginRequest);

            if (response == null) return BadRequest("Passed password is invalid");

            return Ok(response);
        }
    }
}
