using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Program
    {
        // Student

        public abstract class Student
        {
            public string Name;
            public int StudentId;
            public abstract void BooleanIspassed(int grade);
        }
        public class Undergraduate : Student
        {
            public override void BooleanIspassed(int grade)
            {
                try
                {
                    Console.WriteLine("Enter the undergraduate student Grade");
                    grade = int.Parse(Console.ReadLine());
                    if (grade >= 70)
                    {
                        Console.WriteLine("UG student Passed the course with grade: {0}", grade);
                    }
                    else { Console.WriteLine("UG student Failed the course!"); }
                }
                catch (Exception) { Console.WriteLine("Invalid Input"); }
            }
        }
        // Derived class
        public class Graduate : Student
        {
            public override void BooleanIspassed(int grade)
            {
                try
                {
                    Console.WriteLine("Enter Graduate student Grade");
                    grade = int.Parse(Console.ReadLine());
                    if (grade >= 80)
                    { Console.WriteLine("Graduate student Passed the course with grade: {0}", grade); }
                    else { Console.WriteLine("Graduate student Failed the course!"); }
                }
                catch (Exception)
                { Console.WriteLine("Invalid Input"); }

            }
        }

        // Employe salary
        public class Employee
        {
            int empid;
            string empname;
            float salary;

            public Employee(int empid, string empname, float salary) { this.empid = empid; this.empname = empname; this.salary = salary; }

            public void displayDetails() { Console.WriteLine("Employee name {0} with Employee Id {1} gets a salary of {2}", empname, empid, salary); }


        }
        public class PartTimeEmployee
        {
            int daily_wage = 1600;
            public void showDetails() { Console.WriteLine("Part time employee gets a sum of {0} wages per day", daily_wage); }
        }

        // Day scholars and Hostlers
        public class Students
        {
            int stdid;
            string stdname;
            double exam_fee;

            public void displayDetails() { Console.WriteLine("The student {0} with Id {1} paid the exam fee of Rs.{2}", stdname, stdid, exam_fee); }
            public void payfee()
            {
                Console.WriteLine("Enter student Id: "); stdid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student name: "); stdname = Console.ReadLine();
                Console.WriteLine("Exam Fee to be paid by student is: {0}", 780);
                Console.WriteLine("Fee paid by the Student for exam is: "); exam_fee = int.Parse(Console.ReadLine());
                double bal_fee = 780 - exam_fee;
                if (exam_fee == 780) { Console.WriteLine("Student has paid the fee and there are No dues"); }
                else { Console.WriteLine("Student has to pay he remaining fee of: {0}", bal_fee); }
            }
            public class Hosteller
            {
                double hostel_fee;

                public Hosteller(double hostel_fee)
                {
                    this.hostel_fee = hostel_fee;
                    double bal_fee2 = 50000 - hostel_fee;
                    Console.WriteLine("The hostel fee is {0} per year", 50000);
                    Console.WriteLine("The hosteller paid the fee of RS:{0} and the balance fee to be paid is Rs: {1}", hostel_fee, bal_fee2);
                }
            }
            class Dayscholar
            {
                double transport_fee;

                public Dayscholar(double transport_fee)
                {
                    this.transport_fee = transport_fee;
                    double bal_fee3 = 30000 - transport_fee;
                    Console.WriteLine("The transport fee is RS: {0} per year", 30000);
                    Console.WriteLine("The dayscholar paid the fee of RS: {0} and the balance fee to be paid is Rs: {1}", transport_fee, bal_fee3);
                }
            }
            static void Main(string[] args)
            {
                Undergraduate ug = new Undergraduate();
                ug.BooleanIspassed(10);
                ug.Name = "Manoj";
                ug.StudentId = 334;
                Console.WriteLine("The student Name is {0} and Id is {1}", ug.Name, ug.StudentId);

                Graduate g = new Graduate();
                g.Name = "Sunny";
                g.StudentId = 325;
                g.BooleanIspassed(10);
                Console.WriteLine("The name of graduate is {0} and id is {1}", g.Name, g.StudentId);

                Employee employee = new Employee(67603, "Manoj", 10000);
                employee.displayDetails();
                PartTimeEmployee prtemp = new PartTimeEmployee();
                prtemp.showDetails();

                Students stds = new Students();
                stds.payfee();
                stds.displayDetails();
                Console.WriteLine("Enter the transport fee you will pay now: ");
                Dayscholar dayscholar = new Dayscholar(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter the hostel fee you will pay: ");
                Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));



                Console.ReadLine();
            }
        }
    }
}