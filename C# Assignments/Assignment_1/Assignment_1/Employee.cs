using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public delegate void EmployeeDelegate(string message);
    class Employee
    {
        private string Name, DepartmentName;
        private int Id;
       
       public event EmployeeDelegate EmployeeEvent;

       
       
        public Employee(int id, string name, string departName)
        {
            Id = id;
            Name = name;
            DepartmentName = departName;
        }

       
        public int GetId()
        {
            if (EmployeeEvent != null)
            {
                EmployeeEvent.Invoke("GetId()");

            }
            return Id;
        }

        public int GetId(int id)
        {
            return id;
        }


        public string GetName()
        {
            if (EmployeeEvent != null)
            {
                EmployeeEvent.Invoke("GetName()");

            }
            return Name;
        }

        public string GetName(string name)
        {
            return name;
        }

        public string GetDepartmentName()
        {
            if (EmployeeEvent != null)
            {
                EmployeeEvent.Invoke("GetDepartmentName()");

            }
            return DepartmentName;
        }
       
        public string GetDepartmentName(string departmentName)
        {
            return departmentName;
        }

    }
}
