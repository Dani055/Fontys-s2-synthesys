using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.services
{
    public class TournamentScheduler
    {
        public List<TourneyMatch> GenerateTournamentMatches(Tournament tourney, List<TourneyStanding> registered)
        {
            if (tourney.SystemName == "Round-robin")
            {
                return GenerateRoundRobinMathes(tourney, registered);
            }
            else if (tourney.SystemName == "Single-elimination")
            {
                //Implement l8er
                return null;
            }
            else
            {
                throw new Exception("Tournament system not recognized!");
            }
        }

        private List<TourneyMatch> GenerateRoundRobinMathes(Tournament tourney, List<TourneyStanding> registered)
        {
            int gamesPerDay = CalculateTourneyGamesPerDay(tourney, registered);
            DateTime startDate = tourney.StartDate;
            DateTime endDate = tourney.EndDate;

            List<TourneyMatch> matches = new List<TourneyMatch>();
            List<DateTime> matchdates = new List<DateTime>();

            DateTime currentDay = startDate;
            int gamesToday = 0;

            for (int i = 0; i < registered.Count; i++)
            {
                for (int j = 0; j < registered.Count; j++)
                {
                    int player1id = registered[i].PlayerId;
                    int player2id = registered[j].PlayerId;

                    if (player1id != player2id)
                    {
                        //LINQ to find if a match already exists between 2 players
                        TourneyMatch foundmatch = matches.Find(m => (m.Player1id == player1id && m.Player2id == player2id) || (m.Player1id == player2id && m.Player2id == player1id));
                        if (foundmatch != null)
                        {
                            continue;
                        }

                        //At this point a match will exist, for now the time is not known 
                        TourneyMatch match = new TourneyMatch()
                        {
                            Player1id = player1id,
                            Player2id = player2id,
                            DateHeld = DateTime.MinValue,
                            TournamentId = tourney.Id,
                        };
                        //Create a time slot for a match: 8:00 - 20:00
                        DateTime matchdate = currentDay.Date.AddHours(8 + (2 * gamesToday));

                        matchdates.Add(matchdate);
                        matches.Add(match);
                        gamesToday++;

                        if (gamesToday >= gamesPerDay)
                        {
                            gamesToday = 0;
                            currentDay = currentDay.AddDays(1);
                        }
                    }
                }
            }

            //Shuffle match dates to determine who plays when
            matchdates = matchdates.OrderBy(m => Guid.NewGuid()).ToList();

            for (int i = 0; i < matches.Count; i++)
            {
                matches[i].DateHeld = matchdates[i];
            }
            return matches;

        }
        private int CalculateTourneyGamesPerDay(Tournament tourney, List<TourneyStanding> registered)
        {
            int maxplayers = registered.Count;
            int daysForTournament = (tourney.EndDate.Date - tourney.StartDate.Date).Days + 1;
            int gamesToBePlayed = 0;

            if (tourney.SystemName == "Round-robin")
            {
                for (int i = 1; i < maxplayers; i++)
                {
                    gamesToBePlayed += maxplayers - i;
                }

            }
            else if (tourney.SystemName == "Single-elimination")
            {
                gamesToBePlayed = maxplayers - 1;
            }

            int gamesPerDay = (int)Math.Ceiling((double)gamesToBePlayed / (double)daysForTournament);

            return gamesPerDay;
        }
    }
}
