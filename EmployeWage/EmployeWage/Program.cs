// See https://aka.ms/new-console-template for more information

using EmployeWage;

Console.WriteLine("Hello, World!");
EmpWage empWage = new EmpWage();
empWage.AddCompany("Parle", 20, 30, 50);
empWage.AddCompany("Dell", 20, 30, 100);
empWage.GetWage();
Console.WriteLine("Total Wage for Company is: " + empWage.GetTotalWage("Parle"));
Console.WriteLine("Total Wage for Company is: " + empWage.GetTotalWage("Dell"));
Console.ReadLine();