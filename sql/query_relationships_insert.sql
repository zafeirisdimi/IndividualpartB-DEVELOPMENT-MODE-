USE [Prototype]
GO

INSERT INTO [dbo].[StudentCourses]([Student_StudentId],[Course_CourseId])VALUES(2,1),(1,2),(1,3),(2,2),(3,1),(4,1),(4,2),(4,4),(4,5),(5,1);


INSERT INTO [dbo].[StudentAssignments]([Student_StudentId],[Assignment_AssignmentId])VALUES(1,1),(1,2),(1,3),(2,2),(2,2),(3,3),(3,4),(4,4),(4,5),(5,1);

INSERT INTO [dbo].[CourseAssignments]([Course_CourseId] ,[Assignment_AssignmentId])VALUES(1,1),(1,2),(1,3),(2,2),(3,1),(4,1),(4,2),(4,4),(4,5),(5,1)

INSERT INTO [dbo].[TrainerCourses]([Trainer_TrainerId],[Course_CourseId])VALUES(1,1),(1,2),(1,3),(2,2),(3,1),(4,1),(4,2),(4,4),(4,5)

INSERT INTO [dbo].[TrainerStudents]([Trainer_TrainerId],[Student_StudentId])VALUES(1,1),(1,2),(1,3),(2,2),(3,1),(4,1),(4,2),(4,4),(4,5)
GO


