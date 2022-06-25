using System;
using System.Collections.Generic;

namespace XYB.Data.Entities
{
    public class GameMatch
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public ICollection<Bet> Bets { get; set; }

        public int FirstTeamId { get; set; }

        public int SecondTeamId { get; set; }
    }
}