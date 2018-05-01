using ContossoU2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContossoU2018.Data
{
   
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {

            //EnsureCreated method will automatically create the database if it doea not already exists
            context.Database.EnsureCreated();

            //First look for any students
            //===================================Students===============================//
                if(context.Student.Any())
            {
                //Database has already been seeded with student
                return; //exits
            }
            //if we get here - student do not already exist - seed
            var students = new Student[]
            {
                    new Student
                    {
                        FirstName = "Carson",
                        LastName = "Alexander",
                        Email= "calexander@contoso.com",
                        EnrollmentDate = DateTime.Parse("2017-09-01"),
                        Address = " 4 Flanders Court",
                        City = "Moncton",
                        Province = "NB",
                        PostalCode = "E1C 0K6"
                    },

                    new Student
                    {
                        FirstName = "Meridith",
                        LastName = "Alonso",
                        Email= "MAlonso@contoso.com",
                        EnrollmentDate = DateTime.Parse("2017-09-01"),
                        Address = " 205 Argyle",
                        City = "Moncton",
                        Province = "NB",
                        PostalCode = "E1C 8V2"
                    },
            };

            //Loop the students array and add each student to the database context
            foreach(Student s in students)
            {
                context.Student.Add(s);
            }
            //save context
            context.SaveChanges();

            //===================================Instructors===============================//
            var instructors = new Instructor[]
            {
                new Instructor
                {
                        FirstName = "Patrick",
                        LastName = "Martin",
                        Email= "pmartin@faculty.contoso.com",
                        HireDate = DateTime.Parse("1996-01-31"),
                        Address = " 41 Jeannette Street",
                        City = "Dieppe",
                        Province = "NB",
                        PostalCode = "E1A 6A4"
                },

                 new Instructor
                {
                        FirstName = "Frank",
                        LastName = "Bekkering",
                        Email= "fbekkering@faculty.contoso.com",
                        HireDate = DateTime.Parse("1976-01-31"),
                        Address = "75 There Street",
                        City = "Moncton",
                        Province = "NB",
                        PostalCode = "E1A 6A4"
                }
            };
            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            //save context
            context.SaveChanges();

            //===================================Courses===============================//
            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="MicroEconomics",Credits=3}
            };
            foreach (Course c in courses)
            {
                context.Add(c);
            }
            //save context
            context.SaveChanges();

            //===================================Enrollment===============================//
            var enrollments = new Enrollment[]
            {
                new Enrollment{CourseID=1050,StudentID=students.Single(s=>s.LastName=="Alexander").ID,Grade=Grade.A},
                new Enrollment{CourseID=4022,StudentID=students.Single(s=>s.LastName=="Alonso").ID,Grade=Grade.B}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            //save context
            context.SaveChanges();
        }
    }
}
