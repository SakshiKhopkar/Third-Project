using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Project.Collections_Implement;

namespace Third_Project.Generic_Assignments
{
    public class Employeeimple
    {
        private string name;
        private int salary;

        public string Name { get { return name; } set {  name = value; } }
        public int Salary { get {  return salary; } set {  salary = value; } }

    }
    public class Getsalary : IComparer<Employeeimple>
    {
        public int Compare(Employeeimple x, Employeeimple y)
        {
                if (x.Salary > y.Salary)
                {
                    return 1;
                }
                else if (x.Salary < y.Salary)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            

        }
    }
    public class RunEmployeeimple
    {
        static void Main(string[] args)
        {
            Employeeimple e1 = new Employeeimple { Name="sachin",Salary=85000};
            Employeeimple e2 = new Employeeimple { Name = "sarita", Salary = 86000 };
            Getsalary c= new Getsalary();
            int result=c.Compare(e1, e2);
            if (result == 1)
            {
                Console.WriteLine(" salary of sachin is heigher than the sarita");
            }
            else if(result == -1)
            {
                Console.WriteLine("salary of sachin is less than the salary of sarita");
            }
            else
            {
                Console.WriteLine("sachin and sarita has same salary");
            }
        }
    }
}
