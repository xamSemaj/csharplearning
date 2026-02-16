using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.stringExtensions
{
    public static class SeasonExtensions
    {
        public static Season Next(this Season season)
        {
            int seasonAsInt = (int)season;
            int nextSeason = (seasonAsInt + 1) % 4;
            return (Season)nextSeason;
        }
    }
   
}

