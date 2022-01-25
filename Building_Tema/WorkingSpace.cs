using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    class WorkingSpace : Room
    {
        bool hasLaptop, hasPC;
        int stereoSpeakers;

        public WorkingSpace(int capacity, float area, bool hasLaptop, bool hasPC, int stereoSpeakers) : base(capacity, area)
        {
            this.hasLaptop = hasLaptop;
            this.hasPC = hasPC;
            this.stereoSpeakers = stereoSpeakers;
        }

        public bool HasLaptop { get => hasLaptop; set => hasLaptop = value; }
        public bool HasPC { get => hasPC; set => hasPC = value; }
        public int StereoSpeakers { get => stereoSpeakers; set => stereoSpeakers = value; }

        public override void PrintRoom()
        {
            Console.WriteLine("--- Working Space ---\nThis working space has an area of {0}  m^2 and it has a capacity of {1} people.", Capacity, Area);
            if (StereoSpeakers > 0)
            {
                Console.WriteLine("This working space also has {0} stereo peakers.");
            }
            if (HasLaptop)
            {
                Console.WriteLine("This working space also has a Laptop.");
            }
            if (HasPC)
            {
                Console.WriteLine("This working space also has a Personal Computer.");
            }
        }
    }
}
