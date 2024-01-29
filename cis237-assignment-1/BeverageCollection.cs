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
        //
        Beverage[] beverages = new Beverage[4_000];

        /**************************************************************
         * Constructors
         * ***********************************************************/
        // Perhaps rather than using a constructor, I make a method to add a beverage to the array
        // As it stands a new array, first only containing null, keeps being made.
        //public BeverageCollection(int passIndex, string passId, string passName, string passPack, decimal passPrice, bool passActive)
        //{
        //    //
        //    Beverage beverage = new Beverage(passId, passName, passPack, passPrice, passActive);

        //    //
        //    beverages[passIndex] = beverage;

        //}

        /**************************************************************
         * Methods
         * ***********************************************************/
        public bool Add(int passIndexInt, Beverage passBeverage)
        {
            if (beverages[passIndexInt] == null)
            {
                //
                beverages[passIndexInt] = passBeverage;

                //
                return true;

            }
            //
            else
            {
                //
                return false;

            }
            
        }

        public void FindFreeLine(Beverage passBeverage)
        {
            //
            int indexInt = 0;

            //
            bool addedBool = false;
            
            //
            while ((indexInt < beverages.Length) && !addedBool)
            {
                //
                addedBool = this.Add(indexInt, passBeverage);

                //
                ++indexInt;

            }

        }

        public bool Search(string passSoughtId)
        {
            //
            UserInterface userInterface = new UserInterface();

            //
            for (int indexInt = 0; indexInt < beverages.Length; ++indexInt)
            {
                //
                Beverage beverage = new Beverage();

                beverage = beverages[indexInt];

                //
                if (beverage != null)
                {
                    //
                    if (beverage.Id == passSoughtId)
                    {
                        //
                        string beverageDataString = beverage.ToString();

                        //
                        Console.WriteLine();
                        Console.WriteLine("Located Beverage"
                                          + Environment.NewLine + "".PadRight(16, '-'));
                        Console.WriteLine(beverageDataString);

                        //
                        return true;

                    }

                }

            }

            //
            return false;

        }
        public override string ToString()
        {
            //
            string outputString = "Id Code".PadRight(9)
                                    + "Beverage Name".PadRight(57)
                                    + "Packaging".PadRight(18)
                                    + "Price".PadLeft(7)
                                    + "  " + "Active Status".PadRight(6)
                                + Environment.NewLine + "".PadRight(106, '-')
                                + Environment.NewLine;

            //
            for (int indexInt = 0; indexInt < beverages.Length; ++indexInt)
            {
                //
                Beverage beverage = new Beverage();

                //
                beverage = beverages[indexInt];

                //
                if (beverage != null)
                {
                    //
                    outputString += beverage.Id.PadRight(9) 
                                      + beverage.Name.PadRight(57) 
                                      + beverage.Pack.PadRight(18) 
                                      + beverage.Price.ToString("c").PadLeft(7) 
                                      + "  " + beverage.Active.ToString().PadRight(6)
                                  + Environment.NewLine;

                }                

            }
            
            //
            return outputString;

        }

    }

}
