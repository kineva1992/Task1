using System;
using Task1.Modal;

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
                    var employ = db.Employee;

                    foreach (var item in employ)
                    {
                        Console.WriteLine("{0} {1} {2}", item.Id, item.Name, item.Salary);
                    }
                }
                catch (ExecutionEngineException ex)
                {
                    Console.WriteLine($"{ex}");
                }
            }
            
        }
    }
}
