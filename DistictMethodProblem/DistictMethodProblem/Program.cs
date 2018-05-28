using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistictMethodProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployees = new List<Employee>
{
new Employee{Name="Harry",Age=15},
new Employee{Name="Peter",Age=22},
new Employee{Name="John",Age=45},
new Employee{Name="Harry",Age=16},
new Employee{Name="Peter",Age=23},
new Employee{Name="John",Age=46},
};
            List<Employee1> lstEmployees1 = new List<Employee1>
{
new Employee1{Name="Harry",Age=15},
new Employee1{Name="Peter",Age=22},
new Employee1{Name="John",Age=45},
new Employee1{Name="Harry",Age=16},
new Employee1{Name="Peter",Age=23},
new Employee1{Name="John",Age=46},
}; List<Employee2> lstEmployees2 = new List<Employee2>
{
new Employee2{Name="Harry",Age=15},
new Employee2{Name="Peter",Age=22},
new Employee2{Name="John",Age=45},
new Employee2{Name="Harry",Age=16},
new Employee2{Name="Peter",Age=23},
new Employee2{Name="John",Age=46},
}; List<Employee3> lstEmployees3 = new List<Employee3>
{
new Employee3{Name="Harry",Age=15},
new Employee3{Name="Peter",Age=22},
new Employee3{Name="John",Age=45},
new Employee3{Name="Harry",Age=16},
new Employee3{Name="Peter",Age=23},
new Employee3{Name="John",Age=46},
};
            List<Employee> distinctEmployeesByName = lstEmployees.Distinct().ToList();
            foreach (var item in distinctEmployeesByName)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            Console.WriteLine(")))))))))))))))))))");
            List<Employee1> distinctEmployeesByName1 = lstEmployees1.Distinct(new EmployeeEquityComparable()).ToList();
            foreach (var item in distinctEmployeesByName)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            Console.WriteLine(")))))))))))))))))))");
            List<Employee2> distinctEmployeesByName2 = lstEmployees2.Distinct().ToList();// ays depqum porcum e hamematel default compererov 
            //bayc classum implement e arvac voch te objectin@ ayl interfacn e implement arvac u trvac che vorpes comper argument ete tanq new Employee3() apa kashxati :D 
            foreach (var item in distinctEmployeesByName2)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            Console.WriteLine(")))))))))))))))))))");

            List<Employee3> distinctEmployeesByName3 =
            (from emp in lstEmployees3
             group emp by emp.Name
             into gemp
             select gemp.First()).ToList();
            foreach (var item in distinctEmployeesByName3)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            Console.WriteLine(")))))))))))))))))))");

        }
        public class Employee
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public override bool Equals(object obj)
            {
                return this.Name.Equals(((Employee)obj).Name);
            }
            public override int GetHashCode()
            {
                return this.Name.GetHashCode();
            }
        }
        public class Employee1
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        public class EmployeeEquityComparable : IEqualityComparer<Employee1>
        {
            #region  IEqualityComparer<Employee> Members 

            public bool Equals(Employee1 x, Employee1 y)

            { return x.Name.Equals(y.Name); }
            public int GetHashCode(Employee1 obj)
            { return obj.Name.GetHashCode(); }
            #endregion
        }
        public class Employee2 : IEqualityComparer<Employee2>
        {
            public int Age { get; set; }
            public string Name { get; set; }
            #region IEqualityComparer<Employee> Members 
            public bool Equals(Employee2 x, Employee2 y)
            { return x.Name.Equals(y.Name); }
            public int GetHashCode(Employee2 obj)
            { return obj.Name.GetHashCode(); }
            #endregion
        }
        public class Employee3
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
    }
}
