using Prototype.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Services.MockupRepository
{
    public interface IInputMockupData
    {
        List<Student> ListOfStudents(string filepath);
        List<Trainer> ListOfTrainers(string filepath);
        List<Assignment> ListOfAssignments(string filepath);
        List<Course> ListOfCourses(string filepath);
        List<City> ListOfCities(string filepath);
        List<State> ListOfStates(string filepath);
        List<Grade> ListOfGrades(string filepath);
    }
}
