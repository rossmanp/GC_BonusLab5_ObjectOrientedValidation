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
        double _myDouble;
        
        public OOValidator()
        {

        }       

        public int getInt (string prompt)
        {
            int _checkNum;
            OOValidator num = new OOValidator();
            bool run = true;
            bool success = int.TryParse(prompt, out _myInt);
            while (run)
            {
                if (success == false)
                {
                    Console.WriteLine("Error! Invalid input. Please try again.");
                    _checkNum = num.getIntWithinRange("", -100, 100);
                    if (_checkNum.GetType() == typeof(int))
                    {
                        run = false;
                    }
                }
                else
                {
                    run = false;
                }
            }
            return _myInt;
        }

        public int getIntWithinRange(string prompt, int min, int max)
        {
            bool run = true;
            OOValidator num = new OOValidator();
            while (run)
            {
                Console.WriteLine("Enter an integer between -100 and 100: ");
                _myInt = num.getInt(Console.ReadLine());           
                if (_myInt >= min && _myInt <= max)
                {
                    run = false;
                }
                else if (_myInt < min)
                {
                    Console.WriteLine("Error! Number must be greater than " + (min - 1));
                }
                else if (_myInt > max)
                {
                    Console.WriteLine("Error! Number must be less than " + (max + 1));
                }                             
            }
            return _myInt;
        }

        public double getDouble(string prompt)
        {
            double _checkNum;
            OOValidator num = new OOValidator();
            bool run = true;
            bool success = double.TryParse(prompt, out _myDouble);
            while (run)
            {
                if (success == false)
                {
                    Console.WriteLine("Error! Invalid input. Please try again.");                  
                    _checkNum = num.getDoubleWithinRange("", -100, 100);
                    if (_checkNum.GetType() == typeof(double))
                    {
                        run = false;
                    }
                }
                else
                {
                    run = false;
                }
            }
            return _myDouble;
        }

        public double getDoubleWithinRange(string prompt, double min, double max)
        {
            bool run = true;
            double myDouble = 0;
            OOValidator num = new OOValidator();
            while (run)
            {
                Console.WriteLine("Enter a double between -100 and 100: ");              
                _myDouble = num.getDouble(Console.ReadLine());
                if (myDouble >= min && myDouble <= max)
                {
                    run = false;
                }
                else if (myDouble < min)
                {
                    Console.WriteLine("Error! Number must be greater than " + (min - 1));
                }
                else if (myDouble > max)
                {
                    Console.WriteLine("Error! Number must be less than " + (max + 1));
                }
            }
            return myDouble;
        }
    }
}
