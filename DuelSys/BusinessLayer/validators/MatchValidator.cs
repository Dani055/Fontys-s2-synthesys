using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.validators
{
    public class MatchValidator
    {
        public int DetermineWinner(TourneyMatch match)
        {
            if (match.Player1id == 0 || match.Player2id == 0)
            {
                throw new Exception("Cannot enter result. The players for this game are not yet decided!");
            }
            else if (match.Player1Points <= 20 && match.Player2Points <= 20)
            {
                throw new Exception("A player needs at least 21 points to win!");
            }
            else
            {
                if ((match.Player1Points == 29 && match.Player2Points != 30) || (match.Player2Points == 29 && match.Player1Points != 30))
                {
                    throw new Exception("At 29-29, the side scoring the 30th point wins the game");
                }
                if (Math.Abs(match.Player1Points - match.Player2Points) < 2)
                {
                    throw new Exception("A player needs to lead by at least 2 points to win!");
                }
            }

            if (match.Player1Points > match.Player2Points)
            {
                return match.Player1id;
            }
            else
            {
                return match.Player2id;
            }
        }
    }
}
