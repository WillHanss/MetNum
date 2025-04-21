public class NewtonRaphson
{
    public static void start()
    {
        // creates the variables to be used in the program
        double x0, tol; // Initial guess and tolerance
        bool IterationLimit; // creates a boolean variable to check if the user wants to limit the iterations
        
        System.Console.WriteLine("Newton-Raphson Method");

        // Ask the user for the initial guess (x0) and tolerance (tol)
        System.Console.WriteLine("Enter the initial guess (x0): ");
        x0 = Convert.ToDouble(System.Console.ReadLine()); // Initial guess

        System.Console.WriteLine("Enter the tolerance (tol): ");
        tol = Convert.ToDouble(System.Console.ReadLine()); // Tolerance 

        Console.WriteLine("Do you want the method to have a limit of iterations? (y/n): ");
        string limit = Console.ReadLine()!; // Ask if the user wants to limit iterations
        if (limit == "y")
        {
            IterationLimit = true; // Set the flag to have an iteration limit wich is 100 (check on line 42)
        }
        else
        {
            IterationLimit = false; // Sets the program to not have an iteration limit
        }

        double result = NewtonRaphson(x0, tol,IterationLimit); // Calls the Newton-Raphson function

        System.Console.WriteLine("The root found is: " + result); // Print the result

        // Calculates the root using the Newton-Raphson method
        static double NewtonRaphson(double x0, double tol, bool IterationLimit)
        {
            double x1;
            int iterations = 0;

            do
            {
                x1 = x0 - func(x0) / derivativeFunc(x0); // Update the guess
                iterations++;
                x0 = x1; // Sets X1 to be the new initial guess

                if (IterationLimit && iterations >= 100)
                {
                    Console.WriteLine("Iteration limit reached.");
                    break; // Exit the loop if the iteration limit is reached
                }
            } while (Math.Abs(func(x1)) > tol && iterations < 100); // Check for convergence

            return x1; // Return the root found
        }
        // Define the function whose root we want to find
        static double func(double x)
        {
            return Math.Pow(x, 3) - x - 2; // Example function
        }
        // Define the derivative of the function
        static double derivativeFunc(double x)
        {
            return 3 * Math.Pow(x, 2) * x - 1; // Derivative of the example function
        }
    }
}