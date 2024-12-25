// See https://aka.ms/new-console-template for more information

// Create an instance of MyNewClass

using part3Unit1of9;

// ReSharper disable ConvertToConstant.Local
Console.WriteLine("\t\tActive Code Below\n");

// Create an instance of MyNewClass
MyNewClass myNewClass = new MyNewClass();

Console.Write("What is my name? ");
string? myName = Console.ReadLine()?.ToLower().Trim();
try
{
    Console.Write("What is your age? ");
    double age = double.Parse(Console.ReadLine()?.Trim() ?? string.Empty);
    if (age < 18)
    {
        Console.WriteLine("You are too young. You're not allowed to do that!");
        Console.WriteLine("Goodbye!");
    }
    else
    {
        Console.Write("enter password in here: ");
        var somthing = Console.ReadLine()?.ToLower().Trim();
                                // Call the method from MyNewClass
        if (somthing != null) myNewClass.DoSomething(somthing, myName);
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
}
