using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using XYB.API.DTOs;

namespace XYB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        public BetController()
        {

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BetViewModel>>> GetBets()
        {
            return Ok(new List<BetViewModel> { new BetViewModel() });
        }
    }
}
