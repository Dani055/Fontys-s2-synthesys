using BusinessLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SportName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public string Location  { get; set; }
        public ITournamentSystem System { get; set; }
        public bool HasStarted { get; set; }

        public List<TourneyMatch> matches { get; set; }
        public List<TourneyStanding> standings { get; set; }

        public Tournament()
        {

        }
        public Tournament(int id, string name, string sportname, string description, DateTime startdate, DateTime enddate, int minplayers, int maxplayers, string location, string systemname, bool hasstarted)
        {
            Id = id;
            Name = name;
            SportName = sportname;
            Description = description;
            StartDate = startdate;
            EndDate = enddate;
            MinPlayers = minplayers;
            MaxPlayers = maxplayers;
            Location = location;
            System = Activator.CreateInstance(Type.GetType("BusinessLayer.tournament_systems." + systemname.Replace("-", "_") + "_system"), new object[] { this, systemname }) as ITournamentSystem;
            HasStarted = hasstarted;
        }
    }
}
