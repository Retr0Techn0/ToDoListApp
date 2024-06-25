using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class ToDo
    {
        public string activity;
    }
    internal class Program
    {
        public static void AddItems() 
        { 
            Console.Clear();
            Console.WriteLine("Please enter an item you want to add");
            string add = Console.ReadLine();

            ToDo toDo = new ToDo();
            toDo.activity = add;

            toDoList.Add(toDo);
            Console.WriteLine("Item added! Press any key to return to the menu.");
            Console.ReadKey();

        }
        public static void removeItems() 
        {
            Console.Clear();
            Console.WriteLine("Enter an item you want to remove");
            
            
        }
        public static void DisplayItems() 
        {
            Console.Clear();
            Console.WriteLine("To-do list: ");
            if (toDoList.Count == 0)
            {
                Console.WriteLine("There are no items to display.");
            }
            else 
            {
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {toDoList[i].activity}");
                }
            }

            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
        }

        private static List<ToDo> toDoList = new List<ToDo>();

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1. To add items to your to-do list.");
                Console.WriteLine("2. To remove items from your to-do list.");
                Console.WriteLine("3. To view the items in your to-do list.");
                string Choices = Console.ReadLine();
                int parsedChoices = int.Parse(Choices);

                if (parsedChoices == 1)
                {
                    AddItems();
                    Console.Clear();
                }

                if (parsedChoices == 2)
                {
                    // I don't know how to remove from listtt :(
                }

                if (parsedChoices == 3)
                {
                    
                    DisplayItems();
                    Console.Clear();
                }
                
            }

        }
    }
}
