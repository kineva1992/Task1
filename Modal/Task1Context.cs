using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Task1.Modal
{
    class Task1Context : DbContext
    {
        public Task1Context() : base("Task1ContextString")
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Departament> Departaments { get; set; }

        
    }
}
