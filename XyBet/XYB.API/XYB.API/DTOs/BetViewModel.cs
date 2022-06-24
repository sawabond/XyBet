using XYB.Data.Entities;
using XYB.Data.Enums;

namespace XYB.API.DTOs
{
    public class BetViewModel
    {
        public int Id { get; set; }
        
        public AppUser User { get; set; }

        public double BetSum { get; set; }

        public BetResult Result { get; set; } = BetResult.InProgress;

        public GameMatch Match { get; set; }
    }
}
