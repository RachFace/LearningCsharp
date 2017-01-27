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
            String newdate = Console.ReadLine();
            Console.WriteLine("Your name is " + newdate);
            Console.ReadKey();

            Console.WriteLine("Please enter your age");
            var input = Console.ReadLine();
            int num1;
            var MyAge = Int32.TryParse(input, out num1);
            if (MyAge == true)
            {
                // The input was good and we have a new number in num1
            }
            else
            {
                // the input was bad and the user should feel bad
            }
            var myDate = DateTime.Now;
            var newDate = myDate.AddYears(- num1);
            Console.WriteLine("Your birth year is " + newDate.Year);
            Console.ReadKey();

            string valueString = "Hello World";
            Console.WriteLine(valueString);
            Console.ReadKey();
        }


    }
}
