using Assignment6_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_OOP.Classes
{
    internal class Rectangle : IRectangle
    {

        public double Dim01 { get; set; }
        public double Dim02 { get; set; }


        public double Area => Dim01 * Dim02;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Dim 1 : {Dim01}");        
            Console.WriteLine($"Dim 2 : {Dim02}");        
            Console.WriteLine($"Area : {Area}");        
        }
    }
}
