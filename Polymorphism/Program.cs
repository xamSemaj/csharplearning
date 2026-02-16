using Polymorphism.stringExtensions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

//var pizza = new Pizza();
//pizza.AddIngriedient(new Cheddar());
//pizza.AddIngriedient(new Mozerella());
//pizza.AddIngriedient(new TomatoSauce());
//Console.WriteLine(pizza.ToString());

//var ingriedient = new Ingriedient(1);
//var cheddar = new Cheddar(2, 6);

//Console.WriteLine(cheddar);


//int seasonNumber = 0;
//Season spring = (Season)seasonNumber;

////int integer = 10;
////decimal b = integer;

//decimal b = 10.1m;
//int integer = (int)b;

//int secondSeasonNumber = 11;
//Season summer = (Season)secondSeasonNumber;



//Ingriedient ingriedient = new Cheddar(2,12);
//Ingriedient randomIngriedient = GenerateRandomIngriedient();
//Console.WriteLine("Random ingriedient is " + randomIngriedient);
//Cheddar cheddar = (Cheddar)randomIngriedient;

//Console.WriteLine("Random Ingriedient is " + randomIngriedient);
//Console.WriteLine("is object? " + (ingriedient is object));
//Console.WriteLine("is ingriedient? " + (ingriedient is Ingriedient));
//Console.WriteLine("is cheddar? " + (ingriedient is Cheddar));
//Console.WriteLine("is mozzerella? " + (ingriedient is Mozerella));
//Console.WriteLine("is tomato sauce? " + (ingriedient is TomatoSauce));

//if (randomIngriedient is Cheddar cheddar)
//{
//    //Cheddar cheddar = (Cheddar)randomIngriedient;
//    Console.WriteLine("Cheddar Object: " + cheddar);
//}
//Ingriedient ingriedient = GenerateRandomIngriedient();

//Cheddar cheddar = ingriedient as Cheddar;
//Cheddar cheddar = ingriedient as Cheddar;
//if (cheddar is not null)
//{
//    Console.WriteLine(cheddar.Name);

//}
//else
//{
//    Console.WriteLine("Conversion Failed!!!");
//}
//    Console.WriteLine(cheddar.Name);

//Ingriedient ingriedient = new Ingriedient(1);

//var cheddar = new Cheddar(2, 12);
//var tomato = new TomatoSauce(1);
//cheddar.Prepare();
//tomato.Prepare();






//var ingriedients = new List<Ingriedient>
//{
//    new Cheddar(2,10),
//    new Mozerella(2),
//    new TomatoSauce(1)
//};
//foreach (var ingriedient in ingriedients)
//{
//    ingriedient.Prepare();

//}





//Ingriedient nullIngriedient = null;
//if (nullIngriedient is not null)
//{
//    Console.WriteLine(nullIngriedient.Name);
//}
//else
//{
//    Console.WriteLine("21 ur  m u m  g a y ");
//}



// null ints are not possible!
//int nullint = null;

var bakeableDishes = new List<IBakeable>
{
    new Pizza(),
    new Panettone()
}; 

foreach (var bakeableDish in bakeableDishes)
{
    Console.WriteLine(bakeableDish.GetInstructions());
}






var multilineText = @"aaaa 
bbbb
cccc
dddd";
// extensions methods 
Console.WriteLine("Count of lines is " + multilineText.CountLines());
Console.WriteLine("Count of lines is " + StringExtensions.CountLines(multilineText));

//int CountLines(string input) => input.Split(Environment.NewLine).Length;

Console.WriteLine("Next After Spring is " + Season.Spring.Next());
Console.WriteLine("Next After Winter is " + Season.Winter.Next());
Console.ReadKey();

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}



public static class RandomPizzaGenerator
{
    public static Pizza Generate(int howManyIngriedients)
    {
        var pizza = new Pizza();
        for (int i = 0; i < howManyIngriedients; ++i)
        {
            var randomIngriedient = GenerateRandomIngriedient();
            pizza.AddIngriedient(randomIngriedient);
        }
        return pizza;
    }




    static Ingriedient GenerateRandomIngriedient()
    {
        var random = new Random();
        var number = random.Next(1, 4);
        if (number == 1) { return new Cheddar(2, 12); }
        if (number == 2) { return new TomatoSauce(1); }
        else return new Mozerella(2);
    }
}








public abstract class Dessert { }
public interface IBakeable
{
    public abstract string GetInstructions();
}
public class Panettone : Dessert, IBakeable
{
    public string GetInstructions() => "Bake at 180 degrees celsius for 35 minutes.";
}

public class Pizza : IBakeable
{
    //public Ingriedient ingriedient;
    private List<Ingriedient> _ingriedients = new List<Ingriedient>();

    public void AddIngriedient(Ingriedient ingriedient) => _ingriedients.Add(ingriedient);

    public string GetInstructions() => "Bake at 250 degrees Celsius for 10 minutes,  " + "ideally on a stove";

    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingriedients)}"; 
}

public abstract class Ingriedient
{

    public Ingriedient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Ingriedient class!");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    public int PriceIfExtraTopping { get; }



    public override string ToString() => Name;

    public virtual string Name { get; } = "Some ingriedient";

    public abstract void Prepare();
    
    public int PublicField;
    public string PublicMethod() => "This method is PUBLIC in the Ingriedient Class.";
    protected string ProtectedMethod() => "This method is PROTECTED in the Ingriedient Class.";
    private string PrivateMethod() => "This method is PRIVATE in the Ingriedient class";
}

public abstract class Cheese : Ingriedient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

   }

public class Cheddar : Ingriedient
{

    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Cheddar class!");
        AgedForMonths = agedForMonths;
    }
    public override string Name => $"{base.Name}, more specifically," + $" a Cheddar cheese aged for {AgedForMonths} months";
    public int AgedForMonths { get; }

    public override void Prepare() => Console.WriteLine("Grate and sprinkle over your mum.");

    public void useMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}

public sealed class Mozerella : Cheese
{
    public Mozerella(int priceIfExtraTopping) : base(priceIfExtraTopping) 
    {

    }

    public override string Name => "Mozerella";

    public override void Prepare() => Console.WriteLine("Slice thinly and place on top of the pizza");
}

//public class specialMozerella : Mozerella <-- cannot derive from sealed type Mozerella
//{

//}

public class TomatoSauce : Ingriedient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }

    public sealed override void Prepare() => Console.WriteLine("Cook tomatoes with basil, garlic and salt." +
        " Spread it ;)");
}

//public class SpecialTomatoSauce : TomatoSauce
//{
//    public SpecialTomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
//    {
//    }
//    public override void Prepare() => Console.WriteLine("Special tomato sauce");
//}

//public class SpecialString : String
//{ }