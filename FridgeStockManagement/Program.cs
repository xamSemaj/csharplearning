using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
var fridgeStockManagerApp = new FridgeStockManagerApp();
fridgeStockManagerApp.Run();

 class FridgeStockManagerApp
{

    //private readonly fridgeItem = _fridgeItem;
    //private readonly fridgeStockManagerConsoleInteraction = _fridgeStockManagerConsoleInteraction;
    //private readonly fridgeStockManagerUserInteraction = _fridgeStockManagerUserInteraction;

    //   public FridgeStockManager(FridgeItem = fridgeItem, fridgestockManagerConsoleInteraction = _fridgeStockManagerConsoleInteraction, fridgeStockManagerUserInteraction = _fridgeStockManagerUserInteraction)
    //{
    //    Friditem = fridgeItem;
    //    fridgestockManagerConsoleInteraction = _fridgeStockManagerConsoleInteraction;
    //    fridgestockmanagerUserInteraction = _fridgeStockManagerUserInteraction; 
    //}
    public void Run()
    {
        var UserInteraction = new FridgeStockManagerUserInteraction();
       UserInteraction.PromptToCreateMealPlan();


    }


}

class FridgeStockManagerUserInteraction
{
    public void PromptToCreateMealPlan()
    {

        var mealPlan = new MealPlan(1, "Steak", "Bulking");
        while (true)
        {
            //Console.WriteLine("Create a new  meal plan: ");
            Console.WriteLine("Press S then Enter to stop adding items, or just press Enter to add another item.");
            var stopInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(stopInput) &&
                stopInput.Trim().Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            Console.WriteLine("*** Add a new Fridge Item Name ***");

            string? inputName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputName))
            {
                Console.WriteLine("Item name cannot be empty.");
                continue;
            }

            Console.WriteLine("*** Add Item Weight ***");
            string? weightInput = Console.ReadLine();
            if (!decimal.TryParse(weightInput, out decimal inputWeight) || inputWeight <= 0)
            {
                Console.WriteLine("Invalid weight. Please enter a positive number.");
                continue;
            }

            var fridgeItem = new FridgeItem(id: Guid.NewGuid().ToString(), inputName: inputName, inputWeight: inputWeight);

            // add fridge items to meal plan 

            mealPlan.AddItem(fridgeItem);


            Console.WriteLine($" Item Added: {fridgeItem.Name}, {fridgeItem.weight}g");

        }
        Console.WriteLine($"Meal Plan Complete. Total items: {mealPlan.Items.Count}");

        if (mealPlan.Items.Count == 0)
        {
            Console.WriteLine("No items added");
            return;
        }

        for (int i = 0; i < mealPlan.Items.Count; i++)
        {
            var item = mealPlan.Items[i];
            Console.WriteLine($"{i + 1}. {item.Name} - {item.weight}g ID: {item.Id}");
        }

    }
}

public class FridgeItem
{
    public string Id { get; set; }
    public string Name { get; set; }
    public decimal weight { get; set; }

    

    public FridgeItem(string id, string inputName, Decimal inputWeight)
    {
        Id = id;
        Name = inputName;
        weight = inputWeight;
    }

 
}

public class MealPlan
{

    public int Id { get;}
    public string Name { get;}
     public string Description { get;}

    private readonly List<FridgeItem> _items = new();

    public IReadOnlyList<FridgeItem> Items => _items;

    public MealPlan(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public void AddItem(FridgeItem item) => _items.Add(item);
   
}

//public class FridgeStock : FridgeItem
//{
 

   
//}