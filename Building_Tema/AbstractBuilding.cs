using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    public abstract class AbstractBuilding : IBuilding
    {
        public virtual float ComputingArea()
        {
            return 0;
        }

        public virtual int GetNumberOfFloors()
        {
            return 0;
        }

        public virtual int GetTotalNumberOfRooms()
        {
            return 0;
        }

        public virtual int TotalCapacity()
        {
            return 0;
        }
    }
}
