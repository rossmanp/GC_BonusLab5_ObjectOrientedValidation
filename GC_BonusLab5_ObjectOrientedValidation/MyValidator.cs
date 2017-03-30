using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_BonusLab5_ObjectOrientedValidation
{
   
    class MyValidator
    {
        private string _output;
        public MyValidator()
        {

        }

        //Takes a string as input and requires the user to input
        //the same string to continue.

        public string GetRequiredString (string prompt)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Input the word " + prompt);
                _output = Console.ReadLine();
                if (_output != prompt)
                {
                    Console.WriteLine("You did not input " + prompt + ". Please try again.");
                }
                else
                {
                    run = false;
                }
            }
            return _output;
        }

        //For GetChoiceString the user must enter one of two strings to continue.

        public string GetChoiceString (string prompt, string s1, string s2)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Input either the word " + s1 + " or " + s2);
                prompt = Console.ReadLine();
                _output = prompt;
                if (_output != s1 && _output != s2)
                {
                    Console.WriteLine("You did not input " + s1 + " or " + s2 + ". Please try again.");
                }
                else
                {
                    run = false;
                }
            }
            return _output;
        }
    }
}
