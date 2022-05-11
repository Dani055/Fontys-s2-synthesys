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
        public int PlayerId { get; set; }
        public string PlayerFirstname { get; set; }
        public string PlayerLastname { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string Status { get; set; }
        public int? Place { get; set; }

        public TourneyStanding()
        {

        }
        public TourneyStanding(int id, int tourneyid, int playerid, string playerfirstname, string playerlastname, int wins, int losses, string status, int place)
        {
            Id = id;
            TournamentId = tourneyid;
            PlayerId = playerid;
            PlayerFirstname = playerfirstname;
            PlayerLastname = playerlastname;
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
