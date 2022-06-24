using XYB.Data.Enums;

namespace XYB.Data.Entities
{
    public class Bet
    {
        public int Id { get; set; }
        
        public AppUser User { get; set; }

        public double BetSum { get; set; }

        public BetResult Result { get; set; } = BetResult.InProgress;

        public GameMatch Match { get; set; }
    }
}