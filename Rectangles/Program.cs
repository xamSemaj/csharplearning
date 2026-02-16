
//using System;
//using System.Net.WebSockets;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;
//using static System.Runtime.InteropServices.JavaScript.JSType;






////var person = new Person
////{
////Name = "John",
////YearOfBirth = 1981
////};


////Console.ReadKey();

////class Person
////{
////    public string Name { get; set; }
////    public int YearOfBirth { get; init; }

////    //public Person(string name, int yearOfBirth)
////    //{
////    //    Name = name;
////    //   YearOfBirth = yearOfBirth;
////    //}

////}





//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        var Rectangle1 = new Rectangle(5, 10);
//        var calculator = new ShapesMeasurementsCalculator();
//        // all const fields are implicitly static so we need to use the class name not an instance
//        //Console.WriteLine(Rectangle1.numberOfSides);
//        Console.WriteLine(Rectangle.numberOfSides);
//        Console.WriteLine(Rectangle.DescribeGenerally());
//        // this will not work as it is static and cannot be accessed within an instance it requires a type
//        // it will be called on the class as a whole it belongs to the class 
//        //Console.WriteLine(Rectangle1.DescribeGenerally());
//        Console.WriteLine($"Width is {Rectangle1.Width}");
//        Console.WriteLine($"Height is {Rectangle1.GetHeight()}");
//        Console.WriteLine("Circumference is " + calculator.calculateCircumference(Rectangle1));
//        Console.WriteLine("Area is " + calculator.calculateArea(Rectangle1));

//        //Console.WriteLine(Rectangle1.Description);
//        // very slow should be a method
//        //Console.WriteLine(Rectangle1.longDescription);

//        var Rectangle2 = new Rectangle(2, 3);
//        //var calculator = new ShapesMeasurementsCalculator();

//        Console.WriteLine($"Width is {Rectangle2.Width}");
//        Console.WriteLine($"Height is {Rectangle2.GetHeight()}");
//        Console.WriteLine("Count of Rectangle objects is " + Rectangle.CountOfInstances);
//        Console.WriteLine("Circumference is " + calculator.calculateCircumference(Rectangle2));
//        Console.WriteLine("Area is " + calculator.calculateArea(Rectangle2));
//        Console.ReadKey();
//        //var normalCalculator = new Calculator();
//        // I am directly referring to the calculator class not an object
//        Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
//        Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
//        Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");




//        var medicalAppointment = new MedicalAppointment("John Doe", new DateTime(2025, 4, 3));

//        medicalAppointment.Reschedule(new DateTime(2025, 4, 4));
//        Console.ReadKey();

//        Transformer t = square;

//        int answer = t(3);
//        int square(int x) => x * x;
//    }
//}
//delegate int Transformer(int x); 
//class MedicalAppointmentPrinter
//{
//    public void Print(MedicalAppointment medicalAppointment)
//    {
//        Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
//    }
//}

//// static classes can only contain static methods
//// they can be used refering to the class no object initialization required
//static class Calculator
//{
//    public static int Add(int a, int b) => a + b;
//    public static int Subtract(int a, int b) => a - b;
//    public static int Multiply(int a, int b) => a * b;
//    // will not work because it is not static 
//    //public void nonstatic() { };
//    // non static classes CAN contain static methods on the other hand
//}

//// Data hiding means making a member of a class non-public, 

//// To control the components of a class we use access modifers.

//// Class members are anything that a class contains especially
//// fields and methods.


//// Private -  members can only be accessed from within the class

//// Public - members can be accessed everywhere

//// We should only make a member public if it is absolutely necessary

//// making them public can be a risk.




////Encapsulation is bundling data with
////methods that operate on it,
//// in the same class.


////Data hiding is making fields private as opposed to public. 

//class Rectangle
//{
//    // we use const for things with a constant value at compilation time
//    // the value of a const field must be null at compile time
//    // the result of this method will only be calculated at runtime
//    // the compiler was smart enough to evaluate 2+2 
//    // but it is not smart enough to know GetOne() will always return 1
//    //const int NumberOfSides = GetOne(); - wont work 
//    const int NumberOfSides = 2 + 2;
//    // readonly is a runtime 
//    readonly int NumberOfSidesReadonly;
//    //public readonly int Width;
//    //public int _height;

//    //public static int GetOne() => 1; <-- for an example
//    //constructor

//    public static int CountOfInstances { get; private set; }

//    public Rectangle(int width, int height)
//    {
//        NumberOfSidesReadonly = 4;
//        _width = GetLengthOrDefault(width, nameof(_width));
//        _height = GetLengthOrDefault(height, nameof(_height));
//        ++CountOfInstances;
//    }

//    private int _width;
//    public int Width { get; }
//    private int _height;
//    public int GetHeight() => _height;

//    public void SetHeight(int value)
//    {
//        if (value > 0)
//        {
//            _height = value;
//        }
//    }

//    public string Description => $"A rectangle with a width {Width} " +
//        $"and a height of {_height}";

//    public static string DescribeGenerally() =>
//        $"A plane figure with four straight sides and four right angles. ";
//    // you cannot call non static methods inside of static methods
//    // if a private method doesn't use instance data, make it static
//    //+
//    //$"Sides are: {Width}, {_height}";

//    //public string longDescription
//    //{
//    //    get
//    //    {
//    //        var result = "";
//    //        for (int i = 0; i < 1000; ++i)
//    //        {
//    //            result += i;
//    //        }
//    //        return result;
//    //    }
//    //}

//    // example of a private method that doesn't use instance data 
//    // a dotted line will show on the method name asking to make it static
//    //              ¦¦¦
//    //              VVV
//    //public string NotUsingAnyState() => "ABC";
//    // the value will always be the same for all instances of this class 
//    // therefore requires no instantiation making const fields implicitly static
//    public const int numberOfSides = 4;

//    private int GetLengthOrDefault(int length, string name)
//{
//    int defaultValueIfNonPositive = 1;
//    if (length <= 0)
//    {
//            Console.WriteLine($"{name} must be a positive number.");
//            return defaultValueIfNonPositive;
//    }
//    return length;
//}

//}



//class ShapesMeasurementsCalculator
//{



//    public int calculateCircumference(Rectangle rectangle) =>  2 * rectangle.Width + 2 * rectangle.GetHeight();


//    public int calculateArea(Rectangle rectangle) => rectangle.Width * rectangle.GetHeight();


//}




//public class Triangle
//{
//    private int _Base;
//        private int _Height;

//    public Triangle(int _base, int _height)
//    {
//        _base = _Base;
//        _height = _Height;
//    }

//    public int CalculateArea(Triangle triangle)
//    {
//        return triangle._Base * _Height / 2;
//    }
//}




//class MedicalAppointment
//{
//    private string _patientName;
//    private DateTime _date;


//    // datetime has to be evaluate-able at compilation so you couldn't do now.add days because it would have to calculate that 
//    public MedicalAppointment(string patientName, DateTime date)
//    {
//        _patientName = patientName;
//        _date = date;
//    }

//    public DateTime GetDate() => _date;

//    //public MedicalAppointment(string patientName) :
//    //    this(patientName, 7)
//    //{
//    //    //_patientName = patientName;
//    //    //_date = DateTime.Now.AddDays(7);
//    //}

//    // optional parameters must appear after all required parameters
//    // this means days from now comes last patientName is first or it causes compilation error
//    // eg: public MedicalAppointment(int daysFromNow = 7, string patientName) <-- would not work!

//    // THESE ARE EXAMPLES OF CONSTRUCTORS 
//    // when ambiguious, the methods with no optional parameters will take precedent over the 
//    // ones with optional parameters meaning this one just below will be used before the
//    // method where patientName = "unknown" and the daysFromNow = 7 
//    public MedicalAppointment(string patientName)
//    {
//        _patientName = patientName;
//    }
//    // be moderate with use of optional parameter as when using multiple
//    // all the proceeding parameters must be optional
//    public MedicalAppointment(string patientName = "unknown", int daysFromNow = 7)
//    {
//        _patientName = patientName;
//        _date = DateTime.Now.AddDays(daysFromNow);
//    }

//    public void Reschedule(DateTime date)
//    {
//        _date = date;
//        var printer = new MedicalAppointmentPrinter();
//        printer.Print(this);
//    }

//    public void OverwriteMonthAndDay(int month, int day)
//    {
//        _date = new DateTime(_date.Year, month, day);
//    }

//    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
//    {
//        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
//    }
//}


////public class Dog
////{
////    private string _name;
////    private string _breed;
////    private int _weight;

////    public Dog(string name, string breed, int weight)
////    {
////        _name = name;
////        _breed = breed;
////        _weight = weight;

////    }

////    // chain constructor
////    public Dog(string name, int weight)
////        : this(name, "mixed-breed", weight)
////    {

////    }

////    public string Describe()
////    {
////        string size = DescribeWeight(_weight);

////        string sentence = $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms so it's a {size} dog.";
////    }

////    public string DescribeWeight(int weight)
////    {
////        if (weight < 0) {
////            return "tiny";

////        }
////        else if (weight < 30)
////        {
////            return "medium";
////        }
////        else
////        {
////            return "large";
////        }

////}

//public class Order
//{
//    public string Item { get; }
//    public DateTime Date;
//    private DateTime _date
//    {
//        get
//        {
//            return _date;
//        }
//        set
//        {
//            if (value.Year == DateTime.Now.Year)
//            { 
//                _date = value; 
//            }
//        }
//    }


//public Order(string item, DateTime date)
//{
//    Item = item;
//    Date = date;
//    }
//}





//public class DailyAccountState
//{
//    public int InitialState { get; }

//    public int SumOfOperations { get; }

//    public DailyAccountState(
//        int initialState,
//        int sumOfOperations)
//    {
//        InitialState = initialState;
//        SumOfOperations = sumOfOperations;
//    }

//    public int EndOfDayState
//    {
//        get
//        {
//            int result = 0;
//            result = InitialState + SumOfOperations;
//            return result;
//        }
//    }

//    public string Report => $"Day:{DateTime.Now.Day}, month {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
//}

//class SomeClass
//{
//    private static int _someField = 1;
//    public static string AsString() => "Value of Field is " + _someField;
//}
