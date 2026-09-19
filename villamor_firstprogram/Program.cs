using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Hello, World!");
Console.WriteLine("Here are 5 things about myself:");
Console.WriteLine("I'm 18 years old.");
Console.WriteLine("I love my family.");
Console.WriteLine("I love to explore new things.");
Console.WriteLine("I love to watch anime.");
Console.WriteLine("I love to surf in the internet.");

string name = "Kyle";
int age = 18;

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine($" Ako si {name}, at ako ay {age} na taong gulang.");

int num1= 27;
int num2= 3;
int sum = num1 + num2;
int min = num1 - num2;
int mul = num1 * num2;
int div = num1 / num2;
int mod = num1 % num2;

Console.WriteLine(sum);
Console.WriteLine(min);
Console.WriteLine(mul);
Console.WriteLine(div);
Console.WriteLine(mod);
Console.WriteLine(sum+ ","+min+ ","+mul+","+div+","+mod);

Console.WriteLine("Enter your name: ");
string pangalan = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Hi, Your name is "+pangalan + " at ang edad mo ay " +edad);
