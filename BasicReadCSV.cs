using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestCSV
{
    class Program
    {

        private static string[,] LoadCsv(string filePath)
        {

            //get the text from the file
            string wholeFile = File.ReadAllText(filePath);

            //split int lines
            wholeFile = wholeFile.Replace('\n', '\r');
            string[] lines = wholeFile.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //see how many rows and colums there are
            int numRows = lines.Length;
            int numCols = lines[0].Split(',').Length;

            //allocate the array
            string[,] csvArray = new string[numRows, numCols];

            //load the array
            for (int r = 0; r < numRows; r++)
            {
                string[] lineR = lines[r].Split(',');
                for (int c = 0; c < numCols; c++)
                {
                    csvArray[r, c] = lineR[c];
                }
            }

            //returns the csv in an array
            return csvArray;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please place your csv file the c\\ directory on your compluter.");
            Console.Write("Enter the name of your file (i.e. test.csv): ");
            string fileNmae = Console.ReadLine();
            string path = ("c:\\" + fileNmae);
            Console.WriteLine();
            Console.WriteLine(path);
            //Console.ReadLine();

            //get the text from the file
            string wholeFile = File.ReadAllText(path);

            //split int lines
            wholeFile = wholeFile.Replace('\n', '\r');
            string[] lines = wholeFile.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //see how many rows and colums there are
            int numRows = lines.Length;
            int numCols = lines[0].Split(',').Length;

            //allocate the array
            string[,] csvArray = new string[numRows, numCols];

            //load the array
            for (int r = 0; r < numRows; r++)
            {
                string[] lineR = lines[r].Split(',');
                for (int c = 0; c < numCols; c++)
                {
                    csvArray[r, c] = lineR[c];
                }
            }

            //string[,] values = LoadCsv(path);

            //for (int r = 0; )

            Console.WriteLine(csvArray[0, 0]);
            Console.WriteLine(csvArray[1, 1]);
            Console.WriteLine(csvArray[2, 2]);
            Console.ReadLine();
        }
    }
}
