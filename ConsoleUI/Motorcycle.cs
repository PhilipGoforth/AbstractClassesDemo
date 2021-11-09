using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        /* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            * Provide the implementations for the abstract methods
            * Only in the Motorcycle class will you override the virtual drive method
           */
        public int EngineCCs { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Its raining and Im wet...");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("I have no idea what Im doing..");
        }
    }
}
