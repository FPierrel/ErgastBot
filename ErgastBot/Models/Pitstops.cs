using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Pitstops
    {
        public int RaceId { get; set; }
        public int DriverId { get; set; }
        public int Stop { get; set; }
        public string Duration { get; set; }
        public int Lap { get; set; }
        public int? Milliseconds { get; set; }
        public TimeSpan Time { get; set; }
    }
}
