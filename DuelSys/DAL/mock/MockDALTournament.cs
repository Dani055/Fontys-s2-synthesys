using BusinessLayer.interfaces;
using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.mock
{
    public class MockDALTournament : IDALTournament
    {
        private List<Player> players = new List<Player>()
        {
            new Player(1, "player1", "$MYHASH$V1$10000$vFgylONJFQ6dGLD71J/NxOzF5hRYYOdY9agCHXs7FYUxhllq", "asd@asd.com", "123 avenue", "player", "one", "Player", 0, 0),
            new Player(2, "player2", "$MYHASH$V1$10000$vFgylONJFQ6dGLD71J/NxOzF5hRYYOdY9agCHXs7FYUxhllq", "asd@asd.com", "123 avenue", "player", "two", "Player", 0, 0),
            new Player(3, "player3", "$MYHASH$V1$10000$vFgylONJFQ6dGLD71J/NxOzF5hRYYOdY9agCHXs7FYUxhllq", "asd@asd.com", "123 avenue", "player", "three", "Player", 0, 0),
            new Player(4, "player4", "$MYHASH$V1$10000$vFgylONJFQ6dGLD71J/NxOzF5hRYYOdY9agCHXs7FYUxhllq", "asd@asd.com", "123 avenue", "player", "four", "Player", 0, 0)
        };

        private List<Tournament> tournaments = new List<Tournament>()
        {
             new Tournament(1, "Playoffs", "Badminton", "desc", DateTime.Now.AddDays(8), DateTime.MaxValue, 2, 4, "Eindhoven", "Round-robin", false),
             new Tournament(2, "Ongoning tourney", "Badminton", "ongoing desc", DateTime.Now.AddDays(-1), DateTime.Now.AddDays(3), 3, 4, "Eindhoven", "Round-robin", true),
             new Tournament(3, "Ended tourney", "Badminton", "ended desc", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-1), 4, 4, "Eindhoven", "Round-robin", true),
             new Tournament(4, "Eindhoven annual badminton tourney", "Badminton", "desc", DateTime.Now.AddDays(3), DateTime.Now.AddDays(7), 2, 4, "Eindhoven", "Round-robin", false),
             new Tournament(5, "Too little players to begin", "Badminton", "desc", DateTime.Now.AddDays(3), DateTime.Now.AddDays(7), 2, 4, "Eindhoven", "Round-robin", false),
             new Tournament(6, "Single elimination with players not divisible by 4", "Badminton", "desc", DateTime.Now.AddDays(3), DateTime.Now.AddDays(7), 2, 4, "Eindhoven", "Single-elimination", false),
        };

        private List<TourneyStanding> standings = new List<TourneyStanding>();

        public MockDALTournament()
        {
            standings.Add(new TourneyStanding(1, 1, players[0], 0, 0, "Qualified", 0));
            standings.Add(new TourneyStanding(2, 2, players[0], 0, 0, "Qualified", 0));

            standings.Add(new TourneyStanding(3, 4, players[0], 0, 0, "Qualified", 0));
            standings.Add(new TourneyStanding(4, 4, players[1], 0, 0, "Qualified", 0));
            standings.Add(new TourneyStanding(5, 4, players[2], 0, 0, "Qualified", 0));
            standings.Add(new TourneyStanding(6, 4, players[3], 0, 0, "Qualified", 0));

            standings.Add(new TourneyStanding(7, 6, players[0], 0, 0, "Qualified", 0));
            standings.Add(new TourneyStanding(8, 6, players[1], 0, 0, "Qualified", 0));
            standings.Add(new TourneyStanding(9, 6, players[2], 0, 0, "Qualified", 0));
        }
        
        public bool CreateTournament(Tournament tourney)
        {
            tournaments.Add(tourney);
            return true;
        }

        public bool DeleteTournament(int tourneyId)
        {
            Tournament t = tournaments.FirstOrDefault(x => x.Id == tourneyId);
            if (t == null)
            {
                return false;
            }
            tournaments.Remove(t);
            return true;
        }

        public bool DeregisterPlayerForTournament(int tourneyId, int playerId)
        {
            TourneyStanding s = standings.Find(s => s.TournamentId == tourneyId && s.Player.Id == playerId);
            standings.Remove(s);
            return true;
        }

        public bool EditStandings(List<TourneyStanding> standings)
        {
            return true;
        }

        public bool EditTournament(Tournament tourney)
        {
            Tournament t = tournaments.FirstOrDefault(x => x.Id == tourney.Id);
            if (t == null)
            {
                return false;
            }
            t.Name = tourney.Name;
            t.SportName = tourney.SportName;
            t.Description = tourney.Description;
            t.StartDate = tourney.StartDate;
            t.EndDate = tourney.EndDate;
            t.MinPlayers = tourney.MinPlayers;
            t.MaxPlayers = tourney.MaxPlayers;
            t.Location = tourney.Location;
            t.System = tourney.System;
            t.HasStarted = tourney.HasStarted;
            return true;
        }

        public List<Tournament> GetEndedTournaments()
        {
            return tournaments.Where(x => x.EndDate.Date < DateTime.Now.Date).ToList();
        }

        public List<Tournament> GetOngoingTournaments()
        {
            return tournaments.Where(x => x.StartDate.Date <= DateTime.Now.Date && x.EndDate.Date >= DateTime.Now.Date).ToList();
        }

        public List<Tournament> GetPendingTournaments()
        {
            return tournaments.Where(x => x.StartDate.Date > DateTime.Now.Date).ToList();
        }

        public List<TourneyStanding> GetStandingsForPlayer(int playerId)
        {
            return standings.Where(x => x.Player.Id == playerId).ToList();
        }

        public Tournament GetTournamentById(int id)
        {
            return tournaments.FirstOrDefault(x => x.Id == id);
        }

        public TourneyStanding GetTournamentStanding(int tourneyId, int playerId)
        {
            return standings.FirstOrDefault(x => x.TournamentId == tourneyId && x.Player.Id == playerId);
        }

        public List<TourneyStanding> GetTournamentStandings(int tourneyId)
        {
            return standings.Where(x => x.TournamentId == tourneyId).ToList();
        }

        public bool RegisterPlayerForTournament(int tourneyId, int playerId)
        {
            int nextId = standings[standings.Count - 1].Id + 1;
            Player p = players.Find(p => p.Id == playerId);
            standings.Add(new TourneyStanding(nextId, tourneyId, p, 0, 0, "Qualified", 0));
            return true;
        }

    }
}


