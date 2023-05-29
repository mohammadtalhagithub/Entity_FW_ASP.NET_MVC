using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach_EntityFw.Models
{
    /// <summary>
    /// This is the Model class, and has the structure of our data.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Id property is given a [Key] attribute for Primary Key
        /// </summary>
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }
    }
}