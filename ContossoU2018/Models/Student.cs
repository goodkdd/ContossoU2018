using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContossoU2018.Models
{
    public class Student:Person // Student inherits from Person
    {
        //Student specific properties
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        //1 student: many enrollments - This id the navigation property between student and enrellments
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        /*
         * The enrollments property is a navigation property (EF core). Navigation properties hold other entities
         * that are related to this entity. In this case, the enrollments property of a student entity will hold
         * all of the enrollments that are related to that student.
         * 
         * In other words, if a given row in the database has two related enrollment rows
         * (rows that contain that student's PK value in thier foreign key column), that student entity's enrollment
         * navigation property will contain those two enrollment entities.
         * 
         * Navigation properties are typically defined as virtuel so that they can take advantage of certain EF
         * functionality such as lazy loading is not yet available in Ef core (but has in EF 5, 6...)
         * Note : Lazy loading is not yet enable by default - so that means that when a particular student
         * entity is instantiated it will automatically load all related entities.
         
         */
    }
}
