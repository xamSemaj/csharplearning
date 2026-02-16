using CookieCookbook.DataAccess;
using CookieCookbook.FileAccess;
using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;
using Microsoft.VisualBasic;
using System.Net.Http.Headers;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text.Json;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() : 
    new StringsTextualRepository();

const string FileName = "recipes";
var fileMetaData = new FileMetaData(FileName, Format);

var ingredientsRegister = new IngredientsRegister();
var cookiesRecipesApp = new cookiesRecipesApp(
    new RecipesRepository(new StringsJsonRepository(), ingredientsRegister),
    new RecipesConsoleUserInteraction(ingredientsRegister));
cookiesRecipesApp.Run(fileMetaData.ToPath());

public class cookiesRecipesApp
{

    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesConsoleUserInteraction _recipesUserInteraction;



    public cookiesRecipesApp(IRecipesRepository recipesRepository,
        IRecipesConsoleUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }

    public void Run(string filepath)
    {
        var allRecipes = _recipesRepository.Read(filepath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromuser();
        if (ingredients.Count() > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
             _recipesRepository.Write(filepath, allRecipes);
            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage("No ingredients have been selected. " + "Recipe will not be saved.");
        }
        _recipesUserInteraction.Exit();
    }


}

public interface IRecipesConsoleUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();

    IEnumerable<Ingredient> ReadIngredientsFromuser();
}


public class RecipesConsoleUserInteraction : IRecipesConsoleUserInteraction 
{
    private readonly IIngredientsRegister _ingredientsRegister;

    public RecipesConsoleUserInteraction(IIngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);
            var counter = 1;
            foreach(var recipe in allRecipes)
            {
                Console.WriteLine($"*****{counter}***** ");
                Console.WriteLine(recipe);
                Console.WriteLine();
                ++counter;
            }
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! " + "Available ingredients are:");
        foreach(var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }

    public IEnumerable<Ingredient> ReadIngredientsFromuser()
    {
        bool shallStop = false;
        var ingredients = new List<Ingredient>();

        while(!shallStop)
        {
            Console.WriteLine("Add an ingredient by its ID, " +
                "or type anything else if finished. ");
            var userInput = Console.ReadLine();

            if(int.TryParse(userInput, out int id))
            {
                var selectedIngredient = _ingredientsRegister.GetById(id);
                if(selectedIngredient is not null)
                {
                    ingredients.Add(selectedIngredient);
                }
            }
            else
            {
                shallStop = true;
            }
          
        }
        return ingredients;
    }
}






//Console.WriteLine("Create a new cookie recipe!");
//Console.WriteLine("Available ingredients are:");

//foreach(var ingredient in AllIngredients.All)
//{
//    Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
//}

//Console.WriteLine((IngredientList)IngredientList.WheatFlour);

//var selectedIngredient = Console.ReadKey().ToString();
//var keyInfo = Console.ReadKey();      // user presses a key
//Console.WriteLine();

//char c = keyInfo.KeyChar;

//int choice = c - '0';


//IngredientList selected = (IngredientList)choice;


//var recipe = new Recipe();

//recipe.AddIngredients(selected);

//public enum IngredientList
//{
//    WheatFlour = 1,
//    CoconutFlour,
//    Butter,
//    Chocolate,
//    Sugar,
//    Cardamom,
//    Cinnamon
//}


//public  class Recipe
//{

//    public List<Ingredients> _Ingredients = new List<Ingredients>();
//    public void AddIngredients(Ingredients ingredient) => _Ingredients.Add(ingredient);



//}






//// public void AddIngredients(Ingredients ingredient) => ingredients.Add(ingredient);




//public static class AllIngredients
//{
//    public static readonly Ingredients[] All = new Ingredients[]
//    {
//        new WheatFlour(),
//        new CoconutFlour(),
//        new Butter(),
//        new Chocolate(),
//        new Sugar(),
//        new Cardamom(),
//        new Cinnamon()

//    };
//}



//public abstract class Ingredients
//{


//    public abstract int Id { get; }
//    public abstract string Name { get; }
//    public abstract string PreperationInstructions { get; }



//}

//public class WheatFlour : Ingredients 
//{
//    public override int Id => 1 ;

//    public override string Name => "Wheat Flour";

//    public override string PreperationInstructions => "Sieve. Add to other ingredients.";
//}
//public class CoconutFlour : Ingredients 
//{
//    public override int Id => 2 ;

//    public override string Name => "Coconut Flour";

//    public override string PreperationInstructions => "Sieve. Add to other ingredients.";
//}
//public class Butter : Ingredients 
//{
//    public override int Id => 3 ;

//    public override string Name => "Butter";

//    public override string PreperationInstructions => "Melt on low heat. Add to other ingredients.";
//}
//public class Chocolate : Ingredients 
//{
//    public override int Id => 4 ;

//    public override string Name => "Chocolate";

//    public override string PreperationInstructions => "Melt in a water bath. Add to other ingredients.";
//}
//public class Sugar : Ingredients 
//{
//    public override int Id => 5 ;

//    public override string Name => "Sugar";

//    public override string PreperationInstructions => "Add to other ingredients.";
//}
//public class Cardamom : Ingredients 
//{
//    public override int Id => 6 ;

//    public override string Name => "Cardamom";

//    public override string PreperationInstructions => "Take half a teaspoon. Add to other ingredients.";
//}
//public class Cinnamon : Ingredients 
//{
//    public override int Id => 7 ;

//    public override string Name => "Cinnamon";

//    public override string PreperationInstructions => "Take half a teaspoon. Add to other ingredients.";
//}
//public class CocoaPowder: Ingredients 
//{
//    public override int Id => 8 ;

//    public override string Name => "CocoaPowder";

//    public override string PreperationInstructions => "Add to other ingredients.\r\n";
//}


