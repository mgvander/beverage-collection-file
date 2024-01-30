using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata;

namespace cis237_assignment_1
{
    internal class CSVProcessor
    {

        /**************************************************************
         * Methods
         * ***********************************************************/
        /// <summary>
        /// Find the file, import the data, store the data in items, and store those items
        /// in an array.
        /// </summary>
        /// <param name="passPathToCSVFileString"> The path that directs to the data file </param>
        /// <param name="passBeverageCollection"> The array for containing items </param>
        /// <returns> Was the file imported successfully </returns>
        public bool ImportCSVFile(string passPathToCSVFileString, BeverageCollection passBeverageCollection)
        {
            // Stream reader for reading data from a file
            StreamReader streamReader = null;
            
            try
            {
                // Counts the line in the list of beverages, but
                // starts at 0 becasue the first index of an array
                // starts at 0
                int counterInt = 0;

                // Contents of a line read in from the list of
                // beverages
                string currentLineString;

                // Create a new instance of a stream reader guided by the path to the file
                streamReader = new StreamReader(passPathToCSVFileString);

                // While the line trying to be read in is not of the null type
                while ((currentLineString = streamReader.ReadLine()) != null)
                {
                    // Pass in the current line of the file, the array of items, and the
                    // current index of the array
                    this.ProcessLine(counterInt++, currentLineString, passBeverageCollection);

                }

                // All data was imported until a line in the file was found to contain only null
                return true;

            }
            catch (Exception exception)
            {
                // Display the exeption error message
                Console.WriteLine(exception.ToString());
                Console.WriteLine();
                Console.WriteLine(exception.StackTrace);

                // The file was not successfully imported
                return false;

            }
            finally
            {
                // If the stream reader was instantiated, make sure it is closed
                // before exiting the reader
                if (streamReader != null)
                {
                    // Close the stream reader
                    streamReader.Close();

                }

            }

        }

        /// <summary>
        /// Takes the line of data, splits into the individual qualities, creates a new item
        /// with those qualities, and stores that item into the array of items at the designated
        /// index location
        /// </summary>
        /// <param name="passIndexInt"> Designated index location </param>
        /// <param name="passCurrentLineString"> Line of data from the file </param>
        /// <param name="passBeverageCollection"> The array for adding items to </param>
        private void ProcessLine(int passIndexInt, string passCurrentLineString, BeverageCollection passBeverageCollection)
        {
            // Delimiter
            const char DELIM = ',';

            // Has the beverage been added to the array
            bool addedBool = false;

            // Create a temporary array for storing each data point after splitting the line of date
            // into the individual qualities.
            string[] lineParts = passCurrentLineString.Split(DELIM);

            // Take each quality from the temporary array and store it their own variable
            string idString = lineParts[0];
            string nameString = lineParts[1];
            string packString = lineParts[2];
            decimal priceDecimal = decimal.Parse(lineParts[3]);
            bool activeBool = bool.Parse(lineParts[4]);

            // Create a new beverage by passing in its qualities
            Beverage beverage = new Beverage(idString, nameString, packString, priceDecimal, activeBool);            

            // Check if the beverage has been added
            while (!addedBool)
            {
                // Pass in the index location and newly created item to be added to the array of items
                // Also store the returned bollean to see if a new index need to be tried
                addedBool = passBeverageCollection.Add(passIndexInt, beverage);

                // Check if the beverage needs to be stored in the next index location
                if (!addedBool)
                {
                    // Increment the index location number
                    ++passIndexInt;

                }

            }            

        }

    }

}
