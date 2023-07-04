using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApp
{
    public class OpenHours
    {
         StreamReader csvData = null;//creates a variable to load the data from the csv file
         public void OpenHoursMain()
            {
                CsvLoad(); // loads file to csv file
                CsvToList(); // reads file to lists
                Console.WriteLine("Inside OpenHours.TestMethod");
                Console.ReadLine();

           }

         void CsvLoad()
            {
                string fileLoc = Directory.GetCurrentDirectory() + @"\OpenHours.csv"; //it will store the file's location
                Console.WriteLine(fileLoc); // displaying file and it's location for debugging
                if (File.Exists(fileLoc)) // tests to see if file exists      
                    {
                    csvData = new StreamReader(File.OpenRead(fileLoc));
                    Console.WriteLine("located .csv file");
                    Console.ReadLine();
                    }
                else
                    {
                    Console.WriteLine("File not found");
                    Console.ReadLine();
                    return;
                    }
                Console.ReadLine();     
            }

            void CsvToList ()
            {           
                List<string> LineValues = new List<string>();
                csvData.ReadLine(); // skip first
                string line;
                while ((line = csvData.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        LineValues = line.Split(',').ToList();
                        /*
                        gender.Add(LineValues[5]);
                        sales.Add(Int32.Parse(LineValues[4]));
                        firstnames.Add(LineValues[1]);
                        lastnames.Add(LineValues[2]);
                        */
                    }

            /// <summary>
            /// writes the csv into a list for each coloumn
            /// </summary>
            }

    }

}


/* location, day start time, end time  
 File.Create("fileName");
using System.IO;
             string path = @"D:\Development\OwainCodes_Blogs\testFile.txt";
            var output = new OutputFile(path, text);
https://www.owain.codes/blogs/2021/may/create-a-console-app-that-saves-to-a-file/
(write into file)
*/
