using XYB.Data.Enums;

namespace XYB.API.DTOs.Bet
{
    public class CreateBetModel
    {
        public double BetSum { get; set; }

        public BetResult Result { get; set; } = BetResult.InProgress;
    }
}
