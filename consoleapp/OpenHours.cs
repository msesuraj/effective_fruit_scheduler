using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApp
{
    public class OpenHoursRecord
    {
        public string? LocationId{ get; set; } 
        public string? Day{ get; set; }
        public string? StartTime{ get; set; }
        public string? EndTime{ get; set; }
    }
    public class OpenHours
    {
         StreamReader csvData = null;//creates a variable to load the data from the csv file
         List<OpenHoursRecord> openHoursRecords = new List<OpenHoursRecord>();

         public void OpenHoursMain()
            {
                CsvLoad(); // loads file to csv file
                CsvToList(); // reads file to lists
                Console.WriteLine("Inside OpenHours.OpenHoursMain");
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
                //csvData.ReadLine(); // skip first
                string line;
                while ((line = csvData.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        LineValues = line.Split(',').ToList();
                    
                        openHoursRecords.Add(new OpenHoursRecord { LocationId = LineValues[0].ToString(),
                                                              Day = LineValues[1].ToString(),
                                                              StartTime = LineValues[2].ToString(),
                                                              EndTime =  LineValues[3].ToString() 
                                                              });

                        /*
                        gender.Add(LineValues[5]);
                        sales.Add(Int32.Parse(LineValues[4]));
                        firstnames.Add(LineValues[1]);
                        lastnames.Add(LineValues[2]);
                        */
                    }
                //LineValues.ForEach(Console.WriteLine);
                Console.WriteLine("Opening Hours in total: " + openHoursRecords.Count);

                foreach (OpenHoursRecord openHoursRecord in openHoursRecords)
                    {
                        Console.WriteLine(openHoursRecord.Day +
                                           openHoursRecord.StartTime +
                                           openHoursRecord.EndTime);
                    }
                /*
                // Print only those who are above the limit
                foreach (Person person in persons) {
                if (person.age >= ageLimit)
                { 
                    Console.WriteLine(person);
                }
                */

            /// <summary>
            /// writes the csv into a list for each coloumn
            /// </summary>
            }

    }
/* write to file 
https://stackoverflow.com/questions/13815634/how-to-create-a-csv-file-from-liststring
File.WriteAllLines("text.txt", lst.Select(x => string.Join(",", x)));
https://www.makeuseof.com/csv-file-c-sharp-save-data/

https://www.youtube.com/watch?v=fRaSeLYYrcQ

https://www.clintmcmahon.com/how-to-open-a-csv-file-in-the-browser/

https://gist.github.com/luisdeol/c2c276796a92c8e3246ce2cd3e17e1df

https://www.c-sharpcorner.com/article/how-to-read-data-from-csv-file-in-c-sharp/
https://www.c-sharpcorner.com/article/c-sharp-list/
*/


}


/* location, day start time, end time  
 File.Create("fileName");
using System.IO;
             string path = @"D:\Development\OwainCodes_Blogs\testFile.txt";
            var output = new OutputFile(path, text);
https://www.owain.codes/blogs/2021/may/create-a-console-app-that-saves-to-a-file/
(write into file)
*/
