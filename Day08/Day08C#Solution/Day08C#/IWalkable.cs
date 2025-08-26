using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_
{
    internal interface IWalkable
    {
        void Walk();
    }
    class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine(" walking1 .");
        }
        void IWalkable.Walk()
        {
            Console.WriteLine(" walking2 .");
        }

    }
}