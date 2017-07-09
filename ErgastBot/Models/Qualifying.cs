using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Qualifying
    {
        public int QualifyId { get; set; }
        public int ConstructorId { get; set; }
        public int DriverId { get; set; }
        public int Number { get; set; }
        public int? Position { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public int RaceId { get; set; }
    }
}
