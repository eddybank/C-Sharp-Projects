

// Welcome the user to the application
Console.WriteLine("Welcome to the Greeting Application");
Console.WriteLine("This application was built by Evan Horbinski");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Ask the user for their first name
string firstName;

Console.Write("Please enter your First Name: ");
firstName = Console.ReadLine();

// Greet the user by their name
Console.WriteLine();
Console.WriteLine("Hello {0}!", firstName);
Console.WriteLine("Thank you for using my application.");
Console.ReadLine();

