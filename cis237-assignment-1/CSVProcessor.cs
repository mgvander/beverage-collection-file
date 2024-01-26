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
        public bool ImportCSVFile(string passPathToCSVFile)
        {
            //
            StreamReader streamReader = null;
            
            try
            {
                //
                streamReader = new StreamReader(passPathToCSVFile);

                // Counts the line in the list of beverages, but
                // starts at 0 becasue the first index of an array
                // starts at 0
                int counter = 0;

                // Contents of a line read in from the list of
                // beverages
                string currentLine;

                //
                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    //
                    this.ProcessLine(counter++, currentLine);

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

        private void ProcessLine(int index, string currentLine)
        {
            //


        }

    }

}
