﻿using System;
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

        //This method confirms that the user entered an integer, and returns the integer.

        public int getInt (string prompt)
        {            
            int.TryParse(prompt, out _myInt);
            while (!int.TryParse(prompt, out _myInt))
            {        
              Console.Write("The value must be an integer, try again: ");
              prompt = Console.ReadLine();            
            }
            return _myInt;
        }

        //For the user to proceed, he or she must enter an integer within the specified range.

        public int getIntWithinRange(string prompt, int min, int max)
        {
            bool run = true;
            OOValidator num = new OOValidator();
            while (run)
            {
                Console.WriteLine("Enter an integer between -100 and 100: ");
                _myInt = num.getInt(Console.ReadLine());
                if (_myInt < min)
                {
                    Console.WriteLine("Error! Number must be greater than " + (min - 1));
                }
                else if (_myInt > max)
                {
                    Console.WriteLine("Error! Number must be less than " + (max + 1));
                }
                else
                {
                    run = false;
                }
            }
            return _myInt;
        }

        //This method confirms that the user entered a number, and returns the number.

        public double getDouble(string prompt)
        {
            double.TryParse(prompt, out _myDouble);
            while (!double.TryParse(prompt, out _myDouble))
            {
                Console.Write("The value must be a number, try again: ");
                prompt = Console.ReadLine();
            }
            return _myDouble;
        }

        //For the user to proceed, he or she must enter a number within the specified range.

        public double getDoubleWithinRange(string prompt, double min, double max)
        {
            bool run = true;
            OOValidator num = new OOValidator();
            while (run)
            {
                Console.WriteLine("Enter a double between -100 and 100: ");              
                _myDouble = num.getDouble(Console.ReadLine());
                if (_myDouble < min)
                {
                    Console.WriteLine("Error! Number must be greater than " + (min - 1));
                }
                else if (_myDouble > max)
                {
                    Console.WriteLine("Error! Number must be less than " + (max + 1));
                }
                else
                {
                    run = false;
                }
            }
            return _myDouble;
        }
    }
}
