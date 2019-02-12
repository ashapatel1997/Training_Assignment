using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

public class Program
{
    List<Employee> employeeList;
    List<Salary> salaryList;

    public Program()
    {
        employeeList = new List<Employee> {
            new Employee(){ EmployeeID = 1, EmployeeFirstName = "Rajiv", EmployeeLastName = "Desai", Age = 49},
            new Employee(){ EmployeeID = 2, EmployeeFirstName = "Karan", EmployeeLastName = "Patel", Age = 32},
            new Employee(){ EmployeeID = 3, EmployeeFirstName = "Sujit", EmployeeLastName = "Dixit", Age = 28},
            new Employee(){ EmployeeID = 4, EmployeeFirstName = "Mahendra", EmployeeLastName = "Suri", Age = 26},
            new Employee(){ EmployeeID = 5, EmployeeFirstName = "Divya", EmployeeLastName = "Das", Age = 20},
            new Employee(){ EmployeeID = 6, EmployeeFirstName = "Ridhi", EmployeeLastName = "Shah", Age = 60},
            new Employee(){ EmployeeID = 7, EmployeeFirstName = "Dimple", EmployeeLastName = "Bhatt", Age = 53}
        };

        salaryList = new List<Salary> {
            new Salary(){ EmployeeID = 1, Amount = 1000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 1, Amount = 500, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 1, Amount = 100, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 2, Amount = 3000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 2, Amount = 1000, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 3, Amount = 1500, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 4, Amount = 2100, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 5, Amount = 2800, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 5, Amount = 600, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 5, Amount = 500, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 6, Amount = 3000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 6, Amount = 400, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 7, Amount = 4700, Type = SalaryType.Monthly}
        };
    }

    public static void Main()
    {
        Program program = new Program();

        program.Task1();

        program.Task2();

        program.Task3();
    }

    public void Task1()
    {
        //Implementation
        var query = (from e in employeeList
                     join s in salaryList on e.EmployeeID equals s.EmployeeID
                     group s.Amount by new
                     {
                         s.EmployeeID,
                        e.EmployeeFirstName,
                         e.EmployeeLastName
                     } into totalSal
                     select new
                     {
                         firstName = totalSal.Key.EmployeeFirstName,
                         lastName=totalSal.Key.EmployeeLastName,
                         sal = totalSal.Sum()
                     }).OrderBy(x => x.sal);

        Console.WriteLine("----------------Task 1-------------- ");
        foreach (var x in query)
        {
              Console.WriteLine("Name:"+x.firstName + " "+x.lastName + "\n"+"Salary:"+x.sal+"\n\n");
        }


    }

    public void Task2()
    { 
        var query = (from e in employeeList
                    join s in salaryList on e.EmployeeID equals s.EmployeeID
                    where s.Type.Equals(SalaryType.Monthly)
                    select new
                    {
                        id=e.EmployeeID,
                        fName=e.EmployeeFirstName,
                        lName=e.EmployeeLastName,
                        age=e.Age,
                        salary=s.Amount
                    }).OrderByDescending(x=>x.age).Skip(1).First();
        Console.WriteLine("\n\n----------------Task 2-------------- ");
        Console.WriteLine("2nd Largest Age:" + query.age + "\nId:" + query.id + "\nFirst Name:" + query.fName + "\nLast Name:" + query.lName + "\nMonthly Salary:" + query.salary +"\n\n");
    }

    public void Task3()
    {
        var groupById = from e in employeeList
                        join s in salaryList on e.EmployeeID equals s.EmployeeID
                        where e.Age > 30
                        select new
                        {
                            id = s.EmployeeID,
                            type = s.Type,
                            amount = s.Amount
                        };
        var query = from g in groupById.GroupBy(id => id.id) select g;
                  
        var monthly = 0;
        var perfomance = 0;
        var bonus = 0;
        foreach (var data in groupById)
        {
            if (data.type.Equals(SalaryType.Monthly))
                monthly += data.amount;
            if (data.type.Equals(SalaryType.Performance))
                perfomance += data.amount;
            if (data.type.Equals(SalaryType.Bonus))
                bonus += data.amount;
        }

        Console.WriteLine("\n\n----------------Task 3-------------- ");
        Console.WriteLine("Mean of Monthly Salary: " + monthly/query.Count());
        Console.WriteLine("Mean of Performance Salary: " + perfomance / query.Count());
        Console.WriteLine("Mean of Bonus Salary: " + bonus / query.Count()+"\n");

    }
    public enum SalaryType
    {
        Monthly,
        Performance,
        Bonus
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int Age { get; set; }
    }

    public class Salary
    {
        public int EmployeeID { get; set; }
        public int Amount { get; set; }
        public SalaryType Type { get; set; }
    }
}