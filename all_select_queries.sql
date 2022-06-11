--show all the tables of databases;

select * from Trainers;
select * from Students;
select * from Assignments;
select * from Courses;
select * From StudentCourses;
select * from CourseAssignments;
select * from TrainerCourses;
select * from TrainerStudents;
select * from Cities;
select * from States;
select * from Grades;

-- show all the students per course --
SELECT Students.FirstName As Student_Firstname,Students.LastName As Student_Lastname, Courses.Name As Course
FROM Students 
inner join StudentCourses 
ON Students.StudentId = StudentCourses.Student_StudentId
inner join Courses 
ON Courses.CourseId = StudentCourses.Course_CourseId
Order by Courses.Name;


-- show all the trainers per course --

SELECT Trainers.FirstName As Trainer_Firstname,Trainers.LastName As Trainer_Lastname, Courses.Name As Course
FROM Trainers
inner join TrainerCourses 
ON Trainers.TrainerId = TrainerCourses.Trainer_TrainerId
inner join Courses 
ON Courses.CourseId = TrainerCourses.Course_CourseId
Order by Courses.Name;

-- show all the assignments per course --
select Assignments.Name as Assignment_Title, Assignments.Description as Assignment_Description, Assignments.Points, Assignments.StartDate,Assignments.EndDate, Courses.Name as CourseTitle
from Assignments
inner join CourseAssignments on Assignments.AssignmentId = CourseAssignments.Assignment_AssignmentId
inner join Courses on Courses.CourseId = CourseAssignments.Course_CourseId
order by Courses.Name asc;

-- show all the assignments per course per student --
Select Courses.Name as Course_Name,Students.FirstName + ' '+Students.LastName as Student_FullName, Assignments.Name as Assignment_Name, Assignments.StartDate as Assignment_StartDate,Assignments.EndDate as Assignment_EndDate
from StudentCourses
inner join StudentAssignments on StudentCourses.Student_StudentId =  StudentAssignments.Student_StudentId
inner join Courses on StudentCourses.Course_CourseId = Courses.CourseId
inner join Students on StudentCourses.Student_StudentId = Students.StudentId
inner join Assignments on StudentAssignments.Assignment_AssignmentId = Assignments.AssignmentId
order by Courses.Name,Students.FirstName;

-- show a list of students that belong to more than one courses --
SELECT Students.FirstName + ' '+Students.LastName as Student_FullName, Count(*) as Numbers_Of_Courses
FROM Students INNER JOIN StudentCourses ON Students.StudentId = StudentCourses.Student_StudentId
GROUP BY Students.FirstName,Students.LastName
HAVING COUNT(*) > 1
Order by Students.FirstName asc;



