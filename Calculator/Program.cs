using System.Net.Security;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("What do you wantr to do with those numbers");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string input = Console.ReadLine().ToUpper();
Console.WriteLine("Result:" + SelectingOptionByUserTable(input));
Console.WriteLine("Press Any Key to close");
Console.ReadKey();
int Add (int a, int b)
{
    return a + b; 
} 

int Subtract (int a, int b)
{
    return a - b;
}

int Multiply (int a, int b)
{
    return a * b;
}

string SelectingOptionByUserTable (string input)
{ 
    if (input == "A")
    {
        return Add(firstNumber, secondNumber).ToString();
    }
    else if (input == "S")
    {
        return Subtract(firstNumber, secondNumber).ToString();
    }
    else if (input == "M")
    {
        return Multiply(firstNumber, secondNumber).ToString();
    }
    else
    {
        return "Invalid option";
    }
}