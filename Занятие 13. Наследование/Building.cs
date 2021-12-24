using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_13.Наследование
{
    internal class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес: {Address}\nДлина: {Length}\nШирина: {Width}\nВысота: {Height}");
        }
    }
    sealed class MultiBuilding : Building
    {
        public int NumberOfFloors { get; set; }

        public MultiBuilding(string address, double length, double width, double height, int numberOfFloors)
            : base(address, length, width, height)
        {
            NumberOfFloors = numberOfFloors;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Количество этажей: {NumberOfFloors}");
        }
    }
}
