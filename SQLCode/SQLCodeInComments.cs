using Labb3_databas_AhlingsSchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;

namespace Labb3_databas_AhlingsSchoolProject.SQLCode
{
    internal class SQLCodeInComments
    {
//        Select Title, FName, LName, EmployeeId, type from Employees
//Join personalInformations on FK_PersonIdEmployee = PersonId
//--where Title = 'Teacher'
//--Byt ut efter "where =" mot Boss eller Administrator för att hitta de andra
//----------------
//Select Title, Fname, Lname, type, FK_PersonIdStudent From Students
//Join personalInformations on FK_PersonIdStudent = PersonId
//------------
//Select FName, LName, Title from Students
//Join personalInformations on FK_PersonIdStudent = PersonId
//order By LName Desc
//--Order By FName Asc        
//--Order by Lname Asc
//--Order by Fname Desc
//--Order by Lname desc
//----------------------
//Select Title, StudentId, CONCAT (Fname, '  ', Lname) as Name, ClassName From Students
//Join personalInformations on FK_PersonIdStudent = PersonId
//        Join Classes on FK_ClassId = ClassId
//--where ClassName = 'Math'
//--order by Fname Desc
//order by ClassName Desc
//-----------------------
//Select Title, StudentId, CONCAT (Fname, '  ', Lname) as Name, ClassName, Grade, GradeSet From Students
//Join personalInformations on FK_PersonIdStudent = PersonId
//Join Classes on FK_ClassId = ClassId
//        Join gradingTables on StudentId = GradingId
// Where GradeSet BETWEEN '2022-11-01' AND  '2022-12-30'
// --------------------------
// Select AVG(Grade) As AVGGrade, MAX(Grade) As MaxGrade, Min(Grade) as MinGrade, ClassName From gradingTables
// Join Classes on ClassId = FK_ClassId
// GROUP BY ClassName
// --------------------------
// --Insert Into Employees(Title, FK_ClassId, FK_PersonIdEmployee)
// --Values('Employee', 3, 5)
//--Studenter och lärare blir ävrda från PersonalInformation.
// --------
// --Insert into personalInformations(FName, LName, Mail, SSNumber, Birthdate, type)
// --Values('Hilda', 'Johnsson', 'Hilda.Jonhsson@gmail.com', '19540325-0335', '1954-03-25', 2)
// ---------------------------
//--Insert Into Students(Title, FK_ClassId, FK_PersonIdStudent)
//--Values('Student', 4, 6)
//--Studenter och lärare blir ävrda från PersonalInformation.
// ----
//--Insert Into personalInformations(FName, LName, Mail, SSNumber, Birthdate, type)
//--Values('Niklas', 'Sendelbach', 'Niklas.Sendelbach@Yahoo.com', '19900215-0037', '1990-02-15', 1)
//--Type 1 är för studenter och type 2 är för Employees om man tar upp EmployeeTable eller StudentTable
    }
}
