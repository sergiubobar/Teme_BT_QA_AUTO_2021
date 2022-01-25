using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    class MeetingRoom : Room
    {
        int chairs, tables;
        bool hasTV, hasAirConditioner;

        public MeetingRoom(int capacity, float area, int chairs, int tables, bool hasTV, bool hasAirConditioner) : base(capacity, area)
        {
            this.chairs = chairs;
            this.tables = tables;
            this.hasTV = hasTV;
            this.hasAirConditioner = hasAirConditioner;
        }

        public int Chairs { get => chairs; set => chairs = value; }
        public int Tables { get => tables; set => tables = value; }
        public bool HasTV { get => hasTV; set => hasTV = value; }
        public bool HasAirConditioner { get => hasAirConditioner; set => hasAirConditioner = value; }

        public override void PrintRoom()
        {
            Console.WriteLine("--- Meeting Room ---\nThis meeting room has an area of {0}  m^2 and it has a capacity of {1} people.", Capacity, Area);
            if (Chairs > 0)
            {
                Console.WriteLine("This meeting room also has {0} chairs.");
            }
            if (Tables > 0)
            {
                Console.WriteLine("This dmeeting room also has {0} tables.");
            }
            if (HasTV)
            {
                Console.WriteLine("This meeting room also has TV.");
            }
            if (HasAirConditioner)
            {
                Console.WriteLine("This meeting room also has air conditioner.");
            }
        }
    }
}
