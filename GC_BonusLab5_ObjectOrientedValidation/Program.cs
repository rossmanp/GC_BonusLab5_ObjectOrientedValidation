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
            //This program instantiates a class of each type and runs the various tests.

            OOValidator num = new OOValidator();
            MyValidator word = new MyValidator();
            Console.WriteLine("Welcome to the Validation Tester Application!");
            Console.WriteLine("\nInt Test");
            num.getIntWithinRange("", -100, 100);
            Console.WriteLine("\nDouble Test");
            num.getDoubleWithinRange("", -100, 100);
            Console.WriteLine("\nString Test");
            word.GetRequiredString("word");
            word.GetChoiceString("", "and", "but");
            Console.ReadLine();
        }
    }
}
