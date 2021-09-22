using System;
using Task1.Modal;
using System.Linq;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            using (Task1Context db = new Task1Context())
            {
                try
                {


                    ////Сумма зарплат всех сотрудников по всем департаментам
                    Console.WriteLine("Сумма зарплат всех сотрудников по всем департаментам");
                    var countMoneyWithManager = db.Employee.Where(p => p.DepartamentId == 1 || p.DepartamentId == 2 || p.DepartamentId == 3).
                        Sum(m => m.Salary);
                    Console.WriteLine($"Зарптала всех сотрудников: {countMoneyWithManager}");

                    ////Зарптала без руводителей сотрудников
                    Console.WriteLine("Зарптала без руводителей сотрудников");
                    var countMoneyNotManager = db.Employee.Where(p => p.DepartamentId == 1 || p.DepartamentId == 2 || p.DepartamentId == 3).
                        Where(s => s.Chief_id == 5 || s.Chief_id == 6).
                        Sum(m => m.Salary);
                    Console.WriteLine($"Зарптала без руводителей сотрудников: {countMoneyNotManager}");

                    //Департамент, в котором у сотрудника зарплата максимальна
                    Console.WriteLine("Департамент, в котором у сотрудника зарплата максимальна");
                    var departamentWhereMoneyMax = db.Employee.Max(s => s.Salary);
                    var departametntScallyResult = db.Employee.Where(s => s.Salary == departamentWhereMoneyMax);
                    foreach (var i in departametntScallyResult)
                    {
                        Console.WriteLine("{0} {1} - {2}", i.Name, i.Salary, i.DepartamentId);
                    }
                    Console.WriteLine($"{departamentWhereMoneyMax}");

                    //Зарплаты руководителей департаментов (по убыванию)
                    Console.WriteLine("Зарплаты руководителей департаментов (по убыванию)");
                    var salaryManager = db.Employee.Where(t => t.Chief_id == 7).OrderByDescending(o => o.Name);
                    foreach (var i in salaryManager)
                    {
                        Console.WriteLine("{0} {1} {2} {3}",i.Id, i.Name, i.Salary, i.Chief_id);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
            
        }
    }
}
