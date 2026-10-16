using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaceDayApi.Data;
using RaceDayApi.Models;
using RaceDayApi.Services;
using RaceDayApi.Models.DTOs;


namespace RaceDayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        [Authorize]
        [HttpGet("profile")]
        public IActionResult Profile()
        {
            return Ok("you are authenticated");
        }

        private readonly AppDbContext _db;
        private readonly JwtService _jwtservice;
        private IPasswordHasher<UserAccount> _passwordHasher;
        public AuthController(
            AppDbContext db,
            IPasswordHasher<UserAccount> passwordHasher,
            JwtService jwtservice)
            
        {
            _db = db;
            _passwordHasher = passwordHasher;
            _jwtservice = jwtservice;
           
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (await _db.Users.AnyAsync(u => u.Email == dto.Email))
            {
                return BadRequest("Email already exists" );
            }
            var user = new UserAccount
            {
                Email = dto.Email,
                Role = dto.Role,
                PasswordHash = string.Empty
            };
            user.PasswordHash = _passwordHasher.HashPassword(user, dto.Password);
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return Ok("User registered successfully");


        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (user is null)
                return Unauthorized("Invalid login ");
            var result = _passwordHasher.VerifyHashedPassword(
                user, user.PasswordHash, dto.HashPassword);
            if (result == PasswordVerificationResult.Failed)
                return Unauthorized("Invalid login");
            var token = _jwtservice.CreateToken(user.Email, user.Role, user.UserId);
            return Ok(new
            {
                token,
                role = user.Role
            });

        }
    }

}

