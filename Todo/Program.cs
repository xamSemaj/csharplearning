using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
class Program
{
    static void Main()
    {
        var todos = new List<string>();
        bool exit = false;
        while (!exit)
        {


            Console.WriteLine("Hello");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");
            var userChoice = Console.ReadLine();
            if (string.IsNullOrEmpty(userChoice))
            {
                Console.WriteLine("You must enter a choice. Please try again.");
                return;
            }

            switch (userChoice)
            {
                case "s":
                case "S":
                    ShowTodos(todos);



                    break;
                case "a":
                case "A":
                    addTodos(todos);
                    break;

                case "r":
                case "R":
                    removeTodos(todos);
                    break;
                case "e":
                case "E":
                    exit = true;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter S, A, R, or E.");
                    break;

            }

            static void ShowTodos(List<string> todos)
            {
                if (todos.Count == 0)
                {
                    Console.WriteLine("No TODOs available.");
                }
                else
                {
                    Console.WriteLine("Current TODOs:");
                    foreach (var todo in todos)
                    {
                        for (int i = 0; i < todos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todo}");
                        }

                    }
                }
            }
            static void addTodos(List<string> todos)
            {
                while (true)
                {
                    Console.WriteLine("Enter a TODO");
                    var todo = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(todo))
                    {
                        Console.WriteLine("TODO cannot be empty. Please enter a valid TODO.");
                        continue;
                    }
                    if (todos.Contains(todo))
                    {
                        Console.WriteLine("todo must be unique");
                    }
                    todos.Add(todo);
                    Console.WriteLine("TODO added: " + todo);
                    break;
                }

            }


            static void removeTodos(List<string> todos)
            {
                if (todos.Count == 0)
                {
                    Console.WriteLine("There are NO TODOS YOU IDIOT");
                    return;
                }

                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }

                while (true)
                {
                    Console.WriteLine("Enter the index of the TODO you wish to annihalate!!!");
                    var input = Console.ReadLine();
                    if (int.TryParse(input, out int index) && index > 0 && index <= todos.Count)
                    {
                        todos.RemoveAt(index - 1);
                        Console.WriteLine("Todo Removed Successfully");
                        break;

                    }
                }
            }


            Console.ReadKey();
        }
    }
}