using Labb3_databas_AhlingsSchoolProject.Data;
using Labb3_databas_AhlingsSchoolProject.Models;
using Microsoft.Data.SqlClient;

namespace Labb3_databas_AhlingsSchoolProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = DESKTOP-8KGH2CT; Initial Catalog = AhlingsSchool;Integrated Security = True");


            using (AhlingsSchoolDbContext context = new AhlingsSchoolDbContext())
            {
                var Option = "";
                Console.WriteLine("Do you wanna search for a specific employee press 1\nElse press 2:");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Write exacly: 'Teacher' or 'Boss' or ''Administrator");
                    Option = Console.ReadLine();
                    var Employees = from q in context.Employees.Where(P => P.Title == Option)
                                    join w in context.PersonalInformations on q.FkPersonIdEmployee equals w.PersonId

                                    select new
                                    {
                                        PersonalInformation = w.Fname,
                                        PersonalInformation1 = w.Lname,
                                        PersonalInformation2 = w.Type,
                                        PersonalInformation3 = w.PersonId,
                                        Employees = q.EmployeeId,
                                        Employees1 = q.Title
                                    };
                    Console.Clear();
                    Console.WriteLine("Title:           Name:              LastName:  Type:   EmployeeId:");
                    foreach (var x in Employees)
                    {
                        Console.WriteLine(x.Employees1 + "\t        " + x.PersonalInformation + "  \t   " + x.PersonalInformation1 + "  \t" + x.PersonalInformation2 + "\t" + x.Employees + "\t");
                    }

                }
                else
                {
                    var Employees = from q in context.Employees
                                    join w in context.PersonalInformations on q.FkPersonIdEmployee equals w.PersonId

                                    select new
                                    {
                                        PersonalInformation = w.Fname,
                                        PersonalInformation1 = w.Lname,
                                        PersonalInformation2 = w.Type,
                                        PersonalInformation3 = w.PersonId,
                                        Employees = q.EmployeeId,
                                        Employees1 = q.Title
                                    };
                    Console.WriteLine("Title:           Name:              LastName:  Type:   EmployeeId:");
                    foreach (var x in Employees)
                    {
                        Console.WriteLine(x.Employees1 + "\t        " + x.PersonalInformation + "  \t   " + x.PersonalInformation1 + "  \t" + x.PersonalInformation2 + "\t" + x.Employees + "\t");
                    }

                }


            }


            Console.WriteLine(new string('-', (60)));

            using (AhlingsSchoolDbContext Context = new AhlingsSchoolDbContext())
            {
                Console.WriteLine("press 1 for sorting with firstname Ascending");
                Console.WriteLine("press 2 for sorting with firstname Descending");
                Console.WriteLine("press 3 for sorting with LastNAme Ascending");
                Console.WriteLine("press 4 for sorting with LastNAme Descendning");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var Join = from q in Context.Students
                                   join w in Context.PersonalInformations on q.FkPersonIdStudent equals w.PersonId
                                   orderby w.Fname ascending
                                   select new
                                   {
                                       PersonalInformation = w.Fname,
                                       PersonalInformation1 = w.Lname,
                                       PersonalInformation2 = w.Type,
                                       PersonalInformation3 = w.PersonId,
                                       Students = q.StudentId,

                                   };
                        Console.WriteLine("Name:   LastName:     Type:     StudentId: ");
                        foreach (var x in Join)
                        {

                            Console.WriteLine(x.PersonalInformation + " \t " + x.PersonalInformation1 + " \t " + x.PersonalInformation2 + "\t" + x.Students + "\t ");
                        }
                        break;
                    case "2":
                        var Join2 = from q in Context.Students
                                    join w in Context.PersonalInformations on q.FkPersonIdStudent equals w.PersonId
                                    orderby w.Fname descending
                                    select new
                                    {
                                        PersonalInformation = w.Fname,
                                        PersonalInformation1 = w.Lname,
                                        PersonalInformation2 = w.Type,
                                        PersonalInformation3 = w.PersonId,
                                        Students = q.StudentId,

                                    };
                        Console.WriteLine("Name:   LastName:     Type:     StudentId: ");
                        foreach (var x in Join2)
                        {

                            Console.WriteLine(x.PersonalInformation + " \t " + x.PersonalInformation1 + " \t " + x.PersonalInformation2 + "\t" + x.Students + "\t ");
                        }
                        break;
                    case "3":
                        var Join3 = from q in Context.Students
                                    join w in Context.PersonalInformations on q.FkPersonIdStudent equals w.PersonId
                                    orderby w.Lname ascending
                                    select new
                                    {
                                        PersonalInformation = w.Fname,
                                        PersonalInformation1 = w.Lname,
                                        PersonalInformation2 = w.Type,
                                        PersonalInformation3 = w.PersonId,
                                        Students = q.StudentId,

                                    };
                        Console.WriteLine("Name:   LastName:     Type:     StudentId: ");
                        foreach (var x in Join3)
                        {

                            Console.WriteLine(x.PersonalInformation + " \t " + x.PersonalInformation1 + " \t " + x.PersonalInformation2 + "\t" + x.Students + "\t ");
                        }

                        break;
                    case "4":
                        var Join4 = from q in Context.Students
                                    join w in Context.PersonalInformations on q.FkPersonIdStudent equals w.PersonId
                                    orderby w.Lname descending
                                    select new
                                    {
                                        PersonalInformation = w.Fname,
                                        PersonalInformation1 = w.Lname,
                                        PersonalInformation2 = w.Type,
                                        PersonalInformation3 = w.PersonId,
                                        Students = q.StudentId,

                                    };
                        Console.WriteLine("Name:   LastName:     Type:     StudentId: ");
                        foreach (var x in Join4)
                        {

                            Console.WriteLine(x.PersonalInformation + " \t " + x.PersonalInformation1 + " \t " + x.PersonalInformation2 + "\t" + x.Students + "\t ");
                        }
                        break;

                }


            }

            Console.WriteLine(new string('-', (60)));

            using (AhlingsSchoolDbContext Context = new AhlingsSchoolDbContext())
            {


                var Join = from q in Context.Students
                           join w in Context.PersonalInformations on q.FkPersonIdStudent equals w.PersonId
                           join e in Context.Classes on q.FkClassId equals e.ClassId
                           select new
                           {
                               Classes = e.ClassName
                           };
                Console.WriteLine("ClassName ");
                foreach (var x in Join)
                {

                    Console.WriteLine(" " + x.Classes);
                }

                Console.WriteLine(new string('-', (60)));

                Console.WriteLine("Type the class you want to check to the letter: ");
                var userInput = Console.ReadLine();
                
                var classChoice = from a in Context.Schools
                                  join e in Context.Students on a.FkStudentId equals e.StudentId
                                  join b in Context.PersonalInformations on e.FkPersonIdStudent equals b.PersonId
                                  join c in Context.Classes on e.FkClassId equals c.ClassId
                                  join n in Context.GradingTables on c.FkGradingTable equals n.GradingId
                                  where a.FkClassName == userInput
                                  select new
                                  {
                                      Names = b.Fname,
                                      grade = n.Grade,
                                      gradeset = n.GradeSet


                                  };
                
                Console.WriteLine("Name:     Grade:     GradingDate   ");
                foreach (var c in classChoice)
                {
                    Console.WriteLine($"{c.Names}     {c.grade}       {c.gradeset}");


                }

                Console.WriteLine(new string('-', (60)));


                Console.WriteLine("Which class would you like to see the average score in?");
                var Average = Console.ReadLine();
                var gradeAverage = (from a in Context.GradingTables
                                    join b in Context.Classes on a.FkClassId equals b.ClassId
                                    where b.ClassName == Average
                                    select a.Grade).Average();
                var gradeAverage1 = (from a in Context.GradingTables
                                    join b in Context.Classes on a.FkClassId equals b.ClassId
                                    where b.ClassName == Average
                                    select a.Grade).Max();
                var gradeAverage2 = (from a in Context.GradingTables
                                     join b in Context.Classes on a.FkClassId equals b.ClassId
                                     where b.ClassName == Average
                                     select a.Grade).Min();


                Console.WriteLine($"MaxScore: {gradeAverage1}\nMinScore {gradeAverage2}\nAverageScore {gradeAverage}");
                Console.WriteLine(new string('-', (60)));



            }
            Console.WriteLine(new string('-', (60)));
            using (AhlingsSchoolDbContext context = new AhlingsSchoolDbContext())
            {
                PersonalInformation p1 = new PersonalInformation();
                Console.WriteLine("Type the name of the person");
                p1.Fname = Console.ReadLine();
                Console.WriteLine("Last Name");
                p1.Lname = Console.ReadLine();
                Console.WriteLine("Birthdate");
                Console.WriteLine("Input Format need to be \n:0000,00,00");
                string birthdate = Console.ReadLine();
                p1.Birthdate = Convert.ToDateTime(birthdate);
                Console.WriteLine("Write your email");
                p1.Mail = Console.ReadLine();
                Console.WriteLine("Write your social security number as: 00000000-0000");
                p1.Ssnumber = Console.ReadLine();
                Console.WriteLine("type 1 for  student and type 2 for employee");
                string type = Console.ReadLine();
                p1.Type = Convert.ToInt32(type);
                //context.PersonalInformations.Add(p1);
                //context.SaveChanges();
            }
            Console.WriteLine("Ditt program fungerar helt okej");
            Console.ReadKey();
        }
    }
}