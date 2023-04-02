using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employeeOne = new Employee() { firstName = "Ana", lastName = "Trump" };
            //employeeOne.SayName();

            IQuittable employeeTwo = new Employee();
            employeeTwo.Quit();
            Console.ReadLine();
        }
    }
}
