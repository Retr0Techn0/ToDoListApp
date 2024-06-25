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

            toDolist.Add(toDo);
        }
        public static void removeItems() 
        {
            Console.Clear();
            Console.WriteLine("Enter an item you want to remove");
            
        }
        public static void DisplayItems() 
        { 
            
        }

        private static List<ToDo> toDolist = new List<ToDo>();

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1. To add items to your to-do list.");
                Console.WriteLine("2. To remove items from your to-do list.");
                Console.WriteLine("3. To view the items in your to-do list.");
                string menuOptions = Console.ReadLine();
                int parsedMenuOptions = int.Parse(menuOptions);

                if (parsedMenuOptions == 1)
                {
                    AddItems();
                }

                if (parsedMenuOptions == 2)
                {

                }

                if (parsedMenuOptions == 3)
                {

                }
                Console.Clear();
            }

        }
    }
}
