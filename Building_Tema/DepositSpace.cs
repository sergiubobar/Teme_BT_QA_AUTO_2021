using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    class DepositSpace : Room 
    {
        int boxes, closets, shelves;

        public DepositSpace(int capacity, float area, int boxes, int closets, int shelves) : base(capacity, area)
        {
            this.boxes = boxes;
            this.closets = closets;
            this.shelves = shelves;
        }

        public int Boxes { get => boxes; set => boxes = value; }
        public int Closets { get => closets; set => closets = value; }
        public int Shelves { get => shelves; set => shelves = value; }

        public override void PrintRoom()
        {
            Console.WriteLine("--- Deposit Space --- \nThis deposit space has an area of {0} m^2 and it has a capacity of {1} people.", Capacity, Area);
            if(boxes > 0)
            {
                Console.WriteLine("This deposit space also has {0} boxes of stuff.");
            } 
            if(closets > 0)
            {
                Console.WriteLine("This deposit space also has {0} closets full of stuff.");
            }
            if (shelves > 0)
            {
                Console.WriteLine("This deposit space also has {0} shelves full of stuff.");
            }
        }
    }
}
