using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Constructorresults
    {
        public int ConstructorResultsId { get; set; }
        public int ConstructorId { get; set; }
        public float? Points { get; set; }
        public int RaceId { get; set; }
        public string Status { get; set; }
    }
}
