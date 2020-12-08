using System.Collections.Generic;
using System.Linq;

namespace TaxiStation
{
    public class Driver
    {
        public List<FeedBack> FeedBacks { get; set; }
        public string Name { get;  }
        public int Experience { get;  }

        public Driver(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }

        public double GetRate()
        {
            return FeedBacks.Average(fee => fee.Rate);
        }
    }
}