using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class UserInterface
    {
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
            Console.WriteLine("1. Load File");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Search List");
            Console.WriteLine("4. Add New Beverage");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("=> ");

        }

    }

}
