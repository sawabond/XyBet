using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using XYB.API.DTOs.User;
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

        public UserController(
            ITokenService tokenService,
            IMapper mapper,
            ISignInManager signInManager,
            IUnitOfWork uow
            )
        {
            _tokenService = tokenService;
            _mapper = mapper;
            _signInManager = signInManager;
            _uow = uow;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserViewModel>> CreateUser([FromBody] UserCreateModel createModel)
        {
            var user = _mapper.Map<AppUser>(createModel);

        }
    }
}
