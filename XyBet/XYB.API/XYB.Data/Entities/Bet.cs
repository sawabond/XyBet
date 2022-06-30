using System.ComponentModel.DataAnnotations.Schema;
using XYB.Data.Enums;

namespace XYB.Data.Entities
{
    public class Bet
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public double BetSum { get; set; }

        public BetResult Result { get; set; } = BetResult.InProgress;
    }
}