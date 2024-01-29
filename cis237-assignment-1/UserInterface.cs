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
        public int GetMenuChoice()
        {
            //
            this.DisplayMenu();

            //
            Int32.TryParse(Console.ReadLine(), out int choiceInt);

            //
            return choiceInt;

        }

        private void DisplayMenu()
        {
            //
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

        public void DisplayInstruction()
        {
            //
            Console.WriteLine();
            Console.WriteLine("Please enter a beverage id code.");
            Console.WriteLine();
            Console.Write("=> ");

        }

        public void DisplayInstruction(BeverageCollection passBeverageCollection)
        {
            //
            Console.WriteLine();
            Console.WriteLine("Enter the beverage's id code.");
            Console.Write("=> ");

            string idInputString = Console.ReadLine();

            //
            Console.WriteLine();
            Console.WriteLine("Enter the name of the beverage.");
            Console.Write("=> ");

            string nameInputString = Console.ReadLine();

            //
            Console.WriteLine();
            Console.WriteLine("Enter the packing information.");
            Console.Write("=> ");

            string packInputString = Console.ReadLine();

            //
            Console.WriteLine();
            Console.WriteLine("Enter the beverage's price.");
            Console.Write("=> ");

            Decimal.TryParse(Console.ReadLine(), out decimal priceInputDecimal);

            //
            Console.WriteLine();
            Console.WriteLine("The beverage is still active? (True or False)");
            Console.Write("=> ");

            Boolean.TryParse(Console.ReadLine(), out bool activeInputBool);
            Console.WriteLine();

            //
            Beverage beverage = new Beverage(idInputString, nameInputString, packInputString, priceInputDecimal, activeInputBool);

            //
            passBeverageCollection.FindFreeLine(beverage);

        }
                
    }

}
