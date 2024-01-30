using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class UserInterface
    {
        /**************************************************************
         * Methods
         * ***********************************************************/
        /// <summary>
        /// Display a list of numbered tasks and get the user's choice
        /// </summary>
        /// <returns> The integer assoiciated with the task to be performed </returns>
        public int GetMenuChoice()
        {
            // Show the list of numbered tasks that can be carried out
            this.DisplayMenu();

            // Get the users choice of tasks to perform
            Int32.TryParse(Console.ReadLine(), out int choiceInt);

            // Return the user's input
            return choiceInt;

        }

        /// <summary>
        /// Displays the list of options to perform
        /// </summary>
        private void DisplayMenu()
        {
            // Display the menu of options to perform
            Console.WriteLine("Choose a Number To Perform the Task");
            Console.WriteLine("".PadRight(35, '-'));
            Console.WriteLine("1. Load File");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Search List");
            Console.WriteLine("4. Add New Beverage");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("=> ");

        }

        /// <summary>
        /// Prompt the user provide an item id code
        /// </summary>
        public void DisplayInstruction()
        {
            // Prompt the user provide an item id code
            Console.WriteLine();
            Console.WriteLine("Please enter a beverage id code.");
            Console.WriteLine();
            Console.Write("=> ");

        }

        /// <summary>
        /// Prompt the user for each quality of an item and store that data in
        /// a new instance of that item. Then look for a spot in the array to
        /// store that item.
        /// </summary>
        /// <param name="passBeverageCollection"> The list of stored bevarages </param>
        public void DisplayInstruction(BeverageCollection passBeverageCollection)
        {
            // Get the item's id code from the user
            Console.WriteLine();
            Console.WriteLine("Enter the beverage's id code.");
            Console.Write("=> ");

            string idInputString = Console.ReadLine();

            // Get the item's name from the user
            Console.WriteLine();
            Console.WriteLine("Enter the name of the beverage.");
            Console.Write("=> ");

            string nameInputString = Console.ReadLine();

            // Get the item's packing information from the user
            Console.WriteLine();
            Console.WriteLine("Enter the packing information.");
            Console.Write("=> ");

            string packInputString = Console.ReadLine();

            // Get the item's price from the user
            Console.WriteLine();
            Console.WriteLine("Enter the beverage's price.");
            Console.Write("=> ");

            Decimal.TryParse(Console.ReadLine(), out decimal priceInputDecimal);

            // Get from the user, wether or not the item is active
            Console.WriteLine();
            Console.WriteLine("The beverage is still active? (True or False)");
            Console.Write("=> ");

            Boolean.TryParse(Console.ReadLine(), out bool activeInputBool);
            Console.WriteLine();

            // Create a new instance of the Beverage class
            Beverage beverage = new Beverage(idInputString, nameInputString, packInputString, priceInputDecimal, activeInputBool);

            // Look for a free space in the array to store the item
            passBeverageCollection.FindFreeLine(beverage);

        }
                
    }

}
