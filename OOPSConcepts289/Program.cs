using OOPSConcepts289.Class_and_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....OOPS CONCEPT....");
            Organization org = new Organization();  //Object Creation
            org.BatchNumber = 289;
            org.Name = "Raji";
            Console.WriteLine(org.Name + " is belongs to " + org.BatchNumber);
            Console.ReadLine();
        }
    }
}
