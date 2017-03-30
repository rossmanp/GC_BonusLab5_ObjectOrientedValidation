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

        public string GetRequiredString (string prompt)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Input the word " + prompt);
                _output = Console.ReadLine();
                if (_output != prompt)
                {
                    Console.WriteLine("You did not input " + prompt + " . Please try again.");
                }
                else
                {
                    run = false;
                }
            }
            return _output;
        }

        public string GetChoiceString (string prompt, string s1, string s2)
        {

            return _output;
        }
    }
}
