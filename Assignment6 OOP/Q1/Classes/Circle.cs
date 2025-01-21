using Assignment6_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_OOP.Classes
{
    internal class Circle : ICircle
    {

        public double radius { get; set; }
        public double Area => Math.PI * radius * radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"radius = {radius}");
            Console.WriteLine($"Area = {Area}");
        }
    }
}
