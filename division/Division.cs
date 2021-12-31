using System;
using System.Collections.Generic;
using System.Text;

namespace division
{
    class Division
    {
        public int division(int x, int y)
        {
            
            int Division = x / y;
            return Division;
        }
        public void App()
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                int FirstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter secound number: ");
                int SecoundNum = int.Parse(Console.ReadLine());
                
                Console.WriteLine(division(FirstNum, SecoundNum));
            }
            catch (FormatException e) {
                Console.WriteLine("inviled number. Please try again.");
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("cannot divided by zero. Pleas try again.");
            }
        }


    }
}
