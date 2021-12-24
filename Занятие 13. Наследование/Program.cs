using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Занятие_13.Наследование
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные по зданию:");
            Console.Write("\nАдрес: ");
            string address = Console.ReadLine();
            Console.Write("Длина: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ширина: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество этажей: ");
            int numberOfFloors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Building b = new Building(address, length, width, height);
            Console.Write("Вывод данных класса Building: \n");
            b.Print();
            Console.WriteLine();

            MultiBuilding mb = new MultiBuilding(address, length, width, height, numberOfFloors);
            Console.Write("Вывод данных класса MultiBuilding: \n");
            mb.Print();
            Console.WriteLine();
            Console.ReadKey();

        }

    }

}
