using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task1.Modal
{
    class Employee
    {
        public int Id { get; set; }
        public int? Chief_id { get; set; }

        [MaxLength(100)]
        [Display(Name="Имя сотрудника")]
        public string Name { get; set; }

        [Display(Name="Зарплата")]
        public int Salary { get; set; }

        public int? DepartamentId { get; set; }
        public Departament Departament { get; set; }
    }
}
