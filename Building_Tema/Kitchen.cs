using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    class Kitchen : Room
    {
        bool hasRefrigerator, hasOven, hasSink;

        public Kitchen(int capacity, float area, bool hasRefrigerator, bool hasOven, bool hasSink) : base(capacity, area)
        {
            this.hasRefrigerator = hasRefrigerator;
            this.hasOven = hasOven;
            this.hasSink = hasSink;
        }

        public bool HasRefrigerator { get => hasRefrigerator; set => hasRefrigerator = value; }
        public bool HasOven { get => hasOven; set => hasOven = value; }
        public bool HasSink { get => hasSink; set => hasSink = value; }

        public override void PrintRoom()
        {
            Console.WriteLine("----  KITCHEN  ----\nThis kitchen has an area of {0} m^2 and it has a capacity of {1} people.", Capacity, Area);
            if (HasRefrigerator)
            {
                Console.WriteLine("This kitchen also has a refrigerator.");
            }
            if (HasOven)
            {
                Console.WriteLine("This kitchen also has a oven.");
            }
            if (HasSink)
            {
                Console.WriteLine("This kitchen also has a sink.");
            }
        }
    }
}
