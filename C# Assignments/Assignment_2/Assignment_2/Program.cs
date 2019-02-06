using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public abstract class BasicInfo
    {
        protected int Id , ExperienceInYear;
        protected string Name,Designation,JoiningDate;
        protected double AnnualSalary;

       
        public BasicInfo(int Id, string Name, string Designation, int ExperienceInYear, string JoiningDate,  double AnnualSalary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Designation = Designation;
           this.ExperienceInYear = ExperienceInYear;
            this.AnnualSalary = AnnualSalary;
            this.JoiningDate = JoiningDate;
        }
        public abstract float Salary();
    }

    public class HR:BasicInfo
    {
        int BasicSalary;
        public HR(int Id,string Name,string Designation, int ExperienceInYear,string JoiningDate, double AnnualSalary, int BasicSalary) :base(Id,Name,Designation,ExperienceInYear,JoiningDate,AnnualSalary)
        {
         
            this.BasicSalary = BasicSalary;
        }
        
        public override float Salary()
        {
            return (BasicSalary + (1000 * ExperienceInYear));
        }
    }

    public class Developer:BasicInfo
    {
        int BasicSalary;

        public Developer(int Id, string Name, string Designation, int ExperienceInYear, string JoiningDate, double AnnualSalary, int BasicSalary) : base(Id, Name, Designation, ExperienceInYear, JoiningDate, AnnualSalary)
        {

            this.BasicSalary = BasicSalary;
        }
        public override float Salary()
        {
            return (BasicSalary + (2000 * ExperienceInYear));
        }

    }

    public class Program
    {

        static void Main(string[] args)
        {
            HR hr = new HR(1,"abc","HR",4, "5 january 2014",100000,8000);
            Developer developer = new Developer(1, "xyz", "developer", 5, "5 january 2013", 100000, 8000);

            Console.WriteLine("Salary of HR=" + hr.Salary());
            Console.WriteLine("Salary of Developer=" + developer.Salary());
        }
    }

}
