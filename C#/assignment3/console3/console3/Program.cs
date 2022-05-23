using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Student Marks
    internal class Student
    {
        string name;
        string rollno;
        string clas;
        string sem;
        string branch;


        public static void DisplayResult()
        {
            int[] marks = new int[5];
            marks[0] = 50;
            marks[1] = 65;
            marks[2] = 73;
            marks[3] = 84;
            marks[4] = 77;
            for (int x = 0; x < marks.Length; x++)
            { Console.WriteLine("Marks of each subject are: " + marks[x]); }
            double average = marks.Average(); for (int x = 0; x < marks.Length; x++)
            {
                if (marks[x] < 35) { Console.WriteLine("Failed"); }
                else if (marks[x] > 35 && average < 50) { Console.WriteLine("Failed"); }
                else if (average > 50) { Console.WriteLine("Passed"); }
                else { Console.WriteLine("Invalid input"); }

            }

        }
        public Student(string name, string rollno, string clas, string sem, string branch)
        {
            this.name = name; this.rollno = rollno; this.clas = clas; this.sem = sem; this.branch = branch;
            Console.WriteLine($"\n Name is: {name}, rollno is: {rollno}, clas is: {clas}, semester is: {sem}, branch is: {branch}");
        }
        static public void displayData()
        { Console.WriteLine("\nThe Marks:"); }

        // Car

        internal class Car
        {
            string car_name;
            int car_num;
            string car_model;
            string car_type;
            double cost = 50000000;
            public Car(string car_name, int car_num, string car_model, string car_type, double cost)
            {
                this.car_name = car_name; this.car_num = car_num; this.car_model = car_model; this.car_type = car_type; this.cost = cost;
                Console.WriteLine($"\nThe car_name is: {car_name}, car_num is: {car_num}, car_model is: {car_model},car_type is: {car_type},car_cost is: {cost}");
            }
            public void showDetails()
            {
                Console.WriteLine("\nBefore changing");
                Console.WriteLine($"Car_name is: {car_name}, car_num is: {car_num}, car_model is: {car_model},car_type is: {car_type},car_cost is: {cost}");
            }
            public Car(double car_cost)
            {
                Console.WriteLine("\nAfter Changing");
                car_cost = cost;
                Console.WriteLine($"\nThe car_name is: {car_name}, Car_num is: {car_num}, Car_model is: {car_model}, car_type is: {car_type},cost is: {cost}");
            }

        }
        internal class bank
        {
            double interestrate;
            public void loanCalculator(double loan)
            {
                Console.WriteLine("\nEnter Rate of Interest");
                interestrate = int.Parse(Console.ReadLine());
                double interest = (loan * interestrate) / 100;
                Console.WriteLine("\nRate of interest of {0} is {1}", interestrate, interest);
            }
        }

        static void Main(string[] args)
        {
            // Student
            Student.DisplayResult();
            Student student = new Student("Manoj", "18-334", "Mech-A", "4-2", "Mechanical");
            Student.displayData();

            // Car
            Car car = new Car("BMW", 8800, "Sports", "Racing", 80000000);
            car.showDetails();
            Car car2 = new Car(60000000);

            // Bank
            bank bank = new bank();
            Console.WriteLine("\nEnter loan Money: ");
            bank.loanCalculator(int.Parse(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}