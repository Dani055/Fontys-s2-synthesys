using BusinessLayer.interfaces;
using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.tournament_systems
{
    public class Single_elimination_system : ITournamentSystem
    {
        private Tournament tourney;
        public string SystemName { get; set; }

        public Single_elimination_system(Tournament t, string systemname)
        {
            tourney = t;
            SystemName = systemname;
        }

        public List<TourneyMatch> GenerateTournamentMatches()
        {
            int gamesPerDay = CalculateGamesPerDay(tourney.standings);
            DateTime startDate = tourney.StartDate;

            List<TourneyMatch> matches = new List<TourneyMatch>();

            DateTime currentDay = startDate;
            int gamesToday = 0;

            //Generate pre-determined matches
            for (int i = 0; i < tourney.standings.Count; i += 2)
            {
                TourneyMatch match = new TourneyMatch()
                {
                    Player1 = tourney.standings[i].Player,
                    Player2 = tourney.standings[i + 1].Player,
                    DateHeld = currentDay.Date.AddHours(8 + (2 * gamesToday)),
                    TournamentId = tourney.Id,
                };

                matches.Add(match);
                gamesToday++;
                if (gamesToday >= gamesPerDay)
                {
                    gamesToday = 0;
                    currentDay = currentDay.AddDays(1);
                }
            }

            //Generate empty matches for people to move into later on
            for (int i = 0; i < tourney.standings.Count - 1 - matches.Count; i++)
            {
                TourneyMatch match = new TourneyMatch()
                {
                    Player1 = new Player(){Id = 0},
                    Player2 = new Player() { Id = 0 },
                    DateHeld = currentDay.Date.AddHours(8 + (2 * gamesToday)),
                    TournamentId = tourney.Id,
                };
                matches.Add(match);
                if (gamesToday >= gamesPerDay)
                {
                    gamesToday = 0;
                    currentDay = currentDay.AddDays(1);
                }
            }

            return matches;
        }
        public int CalculateGamesPerDay(List<TourneyStanding> registered)
        {
            int maxplayers = registered.Count;
            int daysForTournament = (tourney.EndDate.Date - tourney.StartDate.Date).Days + 1;
            int gamesToBePlayed = 0;

            gamesToBePlayed = maxplayers - 1;

            int gamesPerDay = (int)Math.Ceiling((double)gamesToBePlayed / (double)daysForTournament);

            return gamesPerDay;
        }
    }
}
