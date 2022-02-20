using Business.Services;
using Core.Dtos;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("LoginWithModel")]
        public IActionResult Login(User user)
        {
            return Ok();
        }

        [HttpPost]
        [Route("LoginWithDto")]
        public IActionResult Login(LoginDto loginDto)
        {
            _authService.Login(loginDto);
            return Ok();
        }
    }
}
