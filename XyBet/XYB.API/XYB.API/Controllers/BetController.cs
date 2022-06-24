using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XYB.API.DTOs;
using XYB.Data.Abstractions;

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
    }
}
