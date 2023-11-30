using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab11
{
    internal class Creator
    {
        static Hashtable buildings = new Hashtable();
        public static Building CreateBuild()
        {
            Building building = new Building();
            buildings.Add(building.BuildingNumber, building);
            return building;
        }
        public static Building CreateBuild(int height, int floors)
        {
            Building building = new Building(height, floors);
            buildings.Add(building.BuildingNumber, building);
            return building;
        }

        public static Building CreateBuild(int height, int floors, int floats, int entrances)
        {
            Building building = new Building(height, floors, floats, entrances);
            buildings.Add(building.BuildingNumber, building);
            return building;
        }

        public static Building CreateBuild(int height, int floors, int floats, int entrances, int heightFloor, int floatsEntrance, int floatsFloor)
        {
            Building building = new Building(height, floors, floats, entrances, heightFloor, floatsEntrance, floatsFloor);
            buildings.Add(building.BuildingNumber, building);
            return building;
        }

        public static void DeleteBuild(int buildingNumber)
        {
            if (buildings.ContainsKey(buildingNumber))
            {
                buildings.Remove(buildingNumber);
            }
        }

    }
}
