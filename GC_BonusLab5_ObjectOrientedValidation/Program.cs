using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_BonusLab5_ObjectOrientedValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            OOValidator num = new OOValidator();
            Console.WriteLine("Welcome to the Validation Tester Application!");
            Console.WriteLine("\nInt Test");          
            Console.WriteLine(num.getIntWithinRange("", -100, 100));
            Console.WriteLine("\nDouble Test");
            Console.WriteLine(num.getDoubleWithinRange("", -100, 100));
            Console.ReadLine();
        }
    }
}
