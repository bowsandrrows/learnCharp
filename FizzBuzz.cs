
// Using foreach loop and Enumerable.Range(int, int)
var fizzBuzz = Enumerable.Range(1, 100);
foreach (int number in fizzBuzz)
    if (number % 3 == 0 && number % 5 == 0)
        Console.WriteLine($"{number} fizzbuzz");
    else if (number % 3 == 0)
        Console.WriteLine($"{number}  fizz");
    else if (number % 5 == 0)
        Console.WriteLine($"{number}  buzz");
    else
        Console.WriteLine(number);

// Using for loop
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}
