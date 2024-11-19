using System;

class Program 
{
    static voin Main() {
        Console.WriteLine("Welcome to Package Express. Please follow the instructionsbelow. ");
    }
}
Console.Write("Please enter the weight of your package: ");
double weight = double.Parse(Console.ReadLine());
if (weight > 50)
{
    Console.WriteLine.("Package too heavy to be shipped via Package Express. Have a good day.");
    return;
}
Console.Write("Please enter the width of your package: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Please enter the height of your package: ");
double height = double.Parse(Console.ReadLine());

Console.Write("Please enter the length of your package: ");
double length = double.Parse(Console.ReadLine());

if ( width + height + length > 50)

{
    Console.WriteLine.("Package too heavy to be shipped via Package Express.");
    return;
}
double quote = ( width * height* length* weight) / 100;
Console.WriteLine($"Your shipping quote is : ${quote:F2}");
}
}



