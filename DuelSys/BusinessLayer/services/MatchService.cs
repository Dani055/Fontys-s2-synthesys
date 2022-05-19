﻿using BusinessLayer.interfaces;
using BusinessLayer.validators;
using BusinessLayer.models;

namespace BusinessLayer.services
{
    public class MatchService
    {
        private readonly IDALTournament _dalTournament;
        private readonly IDALMatch _dalMatch;
        private readonly TournamentValidator _tournamentValidator;
        private readonly TournamentScheduler _tournamentScheduler;
        private readonly MatchValidator _matchValidator;

        public MatchService(IDALTournament dalTournament,IDALMatch dalMatch, TournamentValidator tournamentValidator, TournamentScheduler tournamentScheduler, MatchValidator matchValidator)
        {
            _dalTournament = dalTournament;
            _dalMatch = dalMatch;
            _tournamentValidator = tournamentValidator;
            _tournamentScheduler = tournamentScheduler;
            _matchValidator = matchValidator;
        }
        public bool ScheduleTournament(int tournamentId, User loggedUser)
        {
            Tournament tourney = _dalTournament.GetTournamentById(tournamentId);
            if (!loggedUser.Role.CanAccessTournamentCUD())
            {
                throw new Exception("You are not authorized to schedule a tournament!");
            }
            if (!_tournamentValidator.CheckIfTournamentBeginsInOneWeek(tourney))
            {
                throw new Exception("Tournament must begin in 7 days in order to generate schedule!");
            }
            if (tourney.HasStarted)
            {
                throw new Exception("This tournament has already been scheduled!");
            }
            tourney.HasStarted = true;
            _dalTournament.EditTournament(tourney);

            List<TourneyStanding> registered = _dalTournament.GetTournamentStandings(tournamentId);
            if (registered.Count < tourney.MinPlayers)
            {

                throw new Exception("Tournament has not reached minimum players and will NOT be scheduled");
            }
            else
            {
                if (tourney.SystemName == "Single-elimination" && registered.Count % 4 != 0)
                {
                    throw new Exception("This is an elimination tournament and the registered players are not dividable by 4. Tournament will NOT be scheduled.");
                }
            }

            List<TourneyMatch> matches = _tournamentScheduler.GenerateTournamentMatches(tourney, registered);

            return _dalMatch.AddMatches(matches);
        }

        public List<TourneyMatch> GetMatches(int tourneyId)
        {
            return _dalMatch.GetMatches(tourneyId);
        }
        public List<TourneyMatch> GetMyMatches(int playerId)
        {
            return _dalMatch.GetPlayerMatches(playerId);
        }
        public bool EnterMatchResult(TourneyMatch match, User loggedUser)
        {
            if (!loggedUser.Role.CanAccessMatchCUD())
            {
                throw new Exception("You are not authorized to enter a match result!");
            }
            else if (match.DateHeld.Date > Utils.GetSystemDate.Date)
            {
                throw new Exception("This game has not been played yet!");
            }
            else if (match.WinnerId != 0)
            {
                throw new Exception("The results of this game have already been entered!");
            }
            int winnerId = _matchValidator.DetermineWinner(match);
            Tournament tourney = _dalTournament.GetTournamentById(match.TournamentId);

            match.WinnerId = winnerId;

            return _dalMatch.EnterMatchScore(tourney, match);
        }
    }
}
