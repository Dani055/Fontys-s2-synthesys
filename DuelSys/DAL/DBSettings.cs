using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBSettings
    {
        private string conString = "Your connection string here";
        public string DateTimeFormat { get; } = "yyyy-MM-dd HH:mm:ss";
        public string GetConString()
        {
            return conString;
        }
    }
}
