using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts289.Typesofmethods
{
    class Method
    {
        public string Brand; // instance Variables
        public int warranty; // instance Variables
        public static string Quality ; //static variable

        // Instance Method
        public void Usage()
        {
            Console.WriteLine("Usage should be Proper");
        }

        // Static method
        public static void Work()
        {
            Console.WriteLine("Comfortable working");
        }
    }
}
