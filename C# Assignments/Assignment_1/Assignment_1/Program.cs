using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            int id;
            string name,departName;
            Console.WriteLine("Employee Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Name:");
            name = Console.ReadLine();
            Console.WriteLine("Department Name:");
            departName = Console.ReadLine()+"\n\n";

            //object of Employee class
            Employee employee = new Employee(id,name,departName);
            
            //event subscriber method
            employee.EmployeeEvent += methodCalled;

            //this will invoke after each method of Employee class is called.
            void methodCalled(string message)
            {
                Console.WriteLine("{0} method called", message);
            }

            //print employee data
            Console.WriteLine("Employee Id:" + employee.GetId()+"\n");
            Console.WriteLine("Employee Name:" + employee.GetName()+"\n");
            Console.WriteLine("Department Name:" + employee.GetDepartmentName());

      
            Console.WriteLine("\nEnter new Employee Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Employee Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter new Department Name:");
            departName = Console.ReadLine() + "\n\n";
       
            //print updated employee data
            Console.WriteLine("\nEmployee Id:" + employee.GetId(id) + "\n");
            Console.WriteLine("Employee Name:" + employee.GetName(name) + "\n");
            Console.WriteLine("Department Name:" + employee.GetDepartmentName(departName) + "\n");


        }
    }
}
