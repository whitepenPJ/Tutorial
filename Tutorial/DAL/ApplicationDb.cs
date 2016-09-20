using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tutorial.Models;

namespace Tutorial.DAL
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb() : base("DefaultConnection")
        {

        }

        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}