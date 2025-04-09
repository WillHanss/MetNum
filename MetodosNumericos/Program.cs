System.Console.WriteLine("Trapezoidal Rule");

//Ask the user for the lower limit (a), upper limit (b), and number of intervals (n)
System.Console.WriteLine("Enter the lower limit (a): "); 
double a = Convert.ToDouble(System.Console.ReadLine()); // Upper limit

System.Console.WriteLine("Enter the upper limit (b): ");
double b = Convert.ToDouble(System.Console.ReadLine()); // Lower limit

System.Console.WriteLine("Enter the number of intervals (n): ");
int n = Convert.ToInt32(System.Console.ReadLine()); // Number of intervals

double result = TrapezoidalRule(a, b, n); // Call the trapezoidal rule function

System.Console.WriteLine("The result of the trapezoidal rule is: " + result); // Print the result

//Calculate the width of each interval
static double TrapezoidalRule(double a, double b, int n)
{
    double h = (b - a) / n;
    double sum = func(a) + func(b);

    for (int i = 1; i < n; i++)
    {
        double x = a + i * h;
        sum += 2 * func(x);
    }

    return (h / 2) * sum;
}

static double func(double x)
{
    return -Math.Pow(x, 3) + 10 * Math.Pow(x, 2) + 8 * x + 10;
}