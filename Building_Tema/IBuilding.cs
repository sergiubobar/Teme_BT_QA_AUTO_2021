using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    interface IBuilding
    {
        float ComputingArea();

        int GetNumberOfFloors();

        int GetTotalNumberOfRooms();

        int TotalCapacity();
    }
}
