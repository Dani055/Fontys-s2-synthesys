using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class DBEnums
    {
        public static string[] Roles { get; } = { "", "Staff", "Player" };
        public static string[] Sports { get; } = { "", "Badminton"};
        public static string[] TournamentSystems { get; } = { "", "Round-robin" ,"Single-elimination"};
    }
}
