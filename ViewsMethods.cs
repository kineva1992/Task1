using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1.Modal;

namespace Task1
{
    class ViewsMethods
    {
        public static void Task1()
        {
            using (Task1Context db = new Task1Context())
            {
                try
                {
                    ////Сумма зарплат всех сотрудников по всем департаментам
                    Console.WriteLine("Сумма зарплат всех сотрудников по всем департаментам");
                    var countMoneyWithManager = db.Employee.Where(p => p.DepartamentId <= 3).
                        Sum(m => m.Salary);
                    Console.WriteLine($"Зарптала всех сотрудников: {countMoneyWithManager}");

                    //Зарптала без руводителей сотрудников
                    Console.WriteLine("Зарптала без руводителей сотрудников");
                    var countMoneyNotManager = db.Employee.Where(p => p.DepartamentId <= 3).
                        Where(s => s.Chief_id == 5 || s.Chief_id == 6).
                        Sum(m => m.Salary);
                    Console.WriteLine($"Зарптала без руводителей сотрудников: {countMoneyNotManager}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void Task2()
        {
            using (Task1Context db = new Task1Context())
            {
                try
                {
                    //Департамент, в котором у сотрудника зарплата максимальна
                    Console.WriteLine("Департамент, в котором у сотрудника зарплата максимальна");
                    var maxSalary = db.Employee.Max(s => s.Salary);
                    var departametntScallyResult = db.Employee.Where(s => s.Salary == maxSalary);
                    foreach (var i in departametntScallyResult)
                    {
                        Console.WriteLine("{0} {1} - {2}", i.Name, i.Salary, i.DepartamentId);
                    }
                    Console.WriteLine($"{maxSalary}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void Task3()
        {
            using (Task1Context db = new Task1Context())
            {
                try
                {
                    //Зарплаты руководителей департаментов (по убыванию)
                    Console.WriteLine("Зарплаты руководителей департаментов (по убыванию)");
                    var salaryManager = db.Employee.Where(t => t.Chief_id == 7).OrderByDescending(o => o.Name);
                    foreach (var i in salaryManager)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", i.Id, i.Name, i.Salary, i.Chief_id);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
