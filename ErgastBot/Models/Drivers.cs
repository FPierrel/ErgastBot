using System;
using System.Collections.Generic;

namespace ErgastBot.Data
{
    public partial class Drivers
    {
        public int DriverId { get; set; }
        public string Code { get; set; }
        public string DriverRef { get; set; }
        public string Forename { get; set; }
        public string Nationality { get; set; }
        public int? Number { get; set; }
        public string Surname { get; set; }
        public string Url { get; set; }
    }
}
