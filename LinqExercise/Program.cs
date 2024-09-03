using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum of numbers (DONE)
            Console.WriteLine("Sum of numbers: ");
            var sum = numbers.Sum();
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("--------------------------------");

            //Print the Average of numbers (DONE)
            Console.WriteLine("The average of all numbers: ");
            var average = numbers.Average();
            Console.WriteLine(numbers.Average());
            Console.WriteLine("--------------------------------");
            
            //Order numbers in ascending order and print to the console (DONE)
            Console.WriteLine("The number in ascending order: ");
            numbers.OrderBy(x => x).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("--------------------------------");

            //Order numbers in descending order and print to the console (DONE)
            Console.WriteLine("The number in descending order: ");
           var numbersDescending = numbers.OrderByDescending(x => x);

           foreach (var number in numbersDescending)
           {
               Console.WriteLine(number);
               
           }
           Console.WriteLine("--------------------------------");

            //Print to the console only the numbers greater than 6 (DONE)
            Console.WriteLine("The numbers greater than 6 are: ");
            numbers.Where(x=>x>6).ToList().ForEach(x =>Console.WriteLine(x));
            Console.WriteLine("--------------------------------");
            
            

            //Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!** (DONE)
            
            Console.WriteLine("Prints only four numbers: ");
            var prints4 = numbers.OrderBy(x => x).Take(4);

            foreach (var item in prints4)
            {
                Console.WriteLine(item);
                
            }
            
            Console.WriteLine("--------------------------------");
            
            

            //Change the value at index 4 to your age, then print the numbers in descending order (DONE)
            
            Console.WriteLine("Changing the values of index four to 21: ");
            numbers.SetValue(21, 4);

            foreach (var item in numbersDescending)
            {
                Console.WriteLine(item);
                
            }
            
            Console.WriteLine("--------------------------------");
            
           
            // List of employees ****Do not remove this**** (DONE)
            List<Employee> employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName. (DONE)
            Console.WriteLine("All names that start with C or S: ");
            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S'))
                .OrderBy(x => x.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine(x.FullName));
            
            Console.WriteLine("--------------------------------");

            //Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result. (DONE)
            Console.WriteLine("Employees that are over 26 years old: ");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($" First Name: {x.FirstName} Age: {x.Age}"));
            Console.WriteLine("--------------------------------");
            
            //Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35. (DONE)
            Console.WriteLine("Sum of YOE: ");
            int employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine("--------------------------------");
            
            //Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35. (DONE)
            Console.WriteLine("Average of YOE: ");
            double employeeAverage = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(employeeAverage);
            Console.WriteLine("--------------------------------");
            
            
            
            //Add an employee to the end of the list without using employees.Add() (DONE)
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Anthony";
            newEmployee.LastName = "Smith";
            newEmployee.YearsOfExperience = 4;
            
            
            
            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Here's the original list");

            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }
            
            
            Console.WriteLine("--------------------------------");
            
            

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
