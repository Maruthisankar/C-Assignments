using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CaseStudy
{
    public interface UserInterface
    {
        void showFirstScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentsScreen();
        void showStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCoursesScreen();
        void updateCourseDetails();
        void viewAllEnrollments();




    }



    public class SMS : UserInterface
    {
        AppEngine appEngine;
        //int studentidseq;
        //int courseseq;
        public SMS()
        {
            this.appEngine = new AppEngine();
            //this.studentidseq = 1;
            //this.courseseq = 10;
        }
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Enter course Id");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course ");
            string course = Console.ReadLine();
            Console.WriteLine("duration of the course");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fee of course");
            double fee = Convert.ToInt32(Console.ReadLine());
            Course course1 = new Course(courseId, course, duration, fee);
            appEngine.introduce(course1);
            //courseseq++;
            Console.WriteLine("Course updated succesfully");
            showAdminScreen();
        }



        public void showAdminScreen()
        {
            Console.WriteLine("Welcome to Admin Screen");
            Console.WriteLine("Enter \n1 To Introuduce new Course \n2 to Update Course Details \n3 to Student Enroll \n4 view all enrollments");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    introduceNewCourseScreen();
                    break;
                case 2:
                    updateCourseDetails();
                    break;
                case 3:
                    studentEnroll();
                    break;
                case 4:
                    viewAllEnrollments();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    showAdminScreen();
                    break;
            }
        }



        public void showAllCoursesScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine(" courses list  available");
            //foreach(var v in appEngine.listOfCourses())
            //{
            // Info.display(v);
            //}
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from course", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("course id :" + dr[0]);
                    Console.WriteLine("course name :" + dr[1]);
                    Console.WriteLine("course duration :" + dr[2]);
                    Console.WriteLine("course fees :" + dr[3]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            showFirstScreen();
        }



        public void showAllStudentsScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("students list registered");
            //foreach(var v in appEngine.listOfStudents())
            //{
            // Info.display(v);
            //}
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from Student", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("student id :" + dr[0]);
                    Console.WriteLine("student name :" + dr[1]);
                    Console.WriteLine("date of birth :" + dr[2]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            showAdminScreen();
        }



        public void showFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());



            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    showFirstScreen();
                    break;
            }
        }



        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("Enter student Id");
            int SId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of student");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter DOB(dd/mm/yyyy) of student");
            string dob = Console.ReadLine();
            Student student = new Student(SId, sname, dob);
            appEngine.register(student);
            //this.studentidseq++;
            Console.WriteLine("Student data updated  succesfully");
            showStudentScreen();
        }



        public void showStudentScreen()
        {
            Console.WriteLine("Welcome to Student Screen");
            Console.WriteLine("Enter \n1 to Registration \n2 to Show all Courses \n3 to Show Students");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    showAllCoursesScreen();
                    break;
                case 3:
                    showAllStudentsScreen();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    showStudentScreen();
                    break;



            }
        }
        public void studentEnroll()
        {
            Console.WriteLine("Enter sid");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter course id");
            int cid = Convert.ToInt32(Console.ReadLine());
            Student student = appEngine.GetStudentById(sid);
            Course course = appEngine.GetCourseById(cid);
            if (student == null)
            {
                Console.WriteLine("no student available with id");
            }
            else
            {
                if (course == null)
                {
                    Console.WriteLine("no course available with id");
                }
                else
                {
                    appEngine.enroll(student, course);
                }
            }
        }
        public void viewAllEnrollments()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("All Enrollment Details");
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from Enroll", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("student id :" + dr[0]);
                    Console.WriteLine("course id :" + dr[1]);
                    Console.WriteLine("date of enrollment :" + dr[2]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void updateCourseDetails()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;



            Console.WriteLine("course updating details");
            try
            {
                con = SQLConnection.getcon();
                Console.WriteLine("Enter course id to update course");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter course name:");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter duration");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter fees");
                double fees = Convert.ToDouble(Console.ReadLine());
                cmd = new SqlCommand("update Course  set  courseName =@name where courseId=@sid", con);
                cmd.Parameters.AddWithValue("@name", cname);
                cmd.Parameters.AddWithValue("@dur", dur);
                cmd.Parameters.AddWithValue("@fee", fees);
                cmd.Parameters.AddWithValue("@sid", sid);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("record updated");
                }
                else Console.WriteLine("Not updated");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}