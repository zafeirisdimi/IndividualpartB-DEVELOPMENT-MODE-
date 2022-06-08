using Prototype.ApplicationDatabase;
using Prototype.Enum;
using Prototype.Models;
using Prototype.Views.AssignmentView;
using Prototype.Views.CourseView;
using Prototype.Views.StudentView;
using Prototype.Views.TrainerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prototype.Services
{
    public static class MainMenu
    {
        public static bool Run()
        {
            Menu();
            int input = Convert.ToInt32(Console.ReadLine());
            Choice choice = (Choice)input;
            switch (choice)
            {
                case Choice.Students:
                    using (var c = new ApplicationContext())
                    {
                        var students = c.Students.ToList();
                        StudentAction.PrintAllStudents(students);
                        Thread.Sleep(3000);
                    }
                    return true;

                case Choice.Trainers:
                    using (var c = new ApplicationContext())
                    {
                        var trainers = c.Trainers.ToList();
                        TrainerAction.PrintAllTrainers(trainers);
                        Thread.Sleep(3000);
                    }
                    return true;

                case Choice.Courses:
                    using (var c = new ApplicationContext())
                    {
                        var courses = c.Courses.ToList();
                        CourseAction.PrintAllCourses(courses);
                        Thread.Sleep(3000);
                    }
                    return true;

                case Choice.Assignments:
                    using (var c = new ApplicationContext())
                    {
                        var assignments = c.Assignments.ToList();
                        AssigmentAction.PrintAllAssignments(assignments);
                        Thread.Sleep(3000);
                    }
                    return true;

                case Choice.StudentCourse:

                    using (var c = new ApplicationContext())
                    {
                        var courses = c.Courses.ToList();
                        foreach (var course in courses)
                        {
                            CourseAction.PrintExtend(course);

                            foreach (var stu in course.Students)
                            {
                                StudentAction.PrintShort(stu);
                            }
                            Thread.Sleep(4000);
                        }
                    }
                    return true;

                case Choice.TrainerCourse:
                    using (var c = new ApplicationContext())
                    {
                        var courses = c.Courses.ToList();
                        foreach (var course in courses)
                        {
                            Console.WriteLine($"\t\t|Course: {course.Name}\t has: ({course.Trainers.Count()}) trainers");

                            foreach (var trainer in course.Trainers)
                            {
                                TrainerAction.PrintInfo(trainer);
                            }
                            Thread.Sleep(4000);
                        }
                    }
                    return true;
                case Choice.AssignmentCourse:
                    using (var c = new ApplicationContext())
                    {
                        var courses = c.Courses.ToList();
                        foreach (var course in courses)
                        {
                            Console.WriteLine($"\t\t|Course: {course.Name}\t has: ({course.Assignments.Count()}) assignments");

                            foreach (var assignment in course.Assignments)
                            {
                                AssigmentAction.PrintExtend(assignment);
                            }
                            Thread.Sleep(4000);
                        }
                    }
                    return true;
                case Choice.AssignmentsPerCoursePerStudent:
                    using (var c = new ApplicationContext())
                    {
                        var students = c.Students.ToList();
                        foreach (var s in students)
                        {
                            StudentAction.PrintExtend(s);
                            
                            foreach (var course in s.Courses)
                            {
                                Console.WriteLine($"\t\t\t|Title: {course.Name}\t has ({course.Assignments.Count}) assignments");
                                foreach (var assign in course.Assignments)
                                {
                                    AssigmentAction.PrintInfo(assign);
                                }
                            }
                            Thread.Sleep(4000);
                        }
                    }
                    return true;
                case Choice.StudentsInMultipleCourses:
                    using (var c = new ApplicationContext())
                    {
                        var students = c.Students.ToList().Where( s =>s.Courses.Count()>1);
                        foreach (var student in students)
                        {
                            Console.WriteLine($"\t\t Student {student.FirstName,-10}\t{student.LastName,-10} has ({student.Courses.Count()}) courses ");
                        }
                        Thread.Sleep(4000);
                    }
                    return true;

                case Choice.Exit:
                    return false;

                default:
                    Console.WriteLine("You typed something wrong,try again!");
                    return true;
            }


        }

        private static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("|\t Choose an option");
            Console.WriteLine("|\t\t 1) Show all the students");
            Console.WriteLine("|\t\t 2) Show all the trainers");
            Console.WriteLine("|\t\t 3) Show all the courses");
            Console.WriteLine("|\t\t 4) Show all the assignments");
            Console.WriteLine("|\t\t 5) Show all the students per course");
            Console.WriteLine("|\t\t 6) Show all the trainers per course");
            Console.WriteLine("|\t\t 7) Show all the assignments per course");
            Console.WriteLine("|\t\t 8) Show all the assignments per course per student");
            Console.WriteLine("|\t\t 9) Show a list of students that belong to more than one courses");
            Console.WriteLine("|\t\t 10 Exit");
            Console.WriteLine("____________________________________________________________________________________");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\r\n\t Select an option: ");


        }
    }
}
