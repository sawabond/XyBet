using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XYB.API.DTOs.Bet;
using XYB.Data.Abstractions;
using XYB.Data.Enums;

namespace XYB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public BetController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BetViewModel>>> GetBets()
        {
            var bets = await _uow.BetRepository.GetAllAsync();

            if (!bets.Any())
            {
                return NotFound("There are no any bets");
            }

            return Ok(_mapper.Map<IEnumerable<BetViewModel>>(bets));
        }

        [HttpGet("dummy")]
        public ActionResult<IEnumerable<BetViewModel>> GetBetsDummy()
        {
            return Ok(new List<BetViewModel>
            {
                new BetViewModel { Id = 1, UserId = 1, BetSum = 100, Result = BetResult.Declined },
                new BetViewModel { Id = 2, UserId = 1, BetSum = 10, Result = BetResult.Success },
                new BetViewModel { Id = 3, UserId = 1, BetSum = 1020, Result = BetResult.InProgress },
                new BetViewModel { Id = 4, UserId = 1, BetSum = 110, Result = BetResult.Failure },
                new BetViewModel { Id = 5, UserId = 1, BetSum = 50, Result = BetResult.Success }
            });
        }
    }
}
