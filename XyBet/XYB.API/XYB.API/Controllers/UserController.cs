using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using XYB.API.Services.Abstractions;

namespace XYB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly ISignInManager _signInManager;

        public UserController(
            ITokenService tokenService,
            IMapper mapper,
            ISignInManager signInManager
            )
        {
            _tokenService = tokenService;
            _mapper = mapper;
            _signInManager = signInManager;
        }
    }
}
