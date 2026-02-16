//Console.WriteLine("What do you want to do ?");
//Console.WriteLine("[S]ee all todos");
//Console.WriteLine("[A]dd a todo");
//Console.WriteLine("[R]emove a todo");
//Console.WriteLine("[E]xit");

//var userChoice = Console.ReadLine();

//switch(userChoice)
//{
//    case "s":
//    case "S":
//        PrintSelectedOption("You chose to see all todos");
//        break;
//    case "a":
//    case "A":
//        PrintSelectedOption("You chose to add a todo");
//        break;
//    case "r":
//    case "R":
//        PrintSelectedOption("You chose to remove a todo");
//        break;
//    case "e":
//    case "E":
//        PrintSelectedOption("You chose to exit");
//        break;
//    default:
//        PrintSelectedOption("Invalid option");
//        break;
//}

//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected Option: " + selectedOption);
//}



//char ConvertPointsToGrade(int points)
//{
//    return points switch
//    {
//        >= 90 => 'A',
//        >= 80 => 'B',
//        >= 50 => 'C',
//        _ => 'D'

//    };
//}

//int userNumber;
//do
//{
//    Console.WriteLine("Enter a number Larger than 10");
//    var userInput = Console.ReadLine();

//    if (userInput == "stop")
//    {
//        break;
//    }
//    bool isParsableToInt = userInput.All(char.IsDigit);
//    if (!isParsableToInt)
//    {
//        userNumber = 0;
//        continue;
//    }

//    userNumber = int.Parse(userInput);
//}
//while (userNumber <= 10);


//int[] numbers = new int[3];
//Console.WriteLine();
//Console.WriteLine("Element at index 0 is " + numbers[0]);
//Console.WriteLine("Element at index 1 is " + numbers[1]);
//Console.WriteLine("Element at index 2 is " + numbers[2]);

//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 7;

//Console.WriteLine();
//Console.WriteLine("Element at index 0 is " + numbers[0]);
//Console.WriteLine("Element at index 1 is " + numbers[1]);
//Console.WriteLine("Element at index 2 is " + numbers[2]);

//numbers[1] = 66;
//Console.WriteLine();
//Console.WriteLine("Element at index 0 is " + numbers[0]);
//Console.WriteLine("Element at index 1 is " + numbers[1]);
//Console.WriteLine("Element at index 2 is " + numbers[2]);

//// Console.WriteLine("Loop is now finished");

//Console.ReadKey();

//static int Factorial(int number)
//{

//    int result = 1;
//    int currentNumber = 0;
//    for (int i = 1; i <= number; i++) 
//    {
//     result *= i;
//    } return result;
//}

//using System;

//namespace Coding.Exercise
//{

//    public class Exercise
//    {
//        public static string BuildNwordString()
//        {
//            char[] letters = new char[] { 'n', 'i', 'g', 'g', 'e', 'r' };
//            var result = "";
//            for (int i = 0; i < letters.Length; ++i)
//            {
//                result += letters[i];



//            }
//            return result;
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        var helloString = Coding.Exercise.Exercise.BuildNwordString();
//        Console.WriteLine(helloString);
//    }
//}





//char[,] letters = new char[2, 3];

//letters[0, 0] = 'A';
//letters[0, 1] = 'B';
//letters[0, 2] = 'C';
//letters[1, 0] = 'D';
//letters[1, 1] = 'E';
//letters[1, 2] = 'F';

//var height = letters.GetLength(0);
//var width = letters.GetLength(1);
//Console.WriteLine("Height: " + height);
//Console.WriteLine("Width: " + width);

//for (var i = 0; i < letters.Length; i++)
//{
//    Console.WriteLine("Element is " + letters[i]);
//}

//var numbers = new[] { 10, -8, 2, 12, -17 };
//int nonPositiveCount;
//var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
//foreach(var PositiveNumber in onlyPositive)
//{
//    Console.WriteLine(PositiveNumber);
//}

//Console.WriteLine("Count of nonPositive: " + nonPositiveCount);
//Console.ReadKey();

//List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
//{
//    countOfNonPositive = 0;
//    var result = new List<int>();

//    foreach (int number in numbers)
//    {
//        if (number > 0)
//        {
//            result.Add(number);
//        }
//        else
//        {
//            countOfNonPositive++;
//        }

//    }
//    return result;
//}

bool isParsingSuccessful;
do
{
    Console.WriteLine("Enter a number:");

    var userInput = Console.ReadLine();

    isParsingSuccessful = int.TryParse(userInput, out int number);
    if (isParsingSuccessful)
    {
        Console.WriteLine("Parsing worked, number is " + number);
    }
    else
    {
        Console.WriteLine("Parsing failed, input was not a valid number.");
    }
} while (!isParsingSuccessful);

Console.ReadKey();
