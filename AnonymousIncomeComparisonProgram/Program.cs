using System;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //printing the start screen.

            Console.WriteLine("Anonymous Income Comparison Program.");
            
            Console.WriteLine("Person 1");

            //Enter your hourly rate of pay.
            Console.WriteLine("Enter your hourly rate of pay: ");
            //creating a double variable to capture the hourly rate of pay from the user's keyboard string entry and storing it.
            Double hourlyRatePerson1 = Convert.ToDouble(Console.ReadLine());
            //Enter the number of hours you work per week.
            Console.WriteLine("Enter the number of hours you work per week: ");            
            //creating a double variable to capture the number of hours worked per week from the user's keyboard string entry and storing it.
            Double hoursWorkedPerWeekPerson1 = Convert.ToDouble(Console.ReadLine());
            //creating a double variable to store the annual salary, calculating the annual salary and storing the result in the new variable.
            double annualSalaryOfPerson1 = hourlyRatePerson1 * hoursWorkedPerWeekPerson1 * 52;

            Console.WriteLine("Person 2");

            //Enter your hourly rate of pay.
            Console.WriteLine("Enter your hourly rate of pay: ");
            //creating a double variable to capture the hourly rate of pay from the user's keyboard string entry and storing it..
            Double hourlyRatePerson2 = Convert.ToDouble(Console.ReadLine());
            //Enter the number of hours you work per week.
            Console.WriteLine("Enter the number of hours you work per week: ");
            //creating a double variable to capture the number of hours worked per week from the user's keyboard string entry and storing it.
            Double hoursWorkedPerWeekPerson2 = Convert.ToDouble(Console.ReadLine());
            //creating a double variable to store the annual salary, calculating the annual salary and storing the result in the new variable.
            double annualSalaryOfPerson2 = hourlyRatePerson2 * hoursWorkedPerWeekPerson2 * 52;

            //Printing the values of the annual salary variables to display the result of the math operations.
            Console.WriteLine();
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine("£" + annualSalaryOfPerson1);
            Console.WriteLine();
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine("£" + annualSalaryOfPerson2);
            Console.WriteLine();

            //COMPARISON OPERATION

            Console.WriteLine("Does Person 1 earn more than Person 2?");
            Console.WriteLine(annualSalaryOfPerson1 > annualSalaryOfPerson2);
            // returns True if Person 1 earns more than Person 2, otherwise it returns False.

            Console.ReadLine();
        }
    }
}
