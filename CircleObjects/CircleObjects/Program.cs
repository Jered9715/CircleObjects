using CircleObjects;


Console.WriteLine("Welcome to the Circle Tester");
Console.Write("Enter radius: ");
double userInput = -1;

while (true)
{
    userInput = double.Parse(Console.ReadLine());
    if (userInput > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("That is not a valid input please try again");
    }
}

Circle userRadius = new Circle(userInput);

while (true)
{
    Console.WriteLine($"Diameter: {userRadius.CalculateDiameter(userRadius.CircleRadius)}");
    Console.WriteLine($"Circumference: {userRadius.CalculateCircumference(userRadius.CircleRadius)}");
    Console.WriteLine($"Area: {userRadius.CalculateArea(userRadius.CircleRadius)}");
    Console.Write("Should the circle grow? (y/n): ");

    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower().Trim() == "y")
    {
        userRadius.CircleRadius = userRadius.Grow(userRadius.CircleRadius);
    }
    else
    {
        Console.WriteLine($"The circle's final radius is {userRadius.CircleRadius}");
        break;
    }
}


