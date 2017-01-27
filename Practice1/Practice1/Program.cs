using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter your name"); 
            String name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            Console.ReadKey();

            Console.WriteLine("Please enter your age");
            var input = Console.ReadLine();
            int agoodnumberaslongastheusertypedinavalidnumber;
            var usertypedinagoodnumber = Int32.TryParse(input, out agoodnumberaslongastheusertypedinavalidnumber);
            if (usertypedinagoodnumber == true)
            {
                // The input was good and we have a new number in num1
            }
            else
            {
                // the input was bad and the user should feel bad
            }
            DateTime myDate = DateTime.Now;
            DateTime newDate = myDate.AddYears(- num1);
            Console.WriteLine("Your birth year is " + newDate.Year);
            Console.ReadKey();

            string valueString = "Hello World";
            Console.WriteLine(valueString);
            Console.ReadKey();
        }


    }
}
