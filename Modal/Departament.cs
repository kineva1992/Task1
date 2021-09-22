using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task1.Modal
{
    class Departament
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Display(Name="Департамент работы")]
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
