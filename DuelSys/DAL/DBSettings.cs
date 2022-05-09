using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBSettings
    {
        private string conString = "server=studmysql01.fhict.local;database=dbi476740;uid=dbi476740;password=123rty;";
        public string DateTimeFormat { get; } = "yyyy-MM-dd HH:mm:ss";
        public string GetConString()
        {
            return conString;
        }
    }
}
