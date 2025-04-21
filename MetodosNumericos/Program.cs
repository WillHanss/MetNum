using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary to store the projects in order
        var projects = new Dictionary<int, string> 
        {
            { 1, "Bisection" },
            { 2, "False Position" },
            { 3, "Newton Raphson" },
            { 4, "Secant" },
            { 5, "Rectangle Method" },
            { 6, "Trapezoidal Rule" },
            { 7, "Simpson's Rule" }
        };
        Console.WriteLine(" ========== Project Selector ========== ");
        
        foreach (var project in projects)
        {
            // Display the project number and name
            Console.WriteLine($"{project.Key}. {project.Value}");
        }

        Console.WriteLine("========================================");  
        Console.WriteLine("Select a project to run:");

        // Read the user's choice
        if (int.TryParse(Console.ReadLine(), out int seleccion) && projects.ContainsKey(seleccion))
        {
            // Execute the selected project
            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Under construction");
                    //Bisection.start();
                    break;
                case 2:
                    Console.WriteLine("Under construction");
                    //FalsePosition.start();
                    break;
                case 3:
                    NewtonRaphson.start();
                    break;
                case 4:
                    Console.WriteLine("Under construction");
                    //Secant.start();
                    break;
                case 5:
                    Console.WriteLine("Under construction");
                    //FixedPoint.start();
                    break;
                case 6:
                    TrapezoidalRule.start();
                    break;
                case 7:
                    Console.WriteLine("Under construction");
                    //SimpsonsRule.start();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

    }
}
