using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Circuits
    {
        public int CircuitId { get; set; }
        public int? Alt { get; set; }
        public string CircuitRef { get; set; }
        public string Country { get; set; }
        public float? Lat { get; set; }
        public float? Lng { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
