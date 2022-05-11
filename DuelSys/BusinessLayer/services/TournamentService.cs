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
        public bool RegisterPlayerForTournament(int tourneyId, int playerId)
        {
            TourneyStanding ts = _dalTournament.GetTournamentStanding(tourneyId, playerId);
            if (ts != null)
            {
                throw new Exception("You are already registered for this tournament!");
            }
            else
            {
                return _dalTournament.RegisterPlayerForTournament(tourneyId, playerId);
            }

        }
    }
}
