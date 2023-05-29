using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirstApproach_EntityFw.Models;

namespace CodeFirstApproach_EntityFw
{
    /// <summary>
    /// This is Data Context class, and helps to fetch data from Database
    /// corresponding to the Student Model class and to transfer it to the View 
    /// with the help of Controller.
    /// </summary>
    public class StudentContext : DbContext
    {
        /// <summary>
        /// Entity Fw will create a Table in DB with this name.
        /// <para>Because Students is a DbSet Collection of Type Student Model Class.</para>
        /// </summary>
        public DbSet<Student> Students { get; set; }

    }
}