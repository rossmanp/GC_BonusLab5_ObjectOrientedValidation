using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_BonusLab5_ObjectOrientedValidation
{
    class OOValidator
    {
        int _myInt;

        public OOValidator()
        {

        }

        public int getInt (string prompt)
        {
           int.TryParse(prompt, out _myInt);
           return _myInt;  
        }

        public int getIntWithinRange(string prompt, int min, int max)
        {
            bool run = true;
            int myInt = 0;
            while (run)
            {
                Console.WriteLine("Enter an integer between -100 and 100: ");
                bool success = int.TryParse(Console.ReadLine(), out myInt);              
                if (success == false)
                {
                        Console.WriteLine("Error! Invalid input. Please try again.");                    
                }
                else if (myInt >= min && myInt <= max)
                {
                    run = false;
                }
                else if (myInt < min)
                {
                    Console.WriteLine("Error! Number must be greater than " + (min - 1));
                }
                else if (myInt > max)
                {
                    Console.WriteLine("Error! Number must be less than " + (max + 1));
                }                             
            }
            return myInt;
        }

       
    }
}
