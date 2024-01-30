/// Author: Michael VanderMyde
/// 

using System;
using System.ComponentModel.Design;

namespace cis237_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu option for stopping the program
            int exitInt = 5;

            // Has the .csv file been imported?
            bool fileImportedBool = false;

            // Does the array have data stored in it?
            bool elementsExistBool = false;

            // String containing the full list of array contents
            string outputString;

            // Create an instance of the UserInterface class
            UserInterface userInterface = new UserInterface();

            // Create an instance of the BeverageCollection class
            BeverageCollection beverageCollection = new BeverageCollection();

            // The integer value representing which task from a list of
            // tasks the user wants to perform
            int choiceInt = userInterface.GetMenuChoice();

            // While the user has not chosen to exit the program
            while (choiceInt != exitInt)
            {
                // Check which task the user selected to perform
                switch (choiceInt)
                {
                    // The user has chosen to read in the data from the
                    // .csv file
                    case 1:
                        // Check that the file data has not been imported yet
                        if (!fileImportedBool)
                        {
                            // Create a new instance of the CSVProcessor class
                            CSVProcessor cSVProcessor = new CSVProcessor();

                            // The path to take to get the directory where the file is located
                            string PathToCSVFile = "../../../../datafiles/beverage_list.csv";

                            // Pass in the file path and array for storing items to read in the
                            // file data. Return true if this is accomplished.
                            fileImportedBool = cSVProcessor.ImportCSVFile(PathToCSVFile, beverageCollection);

                            // The array will have items in it if the import was successful
                            // If elementsExistBool is already True, this will not harm anything.
                            elementsExistBool = fileImportedBool;

                            // Inform the user of the successful import of data
                            Console.WriteLine("File was successfully imported.");
                            Console.WriteLine();

                        }
                        // The file data has been imported once before
                        else
                        {
                            // Call the error message for trying to import the file twice
                            ErrorMessage(choiceInt);

                        }                        

                        break;

                    // The user has chosen to display the full contents
                    // of the list of beverages
                    case 2:
                        // Check if there are items in the array
                        if (elementsExistBool)
                        {
                            // Call the ToString method from the BeverageCollection class
                            // to display the full contents of the array
                            outputString = beverageCollection.ToString();

                            // Display the list of items
                            Console.WriteLine();
                            Console.Write(outputString);
                            Console.WriteLine();

                        }
                        // The array only contains null values
                        else
                        {
                            // Inform the user that no data has been stored in the
                            // array to be displayed
                            ErrorMessage(choiceInt);

                        }                        

                        break;

                    // The user has chosen to attempt finding one of
                    // the beverages by their identifier code
                    case 3:
                        // Check if there are items in the array
                        if (elementsExistBool)
                        {
                            // Call the DisplayInstruction method from the UserInterface class
                            // to tell the user how to proceed.
                            userInterface.DisplayInstruction();

                            // Get the id string the user is searching for
                            string soughtId = Console.ReadLine();

                            // Check if the item associated with the id code does not
                            // exist in the array of items.
                            if (!beverageCollection.Search(soughtId))
                            {
                                // Inform the user the id was not found
                                ErrorMessage(choiceInt);

                            }

                        }
                        // The array only contains null values
                        else
                        {
                            // Inform the user that the item id code was not found in the array
                            ErrorMessage(choiceInt);

                        }                        

                        break;

                    // The user has chosen to add a beverage to the list
                    // of beverages
                    case 4:
                        // Call the DisplayInstruction method for prompting the user to
                        // give all the data values for one item
                        userInterface.DisplayInstruction(beverageCollection);

                        // There should now be at least one item in the array
                        elementsExistBool = true;

                        break;

                    // The user entered a choice that was not provided
                    default:
                        // Inform the user that an input not corresponding to an action
                        // was input
                        ErrorMessage(choiceInt);

                        break;                    

                }

                // The integer value representing which task from a list of
                // tasks the user wants to perform
                choiceInt = userInterface.GetMenuChoice();

            }            

        }

        /// <summary>
        /// Error messages informing the user what has gone wrong depending on
        /// which action they were trying to perform
        /// </summary>
        /// <param name="passActionInt"> The integer assoiciated with the task being performed </param>
        private static void ErrorMessage(int passActionInt)
        {
            // Check which action is being performed
            switch (passActionInt)
            {
                case 1:
                    // Display the error message
                    Console.WriteLine("The file has already been loaded.");
                    Console.WriteLine();

                    break;

                case 2:
                    // Display the error message
                    Console.WriteLine("No file data was found."
                                      + Environment.NewLine + "Please load the file.");
                    Console.WriteLine();

                    break;

                case 3:
                    // Display the error message
                    Console.WriteLine("The beverage id you are looking for could not be found.");
                    Console.WriteLine();

                    break;

                case 4:
                    //


                    break;

                default:
                    // Display the error message
                    Console.WriteLine("The number you entered was not one of the offered options."
                                      + Environment.NewLine + "Please select one of the options provide.");
                    Console.WriteLine();

                    break;

            }
            
        }

    }

}
