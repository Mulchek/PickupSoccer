using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PickupSoccer.Models
{
    public class Game
    {
        private DateTime time;
        private string location;

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public Game(DateTime Time, string Location)
        {
            this.Time = Time;
            this.Location = Location;
        }

    }
}