using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Linq;

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

            //Print the Sum of numbers
            List<int> numberList = new List<int>();

            foreach (int number in numbers)
            {
                numberList.Add(numbers[number]);
            }

            //Print the Sum of numbers
            var sum = numberList.Sum();
            Console.WriteLine($"The sum of the list is {sum}");
            Console.WriteLine();

            //Print the Average of numbers
            var average = numbers.Average();

            Console.WriteLine($"The average of the list is {average}");
            Console.WriteLine();

            //Order numbers in descending order and print to the console
            Console.WriteLine($"List in descending order: ");

            var numberListDSC = numberList.OrderByDescending(x => x);
            foreach (var i in numberListDSC) 
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Order numbers in decsending order and print to the console
            Console.WriteLine($"List in ascending order: ");

            var numberListASC = numberList.OrderBy(x => x);
            foreach (var j in numberListASC)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Print to the console only the numbers greater than 6
            Console.WriteLine("Print out numbers in list greater than 6:");
            var numGrt6 = numbers.Where(x => x > 6);
            foreach (var k in numGrt6)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Order numbers in any order (acsending or desc) but only print 4
            //of them **foreach loop only!**
            Console.WriteLine("Print out first 4 elements:");
            var numFirst4 = numbers.Take(4);
            foreach (var m in numFirst4)
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Change the value at index 4 to your age, then print the
            //numbers in descending order
            Console.WriteLine("Print out age at index[4] and list descending:");
            numbers[4] = 58;
            var numAgeDesc = numbers.OrderByDescending(x => x);
            foreach (var n in numAgeDesc)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
            Console.WriteLine();





            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the
            //console only if their FirstName starts with a
            //C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Print C or S FirstName employees to console: ");
            var chosen =
                employees.Where(f => f.FirstName.StartsWith('C') || f.FirstName.StartsWith('S')).OrderBy(f => f.FirstName);

            foreach (var item in chosen)
            {
                Console.WriteLine(item.FullName);
            }
            Console.WriteLine();

            //Print all the employees' FullName and Age who are over the age 26
            //to the console and order this by Age first and then by
            //FirstName in the same result.
            Console.WriteLine("Print FullName employees over 26 to console: ");
            var chosen2 =
                employees.Where(f => f.Age > 26).OrderBy(f => f.Age).ThenBy(f => f.FirstName);
     
            foreach (var item in chosen2)
            {
                Console.WriteLine($"{item.FullName}, { item.Age}");
            }
            Console.WriteLine();

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Print Sum and Avg of Years Of Experience < 10 employees over 35 to console: ");
            var chosen3 =
                employees.Where(f => f.Age > 35 && f.YearsOfExperience <=10);

            foreach (var item in chosen3)
            {
                Console.WriteLine($"{item.FullName}, {item.Age}, Experience = {item.YearsOfExperience}");
            }
            Console.WriteLine($"Sum of Experience of Employees over 35: {chosen3.Sum(f => f.YearsOfExperience)}");
            Console.WriteLine($"Avg of Experience of Employees over 35: {Math.Round(chosen3.Average(f => f.YearsOfExperience), 2)}");
            Console.WriteLine();

            //Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Add an employee to the list: ");
            employees = employees.Append(new Employee("Jill", "Reese", 58, 7)).ToList();
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.FullName}, \tAge: {item.Age}, Years of Experience: {item.YearsOfExperience}");
            }


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
