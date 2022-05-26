using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.models
{
    public class TourneyStanding
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }

        public Player Player { get; set; }

        public int Wins { get; set; }
        public int Losses { get; set; }
        public string Status { get; set; }
        public int? Place { get; set; }

        public TourneyStanding()
        {

        }
        public TourneyStanding(int id, int tourneyid, Player player, int wins, int losses, string status, int place)
        {
            Id = id;
            TournamentId = tourneyid;
            Player = player;
            Wins = wins;
            Losses = losses;
            Status = status;
            if (place == 0)
            {
                Place = null;
            }
            else
            {
                Place = place;
            }
        }
    }
}
