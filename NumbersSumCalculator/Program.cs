using System.Reflection;
using System.Runtime.CompilerServices;


public class Exercise
{
    public List<int> GetCountsOfAnimalsLegs()
    {
        var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

        var result = new List<int>();
        foreach (var animal in animals)
        {
            result.Add(animal.NumberOfLegs);
        }
        return result;

        
        
    }
    
    

}

//your code goes here

class Animal
{
    public virtual int NumberOfLegs { get; set; } = 4;
}

class Lion : Animal
{
    public override int NumberOfLegs { get; set; } = 4;

}

class Tiger : Animal
{
    public override int NumberOfLegs { get; set; } = 4;

}

class Duck : Animal
{
    public override int NumberOfLegs { get; set; } = 2;

}

class Spider : Animal
{
    public override int NumberOfLegs { get; set; } = 8;

}














//var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
//bool shallAddPositiveOnly = true;

//NumbersSumCalculator calculator =
//    shallAddPositiveOnly ?
//    new PositiveNumbersSumCalculator() :
//     new NumbersSumCalculator();


//int sum = calculator.Calculate(numbers);
////if (shallAddPositiveOnly)
////{
////    sum = new PositiveNumbersSumCalculator().Calculate(numbers);
////}
////else
////{
////    sum = new NumbersSumCalculator().Calculate(numbers);
////}

//Console.WriteLine($"Sum is: {sum}");
//Console.ReadKey();
//public class NumbersSumCalculator
//{
//    public int Calculate(List<int> numbers)
//    {
//        int sum = 0;
//        foreach (var number in numbers)
//        {
//            if (ShallBeAdded(number))
//            {
//                sum += number;
//            }
//        }
//        return sum;
//    }

//    protected virtual bool ShallBeAdded(int number)
//    {
//        return true;
//    }
   
//}

//public class PositiveNumbersSumCalculator : NumbersSumCalculator
//{
//    //public int Calculate(List<int> numbers)
//    //{
//    //    int sum = 0;
//    //    foreach (var number in numbers)
//    //    {
//    //        if (number > 0)
//    //        {
//    //            sum += number;
//    //        }
//    //    }
//    //    return sum;
//    //}

//    protected override bool ShallBeAdded(int number)
//    {
//        return number > 0;
//    }


//}































////using Pizzeria;
////using System.Text.Json;

////var person = new Person
////{
////    FirstName = "John",
////    LastName = "Smith",
////    YearOfBirth = 1972
////};

////var asJson = JsonSerializer.Serialize(person);
////Console.WriteLine("As JSON:");
////Console.WriteLine(asJson);

////var personJson = 
////    "{\"FirstName\":\"John\",\"LastName\":\"Smith\",\"YearOfBirth\":1972}";

////var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

////Console.ReadKey();

////public class Person
////{
////    public string FirstName { get; set; }
////    public string LastName { get; set; }
////    public int YearOfBirth { get; set; }
////}
