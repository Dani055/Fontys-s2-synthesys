using BusinessLayer.interfaces;
using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.mock
{
    public class MockDALMatch : IDALMatch
    {
        private List<Player> players = new List<Player>()
        {
            new Player(1, "player1", "$MYHASH$V1$10000$vFgylONJFQ6dGLD71J/NxOzF5hRYYOdY9agCHXs7FYUxhllq", "asd@asd.com", "123 avenue", "player", "one", "Player", 0, 0),
            new Player(2, "player2", "$MYHASH$V1$10000$vFgylONJFQ6dGLD71J/NxOzF5hRYYOdY9agCHXs7FYUxhllq", "asd@asd.com", "123 avenue", "player", "two", "Player", 0, 0)
        };

        private List<TourneyMatch> matches = new List<TourneyMatch>()
        {
            
        };
        public MockDALMatch()
        {
            matches.Add(new TourneyMatch(1, 4, DateTime.Now, players[0], 21, players[1], 15, 0));
        }
        public bool AddMatches(List<TourneyMatch> matches)
        {
            this.matches.AddRange(matches);
            return true;
        }

        public bool EnterMatchScore(Tournament tourney, TourneyMatch match)
        {
            TourneyMatch foundMatch = matches.Find(m => m.Id == match.Id);
            foundMatch.Player1Points = match.Player1Points;
            foundMatch.Player2Points = match.Player2Points;
            foundMatch.WinnerId = match.WinnerId;

            return true;
        }

        public List<TourneyMatch> GetMatches(int tourneyId)
        {
            return matches.Where(x => x.TournamentId == tourneyId).ToList();
        }

        public List<TourneyMatch> GetPlayerMatches(int playerId)
        {
            return matches.Where(x => x.Player1.Id == playerId || x.Player2.Id == playerId).ToList();
        }
    }
}
