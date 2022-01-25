using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    public class Floor : AbstractBuilding
    {
        private Room[] rooms;
        bool hasBalcony, hasElevator, hasVideoSecurity;

        public Floor(Room[] rooms, bool hasBalcony, bool hasElevator, bool hasVideoCamera)
        {
            this.rooms = rooms;
            this.hasBalcony = hasBalcony;
            this.hasElevator = hasElevator;
            this.hasVideoSecurity = hasVideoCamera;
        }

        public bool HasBalcony { get => hasBalcony; set => hasBalcony = value; }
        public bool HasElevator { get => hasElevator; set => hasElevator = value; }
        public bool HasVideoCamera { get => hasVideoSecurity; set => hasVideoSecurity = value; }

        public override float ComputingArea()
        {
            float area = 0;
            foreach (Room room in rooms)
            {
                area += room.ComputingArea();
            }
            return area;
        }

        public override int TotalCapacity()
        {
            int capacity = 0;
            foreach (Room room in rooms)
            {
                capacity += room.Capacity;
            }
            return capacity;
        }

        public override int GetTotalNumberOfRooms()
        {
            return rooms.Length;
        }

        public void PrintFloor()
        {
            Console.WriteLine("This floor has a number of {0} rooms, has a area of {1} m2 and a capacity for {2} people", GetTotalNumberOfRooms(), ComputingArea(), TotalCapacity());
            if (HasBalcony)
            {
                Console.WriteLine("The floor has a balcony.");
            }
            if (HasElevator)
            {
                Console.WriteLine("The floor has an elevator.");
            }
            if (HasVideoCamera)
            {
                Console.WriteLine("The floor has a video camera.");
            }
            Console.WriteLine("\nThe rooms of the floor are: ");
            foreach (Room room in rooms)
            {
                room.PrintRoom();
            }
        }
    }
}
