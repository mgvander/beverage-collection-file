using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class BeverageCollection
    {
        // 3,942 beverages are listed in .csv file so an array with
        // 4,000 elements should be big enough for testing purposes
        Beverage[] beverages = new Beverage[4_000];

        /**************************************************************
         * Methods
         * ***********************************************************/
        /// <summary>
        /// Add the item to the array when the current index space is available
        /// </summary>
        /// <param name="passIndexInt"> The index location in the array </param>
        /// <param name="passBeverage"> The beverage to store in the array </param>
        /// <returns> Was the item added successfully? </returns>
        public bool Add(int passIndexInt, Beverage passBeverage)
        {
            // Check that the current index location in the array is empty
            // Also check that the index number has not exceeded the limits of the array
            if ((beverages[passIndexInt] == null) && (passIndexInt < beverages.Length))
            {
                // Store the item in the array in the designated index
                beverages[passIndexInt] = passBeverage;

                // The beverage has been stored
                return true;

            }
            // The current index location in the array already has an item
            // stored in it
            else
            {
                // The beverage has not been stored
                return false;

            }
            
        }

        /// <summary>
        /// Checks if the attempt to store the item was successful and if not
        /// move to the next index location and try again
        /// </summary>
        /// <param name="passBeverage"> The item to be added to the array </param>
        public void FindFreeLine(Beverage passBeverage)
        {
            // Index location in the array of items
            int indexInt = 0;

            // Has the beverage been added to the array 
            bool addedBool = false;
            
            // While the index number is within the array and the item has not been added to the array
            while ((indexInt < beverages.Length) && !addedBool)
            {
                // Try to add the item to the array at the designated index location
                addedBool = this.Add(indexInt, passBeverage);

                // Increment the index location number
                ++indexInt;

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="passSoughtId"> Id code being looked for </param>
        /// <returns> Was the id code found? </returns>
        public bool Search(string passSoughtId)
        {
            // Create a new instance of the UserInterface class
            UserInterface userInterface = new UserInterface();

            // Increment through the array of items
            for (int indexInt = 0; indexInt < beverages.Length; ++indexInt)
            {
                // Create a new instance of the Beverage class
                Beverage beverage = new Beverage();

                // Store the current item in the array as the new beverage
                beverage = beverages[indexInt];

                // Check that the beverage was not created from an empty part of the array
                if (beverage != null)
                {
                    // Check if the current beverage has the id code being sought after
                    if (beverage.Id == passSoughtId)
                    {
                        // Call and store the results of the ToString method from the Beverage class
                        string beverageDataString = beverage.ToString();

                        // Display the located item and all its qualities
                        Console.WriteLine();
                        Console.WriteLine("Located Beverage"
                                          + Environment.NewLine + "".PadRight(16, '-'));
                        Console.WriteLine(beverageDataString);

                        // The beverage id code was found
                        return true;

                    }

                }

            }

            // The beverage id code was not found
            return false;

        }

        /// <summary>
        /// Format and display the full contents of the beverages array
        /// </summary>
        /// <returns> The string containing the formatted contents of the array of items </returns>
        public override string ToString()
        {
            // The header for each data point in the list list
            string outputString = "Id Code".PadRight(9)
                                    + "Beverage Name".PadRight(57)
                                    + "Packaging".PadRight(18)
                                    + "Price".PadLeft(7)
                                    + "  " + "Active Status".PadRight(6)
                                + Environment.NewLine + "".PadRight(106, '-')
                                + Environment.NewLine;

            // Increment through the array of items
            for (int indexInt = 0; indexInt < beverages.Length; ++indexInt)
            {
                // Create a new instance of the Beverage class
                Beverage beverage = new Beverage();

                // Store the current item in the array as the new beverage
                beverage = beverages[indexInt];

                // Check that the beverage was not created from an empty part of the array
                if (beverage != null)
                {
                    // Format and concatenate the different properties of the item
                    outputString += beverage.Id.PadRight(9) 
                                      + beverage.Name.PadRight(57) 
                                      + beverage.Pack.PadRight(18) 
                                      + beverage.Price.ToString("c").PadLeft(7) 
                                      + "  " + beverage.Active.ToString().PadRight(6)
                                  + Environment.NewLine;

                }                

            }

            // The formatted contents of the array of items
            return outputString;

        }

    }

}
