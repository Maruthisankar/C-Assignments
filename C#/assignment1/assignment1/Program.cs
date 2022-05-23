using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Two integers Equal or Not
            int num1;
            int num2;
            Console.WriteLine("Enter num1"); num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2"); num2 = int.Parse(Console.ReadLine());
            if (num1 == num2) { Console.WriteLine("num1 {0} and num2 {1} are Equal", num1, num2); }
            else if (num1 != num2) { Console.WriteLine("num1 {0} and num2 {1} are Not Equal", num1, num2); }
            else { Console.WriteLine("Invalid Input"); }

            // Positive or Negative number
            int pnum1;
            Console.WriteLine("Enter pnum1");
            pnum1 = int.Parse(Console.ReadLine());
            if (pnum1 >= 0) { Console.WriteLine("{0} is a Positive Number", pnum1); }
            else if (pnum1 <= 0) { Console.WriteLine("Negative number"); }
            else { Console.WriteLine("Invalid Input"); }

            // Performing Operations
            int number1, number2, Result; char operation;
            Console.WriteLine("Enter number1: "); number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: "); number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose Operation ");
            Console.WriteLine("1 Addition"); Console.WriteLine("2 Subtraction");
            Console.WriteLine("3 Multiplication"); Console.WriteLine("4 Division");
            operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    Result = number1 + number2; Console.WriteLine("Addition of two numbers is = {0}", Result);
                    break;
                case '2':
                    Result = number1 - number2; Console.WriteLine("Subtraction of two numbrs is = {0}", Result);
                    break;
                case '3':
                    Result = number1 * number2; Console.WriteLine("Multiplication of two numbers is = {0}", Result);
                    break;
                case '4':
                    Result = (number1 / number2); Console.WriteLine("Division of two numbers is = {0}", Result);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }



            Console.ReadLine();
        }
    }
}