create database casestudy
use casestudy


Create table student
(studentID int primary key,
StudentName varchar(30),
DOB varchar(15))

Create table course
(CourseId int primary key,
Coursename varchar(15),
CourseDuration int,
CourseFee float)

Create table Enroll
(studentID int,
CourseID int,
Foreign key (studentID) references student(StudentID),
foreign key (CourseID) references course(CourseId),
DateOfEroll varchar(20))