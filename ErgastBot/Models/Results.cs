using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Results
    {
        public int ResultId { get; set; }
        public int ConstructorId { get; set; }
        public int DriverId { get; set; }
        public int? FastestLap { get; set; }
        public string FastestLapSpeed { get; set; }
        public string FastestLapTime { get; set; }
        public int Grid { get; set; }
        public int Laps { get; set; }
        public int? Milliseconds { get; set; }
        public int? Number { get; set; }
        public float Points { get; set; }
        public int? Position { get; set; }
        public int PositionOrder { get; set; }
        public string PositionText { get; set; }
        public int RaceId { get; set; }
        public int? Rank { get; set; }
        public int StatusId { get; set; }
        public string Time { get; set; }
    }
}
