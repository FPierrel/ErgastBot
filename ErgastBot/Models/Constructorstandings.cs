using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Constructorstandings
    {
        public int ConstructorStandingsId { get; set; }
        public int ConstructorId { get; set; }
        public float Points { get; set; }
        public int? Position { get; set; }
        public string PositionText { get; set; }
        public int RaceId { get; set; }
        public int Wins { get; set; }
    }
}
