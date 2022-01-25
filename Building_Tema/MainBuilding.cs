using System;
using System.Collections.Generic;
using System.Text;

namespace Building_Tema
{
    class MainBuilding
    {
        static void Main(string[] args)
        {
            BuildingTema();
        }

        public static void BuildingTema()
        {
            Room smallWS = new WorkingSpace(2, 4.05f, true, false, 2);
            Room mediumWS = new WorkingSpace(4, 6.3f, false, true, 5);
            Room hugeWS = new WorkingSpace(6, 13.1f, true, true, 10);

            Room smallKtc = new Kitchen(2, 2.1f, true, false, false);
            Room mediumKtc = new Kitchen(4, 4.3f, true, false, true);
            Room hugeKtc = new Kitchen(6, 14.7f, true, true, true);

            Room smallDS = new DepositSpace(1, 2.3f, 2, 0, 2);
            Room mediumDS = new DepositSpace(2, 5.8f, 4, 1, 3);
            Room hugeDS = new DepositSpace(5, 19.9f, 6, 3, 5);

            Room smallMR = new MeetingRoom(4, 3.5f, 4, 1, false, false);
            Room mediumMR = new MeetingRoom(8, 6.1f, 8, 2, false, true);
            Room hugeMR = new MeetingRoom(15, 15.2f, 15, 4, true, true);

            Room[] roomsGroundFloor = {smallMR, mediumWS, hugeKtc, mediumDS, mediumDS, hugeMR, hugeMR};
            Room[] roomsFloor1 = {mediumMR, smallWS, mediumKtc, smallKtc, smallDS};
            Room[] roomsFloor2 = {mediumMR, smallWS, mediumKtc, mediumWS, smallDS, hugeKtc};
            Room[] roomsFloor3 = {hugeMR, mediumWS, smallKtc, smallMR, hugeDS};
            Room[] roomsFloor4 = {hugeMR, hugeWS, smallKtc, smallMR, smallWS, hugeDS, hugeKtc, hugeWS};

            Floor groundFloor = new Floor(roomsGroundFloor, false, true, true);
            Floor floor1 = new Floor(roomsFloor1, false, true, true);
            Floor floor2 = new Floor(roomsFloor2, false, true, true);
            Floor floor3 = new Floor(roomsFloor3, false, true, true);
            Floor floor4 = new Floor(roomsFloor4, false, true, true);

            Floor[] totalFloors = {groundFloor, floor1, floor2, floor3, floor4};

            try
            {
                Building building = new Building(totalFloors, true, true);
                Building.PrintBuilding(building);
            }
            catch (CapacitiException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
