using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    public class Room : AbstractBuilding
    {
        int capacity;
        float area;

        public Room(int capacity, float area)
        {
            this.capacity = capacity;
            this.area = area;
        }

        public int Capacity { get => capacity; set => capacity = value; }
        public float Area { get => area; set => area = value; }

        public override float ComputingArea()
        {
            return Area;
        }

        public virtual void PrintRoom()
        {
            Console.WriteLine("This room has an area of {0} m^2 and it has a capacity of {1} people.", Capacity, Area);
        }
    }
}
