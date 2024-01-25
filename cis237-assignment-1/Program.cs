using System;

namespace cis237_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the UserInterface class
            UserInterface userInterface = new UserInterface();

            //
            int choiceInt = userInterface.GetMenuChoice();

            //
            switch (choiceInt)
            {
                // The user has chosen to read in the data from the
                // .csv file
                case 1:

                    break;

                // The user has chosen to display the full contents
                // of the list of beverages
                case 2:

                    break;

                // The user has chosen to attempt finding one of
                // the beverages by their identifier code
                case 3:

                    break;

                // The user has chosen to add a beverage to the list
                // of beverages
                case 4:

                    break;

                // The user has chosen to stop the program and exit
                case 5:

                    break;

            }

        }

    }

}
