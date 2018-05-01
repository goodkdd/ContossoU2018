using ContossoU2018.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContossoU2018.Data
{
    public class SchoolContext:DbContext
    {
        //contructor to create using a shortcut ctor tap tap
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {

        }

        //specify the entoty sets - corresponding to database tables each entity corresponds to a row in a table

        public DbSet<Person> People { get;  set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        //Plural names will be used in this case because the EF will create a database with the table names mathing
        //the DBSet property names.
        //property names for collections are typically plural (Student ratcher than Student),but many developers
        //disagree about wether table names should be plural or not.
        //Later - we will override the naming of the tables

    }
}
