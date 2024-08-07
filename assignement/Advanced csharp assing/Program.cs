﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_csharp_assing
{
    public class Program
{
    public static bool PromotionCriteriaSalary(Employee emp) => emp.Salary < 10000;
    public static bool PromotionCriteriaExperience(Employee emp) => emp.Experience > 5;

    public static List<Employee> Promote(List<Employee> employees, Func<Employee, bool> criteria)
    {
        return employees.Where(criteria).ToList();
    }

    public static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amr", Salary = 9000, Experience = 6 },
            new Employee { Id = 2, Name = "trika", Salary = 12000, Experience = 4 }
        };

        var promotedEmployeesSalary = Promote(employees, PromotionCriteriaSalary);
        var promotedEmployeesExperience = Promote(employees, PromotionCriteriaExperience);

        Console.WriteLine("Promoted by Salary:");
        promotedEmployeesSalary.ForEach(e => Console.WriteLine(e.Name));

        Console.WriteLine("Promoted by Experience:");
        promotedEmployeesExperience.ForEach(e => Console.WriteLine(e.Name));

        // Multicast delegate example
        Func<int, int, int> sum = (a, b) => a + b;
        Func<int, int, int> subtract = (a, b) => a - b;
        Func<int, int, int> multiply = (a, b) => a * b;
        Func<int, int, int> divide = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

        var operations = sum + subtract + multiply + divide;
        foreach (var operation in operations.GetInvocationList())
        {
            Console.WriteLine(operation.DynamicInvoke(10, 2));
        }
    }
}
}