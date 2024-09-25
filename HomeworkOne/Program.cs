//Has variable to hold persons name
Console.WriteLine("Enter person's name");
string? name = (Console.ReadLine());
Console.WriteLine("Person's name is " + name);
Console.WriteLine();

//Has variable to hold persons age if alive
Console.WriteLine($"{name} is alive. (True | False)");
bool? isAlive = bool.Parse(Console.ReadLine());
Console.WriteLine();

//Has variable to hold persons age in years
Console.WriteLine($"Enter {name}'s age in years");
int? age = int.Parse(Console.ReadLine());
Console.WriteLine($"{name}'s age is {age} years");
Console.WriteLine();

//Has variable to hold persons phone number
Console.WriteLine($"Enter {name}'s phone number");
string? phoneNumber = Console.ReadLine();
Console.WriteLine($"{name}'s phone number is {phoneNumber}");
Console.WriteLine();
Console.ReadLine();
