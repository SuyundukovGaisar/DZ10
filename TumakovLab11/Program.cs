using System;

namespace TumakovLab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 11.1(создать класс Creator, который будет являться фабрикой объектов класса здания)");
            Building building = Creator.CreateBuild(50, 10, 40, 1);
            building.Print();
            Creator.DeleteBuild(building.BuildingNumber);
        }
    }
}
