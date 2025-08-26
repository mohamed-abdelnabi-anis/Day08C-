using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_
{
    internal interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }
    class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("StartEngine");
        }

        public void StopEngine()
        {
            Console.WriteLine("StopEngine");
        }
        }

        class Bike : IVehicle
        {
            public void StartEngine()
            {
                Console.WriteLine("StartEngine"); 
            }

            public void StopEngine()
            {
                Console.WriteLine("StopEngine");
            }
        }
    }

