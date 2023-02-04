
// Capture a user's age from the Console and then identify how old they will be in 25 years, as well as how old they were 25 years ago. Print that information to the Console in natural language.

Console.Write("What is your age? : ");

string? userAge = Console.ReadLine();

bool isInt = int.TryParse(userAge, out int value);

DateTime today = DateTime.Now;

Console.WriteLine($"You are currently {value} years old.");
Console.WriteLine($"And will be {value + 25} in 25 years time and 25 years ago you were {(value > 25 ? value - 25 : 0)}.");
