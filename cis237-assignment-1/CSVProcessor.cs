using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237_assignment_1
{
    internal class CSVProcessor
    {

        /**************************************************************
         * Methods
         * ***********************************************************/
        public bool ImportCSVFile(string passPathToCSVFileString, BeverageCollection passBeverageCollection)
        {
            //
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

                //
                streamReader = new StreamReader(passPathToCSVFileString);

                //
                while ((currentLineString = streamReader.ReadLine()) != null)
                {
                    //
                    this.ProcessLine(counterInt++, currentLineString, passBeverageCollection);

                }

                //
                return true;

            }
            catch (Exception exception)
            {
                //
                Console.WriteLine(exception.ToString());
                Console.WriteLine();
                Console.WriteLine(exception.StackTrace);

                //
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

        private void ProcessLine(int passIndexInt, string passCurrentLineString, BeverageCollection passBeverageCollection)
        {
            //
            string[] lineParts = passCurrentLineString.Split(',');

            //
            string idString = lineParts[0];
            string nameString = lineParts[1];
            string packString = lineParts[2];
            decimal priceDecimal = decimal.Parse(lineParts[3]);
            bool activeBool = bool.Parse(lineParts[4]);

            //
            Beverage beverage = new Beverage(idString, nameString, packString, priceDecimal, activeBool);            

            //
            passBeverageCollection.Add(passIndexInt, beverage);

            //
            //BeverageCollection beverageCollection = new BeverageCollection(passIndex, beverageId, beverageName, beveragePack, beveragePrice, beverageActivity);

        }

    }

}
