using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle drives");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle drives fast");
        }
    }
}
