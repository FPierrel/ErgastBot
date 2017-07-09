using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Races
    {
        public int RaceId { get; set; }
        public int CircuitId { get; set; }
        public string Name { get; set; }
        public int Round { get; set; }
        public TimeSpan? Time { get; set; }
        public string Url { get; set; }
        public int Year { get; set; }
    }
}
