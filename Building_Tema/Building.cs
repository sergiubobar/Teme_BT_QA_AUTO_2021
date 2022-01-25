using System;
using System.Collections.Generic;

namespace Building_Tema
{
    public class Building : AbstractBuilding
    {
        const int MAX_CAPACITY = 300;
        private Floor[] floors;
        bool hasElevator, hasVideoSecurity;

        public Building(Floor[] floors, bool hasElevator, bool hasVideoSecurity)
        {
            this.floors = floors;
            this.hasElevator = hasElevator;
            this.hasVideoSecurity = hasVideoSecurity;

            if (this.TotalCapacity() > MAX_CAPACITY)
            {
                throw new CapacitiException("You have reached the maximum capacity of the building. No more space left!");
            }
        }

        public bool HasElevator { get => hasElevator; set => hasElevator = value; }
        public bool HasVideoSecurity { get => hasVideoSecurity; set => hasVideoSecurity = value; }

        public override float ComputingArea()
        {
            float area = 0;
            foreach (Floor floor in floors)
            {
                area += floor.ComputingArea();
            }
            return area;
        }

        public override int GetNumberOfFloors()
        {
            return this.floors.Length;
        }

        public override int GetTotalNumberOfRooms()
        {
            int totalNumberOfRooms = 0;
            foreach (Floor floor in floors)
            {
                totalNumberOfRooms += floor.GetTotalNumberOfRooms();
            }
            return totalNumberOfRooms;
        }

        public override int TotalCapacity()
        {
            int capacity = 0;
            foreach (Floor floor in floors)
            {
                capacity += floor.TotalCapacity();
            }
            return capacity;
        }

        public static void PrintBuilding(Building building)
        {
            Console.WriteLine("\n***********************************BUILDING*********************************************" +
                "\n\nThe building has {0} floors, {1} rooms, an area of {2} and a capacity of {3} people.\n",
                building.GetNumberOfFloors(),
                building.GetTotalNumberOfRooms(),
                building.ComputingArea(),
                building.TotalCapacity());

            if (building.HasElevator)
            {
                Console.WriteLine("The building also has an elevator to facilitate the floor to floor movement.");
            }
            if (building.HasVideoSecurity)
            {
                Console.WriteLine("The building also has a video sistem to improve the security in case of a robbery");
            }
            for (int i = 0; i < building.floors.Length; i++)
            {
                Console.Write("\n<<<<><<<<<<<<<<<<<<><<<<<<<<<<<<<<<<FLOOR>>>>>>>>>>>>>>>><>>>>>>>>>>>>>>>>>>>>>>>><>>>>>>" +
                    "\n<<.>> Floor number " + i + ": \n");
                building.floors[i].PrintFloor();
            }
        }
    }
}