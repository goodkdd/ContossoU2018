using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContossoU2018.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        /*
         * You can turn off Identity (on by default) by using the option above
         * you have the following 3 options:
         * None - Database does not generate a value
         * Indentity - Database generates a value when a row is inserted
         * Computed - Database generated a value when a row is inserted or updated
         */
        public int CourseID { get; set; }//PK
        public string Title { get; set; }
        public int Credits { get; set; }

        //Navigation properties
        //1. course: many enrollement
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}