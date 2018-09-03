using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnandhanRepository.Core.DomainObjecs;
using AnandhanRepository.Repository;
namespace AnandhanRepository.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            bool isRun = true;
            while (isRun)
            {
                System.Console.Clear();
                System.Console.WriteLine("Select a process");
                System.Console.WriteLine("1 - List Employees");
                System.Console.WriteLine("2 - Create a Employee");
                System.Console.WriteLine("3 - Exit");
                string inputKey = System.Console.ReadLine();
                System.Console.Clear();
                var source = RepositoryFactory.Create<IEmployeeRepository>(ContextTypes.XMLSource);
                if (inputKey == "1")
                {
                    
                    var items = source.GetAll();
                    foreach (var item in items)
                    {
                        System.Console.WriteLine(item.Name + " " + item.SurName + ": " + item.Classroom);
                    }
                }
                else if(inputKey == "2")
                {
                    Employee employee = new Employee();
                    System.Console.Write("Name: ");
                    employee.Name = System.Console.ReadLine();
                    System.Console.Write("SurName: ");
                    employee.SurName = System.Console.ReadLine();
                    System.Console.Write("Classroom: ");
                    employee.Classroom = System.Console.ReadLine();
                    System.Console.Clear();

                    // source = RepositoryFactory.Create<IEmployeeRepository>(ContextTypes.XMLSource);

                    try
                    {
                        source.Insert(employee);
                    }
                    catch (Exception ex)
                    {
                        System.Console.Write(ex);
                        System.Console.ReadKey();
                        continue;
                    }
                }
                else if (inputKey == "3")
                {
                    isRun = false;
                }
            }
        }
    }
}
