using Newtonsoft.Json;
using Prototype.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Services.MockupRepository
{
    public static class ImportMockupData
    {
        internal static List<Assignment> ListOfAssignments(string filepath)
        {
            string json = filepath;
            List<Assignment> Assignments = JsonConvert.DeserializeObject<List<Assignment>>(json);
            return Assignments;
        }

        internal static List<City> ListOfCities(string filepath)
        {
            string json = filepath;
            List<City> Cities = JsonConvert.DeserializeObject<List<City>>(json);
            return Cities;
        }

        internal static List<Course> ListOfCourses(string filepath)
        {
            string json = filepath;
            List<Course> Courses = JsonConvert.DeserializeObject<List<Course>>(json);
            return Courses;
        }

        internal static List<Grade> ListOfGrades(string filepath)
        {
            string json = filepath;
            List<Grade> Grades = JsonConvert.DeserializeObject<List<Grade>>(json);
            return Grades;
        }

        internal static List<State> ListOfStates(string filepath)
        {
            string json = filepath;
            List<State> States = JsonConvert.DeserializeObject<List<State>>(json);
            return States;
        }

        internal static List<Student> ListOfStudents(string filepath)
        {
            string json = filepath;
            List<Student> Students = JsonConvert.DeserializeObject<List<Student>>(json);
            return Students;
        }

        internal static List<Trainer> ListOfTrainers(string filepath)
        {
            string json = filepath;
            List<Trainer> Trainers = JsonConvert.DeserializeObject<List<Trainer>>(json);
            return Trainers;
        }
    }
}
