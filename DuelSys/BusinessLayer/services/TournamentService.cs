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
    }
}
