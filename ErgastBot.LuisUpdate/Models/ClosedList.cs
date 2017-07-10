using System;
using System.Collections.Generic;
using System.Text;

namespace ErgastBot.LuisUpdate.Models
{
    class ClosedList
    {
        public string Name { get; set; }
        public List<Entity> Sublists { get; set; }
    }
}
