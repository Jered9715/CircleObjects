using CircleObjects;

//welcome user to application
Console.WriteLine("Welcome to the Circle Tester");
//prompt user to enter radius
Console.Write("Enter radius: ");
double userInput = -1;

//pass user input through GetRadius loop if not valid asking for input again
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

//once valid data is passed through previous loop create new circle
Circle userRadius = new Circle(userInput);
//start display loop
while (true)
{
    //using new circle object use method to display diameter
    Console.WriteLine($"Diameter: {userRadius.CalculateDiameter(userRadius.CircleRadius)}");
    //using new circle object use method to display Circumference
    Console.WriteLine($"Circumference: {userRadius.CalculateCircumference(userRadius.CircleRadius)}");
    //using new circle object use method to display Area
    Console.WriteLine($"Area: {userRadius.CalculateArea(userRadius.CircleRadius)}");

    //ask user if they would like to grow circle
    Console.Write("Should the circle grow? (y/n): ");
    string userAnswer = Console.ReadLine();
    //if grow circle = yes then use grow method then loop through display and ask question again
    if (userAnswer.ToLower().Trim() == "y")
    {
    userRadius.CircleRadius = userRadius.Grow(userRadius.CircleRadius);
    }
    //if GrowCircle = no say goodbye statement with circle ending radiusbreak loop
    else
    {
        Console.WriteLine($"The circle's final radius is {userRadius.CircleRadius}");
        break;
    }
}


