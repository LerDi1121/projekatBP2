-- create procedure dbo.SelectStudentForCourseWithoutParamFinal
--as 
--begin

--select Id_Student from Users_Student  inner join Registereds on Users_Student.Id_Student= Registereds.Student_Id_User  inner join Courses  on Registereds.Course_Id_Course=Id_Course where Courses.Id_Course=  3 order by Users_Student.Id_Student

--end
exec SelectStudentForCourseWithoutParamFinal