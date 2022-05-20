using BusinessLayer.interfaces;
using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.validators
{
    public class TournamentValidator
    {
        public bool ValidateTournament(Tournament tourney)
        {
            if (String.IsNullOrEmpty(tourney.Name))
            {
                throw new Exception("You must enter a tournament name!");
            }
            else if (String.IsNullOrEmpty(tourney.SportName))
            {
                throw new Exception("You must select a sport for the tournament!");
            }
            else if (String.IsNullOrEmpty(tourney.Description))
            {
                throw new Exception("You must enter a tournament description!");
            }
            else if (tourney.StartDate >= tourney.EndDate || tourney.StartDate.Date.AddDays(-7) <= Utils.GetSystemDate.Date)
            {
                throw new Exception("Invalid starting/ending dates. Make sure the tournament starts in at least 1 week and the start date is not bigger than the end date.");
            }
            else if (tourney.MinPlayers < 2 || tourney.MaxPlayers < 2)
            {
                throw new Exception("Min. and max players must be at least 2");
            }
            else if (String.IsNullOrEmpty(tourney.Location))
            {
                throw new Exception("You must enter a tournament location!");
            }
            else if (String.IsNullOrEmpty(tourney.SystemName))
            {
                throw new Exception("You must select a system for the tournament!");
            }
            else if (tourney.SystemName == "Single-elimination")
            {
                if (tourney.MinPlayers % 4 != 0 || tourney.MaxPlayers % 4 != 0)
                {
                    throw new Exception("You have selected a Single-elimination tournament system. For it to work the amount of participants must be dividable by 4.");
                }
            }
            int gamesPerDay = CalculateTourneyGamesPerDay(tourney);
            if (gamesPerDay > 6)
            {
                throw new Exception($"The selected time span for the tournament is too short to host all required games. Max. games per day: 6 | Required: {gamesPerDay} Consider extending the tournament deadline.");
            }
            return true;

        }
        public bool CheckIfTournamentBeginsInOneWeek(Tournament tourney)
        {
            if (Utils.GetSystemDate >= tourney.StartDate.AddDays(-7))
            {
                return true;
            }
            return false;
        }
        private int CalculateTourneyGamesPerDay(Tournament tourney)
        {
            int maxplayers = Math.Max(tourney.MinPlayers, tourney.MaxPlayers);
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

            int gamesPerDay =  (int)Math.Ceiling((double)gamesToBePlayed / (double)daysForTournament);

            return gamesPerDay;
        }
    }
}
