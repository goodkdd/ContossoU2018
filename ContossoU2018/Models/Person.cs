using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContossoU2018.Models
{
    public abstract class Person
    {
        //Person properties - characteristics

/*
 These properties will become database within the person table
 by using the Entity Framework Core
 The Id property will become  the Primary Key Column of the database table that correspondes to this class (Person)
 By default the EF(Entoty Framework) interprets property that's named ID or ClassNameID as the PF
 for example:
 - ID
 - PersonID
 * */
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName  { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Province { get; set; }

        //Read Only properties
        [Display(Name ="Name")]
        public string FullName
        {
            get
            {
                //return LastName + ", " + FirstName;
                return FirstName + " " + LastName;
            }
        }

        public string IDFullName
        {
            get
            {
                return "(" + ID + ")" + LastName + ", " + FirstName;
            }
        }
        
    }
}
