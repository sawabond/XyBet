using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using XYB.API.DTOs.User;
using XYB.API.Options;
using XYB.API.Services.Abstractions;
using XYB.Data.Abstractions;
using XYB.Data.Entities;

namespace XYB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly ISignInManager _signInManager;
        private readonly IUnitOfWork _uow;
        private readonly IUserService _userService;

        public UserController(
            ITokenService tokenService,
            IMapper mapper,
            ISignInManager signInManager,
            IUnitOfWork uow,
            IUserService userService
            )
        {
            _tokenService = tokenService;
            _mapper = mapper;
            _signInManager = signInManager;
            _uow = uow;
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserViewModel>> GetUserById(int id)
        {
            var user = await _uow.UserRepository.GetAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserViewModel>(user));
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserViewModel>> CreateUser([FromBody] UserCreateModel createModel)
        {
            var existingUser = await _uow.UserRepository.GetByUserNameAsync(createModel.UserName);

            if (existingUser is not null)
            {
                return BadRequest($"User with {createModel.UserName} already exists");
            }

            var newUser = _mapper.Map<AppUser>(createModel);

            var createResult = await _userService.CreateUserAsync(newUser, createModel.Password);

            if (!createResult.Succeeded)
            {
                return BadRequest("Unable to create a user");
            }

            var addToRoleResult = await _userService.AddToRoleAsync(newUser, Roles.User);

            return CreatedAtAction(nameof(GetUserById), _mapper.Map<UserViewModel>(newUser), newUser.Id);
        }
    }
}
