using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Laptimes
    {
        public int RaceId { get; set; }
        public int DriverId { get; set; }
        public int Lap { get; set; }
        public int? Milliseconds { get; set; }
        public int? Position { get; set; }
        public string Time { get; set; }
    }
}
