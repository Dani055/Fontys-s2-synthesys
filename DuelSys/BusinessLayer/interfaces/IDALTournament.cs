using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.interfaces
{
    public interface IDALTournament
    {
        public bool CreateTournament(Tournament tourney);
        public Tournament GetTournamentById(int id);

        public List<Tournament> GetPendingTournaments();
        public List<Tournament> GetOngoingTournaments();
        public List<Tournament> GetEndedTournaments();
        public bool RegisterPlayerForTournament(int tourneyId, int playerId);

        public TourneyStanding GetTournamentStanding(int tourneyId, int playerId);
    }
}
