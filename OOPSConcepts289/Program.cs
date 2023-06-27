using OOPSConcepts289.Class_and_Object;
using OOPSConcepts289.Typesofmethods;
using OOPSConcepts289.TypesOfVariables;
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
            Console.WriteLine("choose the below Options");
            Console.WriteLine("1:Class And Object \n2:Types Of Variables\n3:Types of Methods");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Organization org = new Organization();  //Object Creation
                    org.BatchNumber = 289;
                    org.Name = "Raji";
                    Console.WriteLine(org.Name + " is belongs to " + org.BatchNumber);
                    break;
                case 2:
                    Variables var = new Variables();
                    var.Adding();
                    Console.WriteLine("Instance Variables are : " + var.Cost);
                    Console.WriteLine("Static variables are : " + Variables.Device);
                    Console.WriteLine("Constant Variables are : " + Variables.RAM);
                    Console.WriteLine("Readonly Variables are : " + var.Battery);
                    break;
               case 3:
                    Method m = new Method();
                    m.Brand = "Bata";
                    m.warranty = 4;
                    Console.WriteLine("Brand Name is : " + m.Brand);
                    Console.WriteLine("Warranty years : " + m.warranty);
                    Method.Quality = "Excellent";
                    Console.WriteLine("quality should be : " + Method.Quality);
                    Method.Work(); // static method calling
                    m.Usage(); // Instance method calling
                    break; 
            }
            Console.ReadLine();
        }
    }
}

