using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Driverstandings
    {
        public int DriverStandingsId { get; set; }
        public int DriverId { get; set; }
        public float Points { get; set; }
        public int? Position { get; set; }
        public string PositionText { get; set; }
        public int RaceId { get; set; }
        public int Wins { get; set; }
    }
}
