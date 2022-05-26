using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.models
{
    public class TourneyMatch
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public DateTime DateHeld { get; set; }

        public Player Player1 { get; set; }

        public int Player1Points { get; set; }

        public Player Player2 { get; set; }

        public int Player2Points { get; set; }
        public int WinnerId { get; set; }


        public TourneyMatch()
        {

        }
        public TourneyMatch(int id, int tournamentId, DateTime dateheld, Player player1, int player1points, Player player2, int player2points, int winnerid)
        {
            Id = id;
            TournamentId = tournamentId;
            DateHeld = dateheld;

            Player1 = player1;

            Player1Points = player1points;

            Player2 = player2;

            Player2Points = player2points;

            WinnerId = winnerid;
        }

    }
}
