using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab11
{
    internal class Building
    {
        public static int nextBuildingNumber;
        public int BuildingNumber;
        public int Height;
        public int Floors;
        public int Floats;
        public int entrances;
        public int HeightFloor;
        public int FloatsEntrance;
        public int FloatsFloor;

        internal Building()
        {
            BuildingNumber = NextBuildingNumber();
        }
        internal Building(int height, int floors)
        {
            BuildingNumber = NextBuildingNumber();
            Height = height;
            Floors = floors;
        }
        internal Building(int height, int floors, int floats, int entrances)
        {
            BuildingNumber = NextBuildingNumber();
            Height = height;
            Floors = floors;
            Floats = floats;
            this.entrances = entrances;
        }
        internal Building(int height, int floors, int floats, int entrances, int heightFloor, int floatsEntrance, int floatsFloor)
        {
            BuildingNumber = NextBuildingNumber();
            Height = height;
            Floors = floors;
            Floats = floats;
            this.entrances = entrances;
            HeightFloor = heightFloor;
            FloatsEntrance = floatsEntrance;
            FloatsFloor = floatsFloor;
        }

        public int GenerateBuildingNumber()
        {
            Random random = new Random();
            nextBuildingNumber = random.Next();
            return nextBuildingNumber;
        }

        public static int NextBuildingNumber()
        {
            return ++nextBuildingNumber;
        }
        public void Print()
        {
            Console.WriteLine($"Номер здания: {BuildingNumber}");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Кол-во этажей: {Floors}");
            Console.WriteLine($"Кол-во квартир: {Floats}");
            Console.WriteLine($"Кол-во подъездов: {entrances}");
            Console.WriteLine($"Следующий номер здания: {nextBuildingNumber = NextBuildingNumber()}");
        }
        public void CalculateHeightFloor()
        {
            HeightFloor = Height / Floors;
        }

        public void CalculateFloatsEntrance()
        {
            FloatsEntrance = Floats / entrances;
        }

        public void CalculateFloatsFloor()
        {
            FloatsFloor = Floats / Floors;
        }
        public void PrintCalculaions()
        {
            Console.WriteLine($"Высота этажа: {HeightFloor}");
            Console.WriteLine($"Кол-во квартир в подъезде: {FloatsEntrance}");
            Console.WriteLine($"Кол-во квартир на этаже: {FloatsFloor}");
        }
    }
}
