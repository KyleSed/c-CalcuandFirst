Console.WriteLine("Enter your first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your operation (+ , - , * , / , %): ");
string operation = Console.ReadLine();

if (operation == "+")
{
Console.WriteLine("Sum: " + (num1 + num2));
}
else if (operation == "-"){
Console.WriteLine("Difference: " + (num1 - num2));
}
else if (operation == "*"){
Console.WriteLine("Product: " + (num1 * num2));
}
else if (operation == "/"){
Console.WriteLine("Difference: " + (num1 / num2));
}
else if (operation == "%"){
Console.WriteLine("Remainder: " + (num1 % num2));
}

