using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instatiating Method class
            Method mathNumber = new Method();
            // Asking the user to input first number
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            // Asking the user to input second number or skip by pressing enter
            Console.WriteLine("Please enter a second number, or press enter to skip this step: ");

            try
            {
                // Calling method with 2 numbers if both numbers are provided by the user
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathNumber.MultiOp(num1, num2);
                Console.WriteLine(num1 + " multiply by " + num2 + " equals to " + results);
            }
            catch 
            {
                // Calling method with only one number provided by the user
                int results = mathNumber.MultiOp(num1);
                Console.WriteLine(num1 + " multiply by our default number equals to " + results);
            }
            Console.ReadLine();
        }
    }
}
