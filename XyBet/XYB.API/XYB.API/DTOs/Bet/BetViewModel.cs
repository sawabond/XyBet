using XYB.Data.Enums;

namespace XYB.API.DTOs.Bet
{
    public class BetViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public double BetSum { get; set; }

        public BetResult Result { get; set; } = BetResult.InProgress;
    }
}
