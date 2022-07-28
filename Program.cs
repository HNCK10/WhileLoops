// See https://aka.ms/new-console-template for more information
//While loop - repeat some code while some condition is true
Console.Write("Enter your name!");
String name = Console.ReadLine();
while(name == "")
{
    Console.Write("Enter your name!");
    name = Console.ReadLine();
}
Console.WriteLine("Hello "+name);

Console.ReadKey();