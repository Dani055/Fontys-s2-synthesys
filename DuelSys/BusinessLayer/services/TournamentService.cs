using BusinessLayer.interfaces;
using BusinessLayer.models;
using BusinessLayer.validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.services
{
    public class TournamentService
    {
        private readonly IDALTournament _dalTournament;
        private readonly TournamentValidator _tournamentValidator;

        public TournamentService(IDALTournament dalTournament, TournamentValidator tournamentValidator)
        {
            _dalTournament = dalTournament;
            _tournamentValidator = tournamentValidator;
        }

        public bool CreateTournament(Tournament tourney, User loggedUser)
        {
            if (!loggedUser.Role.CanAccessTournamentCUD())
            {
                throw new Exception("You are not authorized to create a tournament!");
            }
            _tournamentValidator.ValidateTournament(tourney);

            return _dalTournament.CreateTournament(tourney);

        }
        
        public bool EditTournament(Tournament tourney, User loggedUser)
        {
            if (!loggedUser.Role.CanAccessTournamentCUD())
            {
                throw new Exception("You are not authorized to edit a tournament!");
            }
            else if (_tournamentValidator.CheckIfTournamentBeginsInOneWeek(tourney))
            {
                throw new Exception("Tournament cannot be edited because it begins in less than one week");
            }
            _tournamentValidator.ValidateTournament(tourney);

            return _dalTournament.EditTournament(tourney);

        }
        public bool DeleteTournament(int id, User loggedUser)
        {
            if (!loggedUser.Role.CanAccessTournamentCUD())
            {
                throw new Exception("You are not authorized to delete a tournament!");
            }
            return _dalTournament.DeleteTournament(id);
        }

        public Tournament GetTournamentById(int id)
        {
            return _dalTournament.GetTournamentById(id);
        }

        public List<Tournament> GetTournaments(string status)
        {
            if (status == "Pending")
            {
                return _dalTournament.GetPendingTournaments();
            }
            else if (status == "Ongoing")
            {
                return _dalTournament.GetOngoingTournaments();
            }
            else
            {
                return _dalTournament.GetEndedTournaments();
            }
        }
        public bool RegisterPlayerForTournament(int tournamentId, int playerId)
        {
            Tournament tourney = _dalTournament.GetTournamentById(tournamentId);

            TourneyStanding ts = _dalTournament.GetTournamentStanding(tourney.Id, playerId);
            if (_tournamentValidator.CheckIfTournamentBeginsInOneWeek(tourney))
            {
                throw new Exception("Register unsuccessful. Tournament starts in less than 1 week.");
            }
            else if (ts != null)
            {
                throw new Exception("You are already registered for this tournament!");
            }
            //Query checks if the maximum players are more than the current registered. This prevents SOME concurrency
            else
            {
                return _dalTournament.RegisterPlayerForTournament(tourney.Id, playerId);
            }

        }
        public bool DeregisterPlayerForTournament(int tournamentId, int playerId)
        {
            Tournament tourney = _dalTournament.GetTournamentById(tournamentId);

            TourneyStanding ts = _dalTournament.GetTournamentStanding(tourney.Id, playerId);
            if (ts == null)
            {
                throw new Exception("You are not registered for this tournament!");
            }
            else if (_tournamentValidator.CheckIfTournamentBeginsInOneWeek(tourney))
            {
                throw new Exception("Deregister unsuccessful. Tournament starts in less than 1 week.");
            }
            else
            {
                return _dalTournament.DeregisterPlayerForTournament(tournamentId, playerId);
            }
        }
        public List<TourneyStanding> GetTournamentStandings(int tourneyId)
        {
            return _dalTournament.GetTournamentStandings(tourneyId);
        }
        public bool ConcludeTournamentAndRankPlayers(int tourneyId, User loggedUser)
        {
            if (!loggedUser.Role.CanAccessTournamentCUD())
            {
                throw new Exception("You are not authorized to conclude a tournament!");
            }
            Tournament tourney = _dalTournament.GetTournamentById(tourneyId);
            if (tourney.EndDate >= Utils.GetSystemDate)
            {
                throw new Exception("This tournament has not ended yet");
            }
            List<TourneyStanding> standings = _dalTournament.GetTournamentStandings(tourneyId);
            
            standings = standings.OrderByDescending(x => x.Wins).ThenBy(x => x.Losses).ToList();

            for (int i = 0; i < standings.Count; i++)
            {
                standings[i].Place = i + 1;
            }

            return _dalTournament.EditStandings(standings);
        }
    }
}
