using System;
using System.ComponentModel.Design;

namespace cis237_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu option
            int exitInt = 5;

            // Has the .csv file been imported?
            bool importedBool = false;

            //
            string outputString;

            // Create an instance of the UserInterface class
            UserInterface userInterface = new UserInterface();

            //
            BeverageCollection beverageCollection = new BeverageCollection();

            //
            int choiceInt = userInterface.GetMenuChoice();

            //
            while (choiceInt != exitInt)
            {
                //
                switch (choiceInt)
                {
                    // The user has chosen to read in the data from the
                    // .csv file
                    case 1:
                        //
                        if (!importedBool)
                        {
                            //
                            CSVProcessor cSVProcessor = new CSVProcessor();

                            //
                            string PathToCSVFile = "../../../../datafiles/beverage_list.csv";

                            //
                            importedBool = cSVProcessor.ImportCSVFile(PathToCSVFile, beverageCollection);

                            //
                            Console.WriteLine("File was successfully imported.");
                            Console.WriteLine();

                        }
                        //
                        else
                        {
                            //
                            ErrorMessage(choiceInt);

                        }                        

                        break;

                    // The user has chosen to display the full contents
                    // of the list of beverages
                    case 2:
                        //
                        if (importedBool)
                        {
                            //
                            outputString = beverageCollection.ToString();

                            //
                            Console.Write(outputString);
                            Console.WriteLine();

                        }
                        //
                        else
                        {
                            //
                            ErrorMessage(choiceInt);

                        }                        

                        break;

                    // The user has chosen to attempt finding one of
                    // the beverages by their identifier code
                    case 3:
                        //
                        if (importedBool)
                        {
                            //
                            if (!beverageCollection.Search())
                            {
                                //
                                ErrorMessage(choiceInt);

                            }

                        }
                        //
                        else
                        {
                            //
                            ErrorMessage(choiceInt);

                        }                        

                        break;

                    // The user has chosen to add a beverage to the list
                    // of beverages
                    case 4:

                        break;

                    // The user entered a choice that was not provided
                    default:
                        //
                        ErrorMessage(choiceInt);

                        break;                    

                }

                //
                choiceInt = userInterface.GetMenuChoice();

            }            

        }

        private static void ErrorMessage(int passAction)
        {
            //
            switch (passAction)
            {
                case 1:
                    //
                    Console.WriteLine("The file has already been loaded.");
                    Console.WriteLine();

                    break;

                case 2:
                    //
                    Console.WriteLine("No file data was found."
                                      + Environment.NewLine + "Please load the file.");
                    Console.WriteLine();

                    break;

                case 3:
                    //
                    Console.WriteLine("The beverage id you are looking for could not be found.");
                    Console.WriteLine();

                    break;

                case 4:

                    break;

                default:
                    //
                    Console.WriteLine("The number you entered was not one of the offered options."
                                      + Environment.NewLine + "Please select one of the options provide.");
                    Console.WriteLine();

                    break;

            }
            
        }

    }

}
