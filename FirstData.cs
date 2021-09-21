using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Task1.Modal;

namespace Task1
{
    class FirstData : DbContext
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Departament>().HasData(
        //        new Departament[]
        //        {
        //        new Departament{ Name="D1"},
        //        new Departament{ Name="D2"},
        //        new Departament{ Name="D3"}
        //        });

        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee[] 
        //        { 
        //            new Employee { DepartamentId = 1, Chief_id = 5, Name = "John", Salary = 100 },
        //            new Employee { DepartamentId = 1, Chief_id = 5, Name = "Misha", Salary = 600 },
        //            new Employee { DepartamentId = 2, Chief_id = 6, Name = "Eugen", Salary = 300 },
        //            new Employee { DepartamentId = 2, Chief_id = 6, Name = "Tolya", Salary = 400 },
        //            new Employee { DepartamentId = 3, Chief_id = 7, Name = "Stepan", Salary = 500 },
        //            new Employee { DepartamentId = 3, Chief_id = 7, Name = "Alex", Salary = 1000 },
        //            new Employee { DepartamentId = 3, Chief_id = null, Name = "Ivan", Salary = 1000 }
        //        });

            
        //}
    }
}
