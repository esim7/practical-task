using System;

namespace EnumStructPract
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee_1 = Vacancie.Boss;           
            var employee_2 = Vacancie.Driver;
            Console.WriteLine(employee_1);
            Console.WriteLine(employee_2);

            Employee employee = new Employee();
            employee.Name = "Esimzhan";
            employee.Vacancy = Vacancie.Manager;
            employee.Wage = 199000;
            employee.DateOfReceipt[0] = 12;
            employee.DateOfReceipt[1] = 10;
            employee.DateOfReceipt[2] = 1990;

            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Vacancy);
            Console.WriteLine(employee.Wage);
            Console.WriteLine(employee.DateOfReceipt[0]);
            Console.WriteLine(employee.DateOfReceipt[1]);
            Console.WriteLine(employee.DateOfReceipt[2]);
            Console.ReadKey();

        }
    }
}
