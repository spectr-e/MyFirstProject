// Welcome the user to app
Console.WriteLine("Hello, World!");
Console.WriteLine("This application was built by Josiah");
Console.WriteLine("=====================================");
Console.WriteLine();

// Ask the user for their name - never trust the user hence the need for testing edge cases
Console.WriteLine("What is your name?");
string firstName = Console.ReadLine();

// Greet the user
Console.WriteLine();
Console.WriteLine($"Hello {firstName}");
Console.WriteLine("Thank you for using my application");
Console.ReadLine();
