using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.interfaces
{
    public interface IDALMatch
    {
        public bool AddMatches(List<TourneyMatch> matches);
    }
}
