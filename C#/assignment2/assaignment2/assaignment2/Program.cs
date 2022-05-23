using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Average, Minimum and Maximum Value in an Array
            int[] arr = new int[5];
            for (int x = 0; x < 5; x++)
            { Console.WriteLine("Enter values in Array "); arr[x] = int.Parse(Console.ReadLine()); }
            for (int x = 0; x < 5; x++) { Console.Write(arr[x] + " "); }
            {
                Console.WriteLine("\nAverage Value of given Array is " + arr.Average());
                Console.WriteLine("Minimum Value of given Array is " + arr.Min());
                Console.WriteLine("Maximum Value of given Array is " + arr.Max());
            }


            // Accepting 10 marks and display Total,Average,Max,Min,Ascending,Descending

            int[] arr2 = new int[10];
            for (int a = 0; a < 10; a++)
            { Console.WriteLine("Enter Marks:"); arr2[a] = int.Parse(Console.ReadLine()); }
            for (int a = 0; a < 10; a++) { Console.Write(arr2[a] + " "); }
            {
                Console.WriteLine("\nAverage Value of given Marks is:" + arr2.Average());
                Console.WriteLine("Minimum marks of givem Marks are:" + arr2.Min());
                Console.WriteLine("Maximum marks of given marks are:" + arr2.Max());
            }
            {
                Array.Sort(arr2);
                { Console.WriteLine("Ascending Order of Marks is:"); }
                for (int a = 0; a < 10; a++) { Console.Write(arr2[a] + " "); }

                Array.Reverse(arr2);
                { Console.WriteLine("\nDescending Order of marks is:"); }
                foreach (int b in arr2) { Console.Write(b + " "); }
            }
            // Strings
            // Accept and Display length of String
            string str;

            Console.WriteLine("\nEnter a String:"); str = Console.ReadLine();
            int c = str.Length;
            Console.WriteLine("Length of String is: " + c);

            // Reversing a String
            Console.WriteLine("Enter a String");
            string s1 = Console.ReadLine();
            Console.WriteLine("Reversed String is: ");
            for (int i = s1.Length - 1; i >= 0; i--)
            { Console.Write(s1[i]); }

            // Two words are same or not
            Console.WriteLine("\nEnter a word");
            string s2 = Console.ReadLine();
            Console.WriteLine("Enter another word");
            string s3 = Console.ReadLine();
            if (s2 == s3) { Console.WriteLine("Given Two Words are same!"); }
            else { Console.WriteLine("The words are not same"); }

            // Palindrome
            Console.WriteLine("\nEnter a String");
            string s4 = Console.ReadLine(); String r = "";
            for (int a = s4.Length - 1; a >= 0; a--) { r += (s4[a].ToString()); }
            if (s4 == r) { Console.WriteLine("It is a palindrome String"); }
            else { Console.WriteLine("Not a Palindrome string"); }




            Console.ReadLine();
        }
    }
}