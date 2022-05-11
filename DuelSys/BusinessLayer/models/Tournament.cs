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
        public string SystemName { get; set; }
        public bool HasStarted { get; set; }

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
            SystemName = systemname;
            HasStarted = hasstarted;
        }
    }
}
