using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts289.TypesOfVariables
{
   public  class Variables
    {
        public static string Device = "Mobile"; //static variable
        public int Cost = 200000; // instance variable
        public const int RAM = 64; // Constant variable
        public readonly float Battery = 5000; //ReadOnly Variables 
    
        public void Adding()
        {
            // Local Variables
            int num1 = 12;
            int num2 = 13;
            int result = num1 + num2;
            Console.WriteLine("Local Variables : " + result);
        }
    }
}

