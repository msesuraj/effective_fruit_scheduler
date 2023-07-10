using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;

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
         string fileLoc = Directory.GetCurrentDirectory() + @"\OpenHours.csv"; //it will store the file's location

         public void OpenHoursMain()
            {
                CsvLoad(); // loads file to csv file
                CsvToList(); // reads file to lists
                MainMenu();
                // WriteFile();
                CreateCsv(openHoursRecords,fileLoc );
                Console.WriteLine("Inside OpenHours.OpenHoursMain");
                Console.ReadLine();

           }

         void CsvLoad()
            {
                // string fileLoc = Directory.GetCurrentDirectory() + @"\OpenHours.csv"; //it will store the file's location
                Console.WriteLine(fileLoc); // displaying file and it's location for debugging
                if (File.Exists(fileLoc)) // tests to see if file exists      
                    {
                    csvData = new StreamReader(File.OpenRead(fileLoc));
                    Console.WriteLine("located .csv file");
                    Console.ReadLine();
                    }
                else
                    {
                    Console.WriteLine("Opening Hours Data File not found");
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

                    }
                //LineValues.ForEach(Console.WriteLine);
                Console.WriteLine("Opening Hours in total: " + openHoursRecords.Count);

                csvData.Close();

                foreach (OpenHoursRecord openHoursRecord in openHoursRecords)
                    {
                        Console.WriteLine( openHoursRecord.LocationId +
                                           openHoursRecord.Day +
                                           openHoursRecord.StartTime +
                                           openHoursRecord.EndTime);
                    }


            }

         void MainMenu()
         {
            /* This shows the homepage along with the main menu for the different menus to access each page.
                what you need to do is to type one of the numbers that's listed though if you put a number that's not on the list,
                it can lead to an error,
                if you need to exit, you can press "5" to exit the homepage. */
             bool showMenu = true;
             while (showMenu)
             {          
                Console.Clear();
                Console.WriteLine("Effective Fruits and Vegetables");
                Console.WriteLine("1->) Add Opening Hours");
                Console.WriteLine("2->) Exit");
                Console.Write("\r\nSelect an option: ");
 
                switch (Console.ReadLine())
                {
                    case "1":
                        //calling the program that manages the opening hours
                        EnterData();
                        showMenu = true;
                        break;
                    case "2":
                        //exits user from the homepage
                        showMenu = false;
                        break;
                    default:
                        //error has been handled
                        Console.Write("Unfortunately, since you pressed a number that's above 2, it is a wrong option. Please select 1 - 2");
                        Console.ReadLine();
                        showMenu = true;
                        break;
                }
         }
        }

         void EnterData () 
         {
                Console.Clear();
                Console.WriteLine("Effective Fruits and Vegetables");
                Console.Write("Enter Location ID  : ");
                string locationId = Console.ReadLine();
                Console.Write("Enter Day : ");
                string day = Console.ReadLine();
                Console.Write("Enter Start Time : ");
                string startTime = Console.ReadLine();
                Console.Write("Enter End Time : ");
                string endTime = Console.ReadLine();
                openHoursRecords.Add(new OpenHoursRecord { LocationId = locationId,
                                                            Day = day,
                                                            StartTime = startTime,
                                                            EndTime = endTime
                                                            });

                foreach (OpenHoursRecord openHoursRecord in openHoursRecords)
                    {
                        Console.WriteLine( openHoursRecord.LocationId +
                                           openHoursRecord.Day +
                                           openHoursRecord.StartTime +
                                           openHoursRecord.EndTime);
                    }
                Console.ReadLine();
                
        }
         void CreateCsv<T>(List<T> openHoursList, string fileName)
         {
            var sb = new StringBuilder();
            // var basePath = AppDomain.CurrentDomain.BaseDirectory;
            // var finalPath = Path.Combine(basePath, fileName+".csv");
            var header = "";
            var info = typeof(T).GetProperties();
            var file = File.Create(fileName);
            file.Close();
            foreach (var obj in openHoursList)
                {
                    sb = new StringBuilder();
                    var line = "";
                    foreach (var prop in info)
                    {
                        line += prop.GetValue(obj, null) + ",";
                    }
                    line = line.Substring(0, line.Length - 1);
                    sb.AppendLine(line);
                    TextWriter sw = new StreamWriter(fileName, true);
                    sw.Write(sb.ToString());
                    sw.Close(); 
                }
         }
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


/* location, day start time, end time  
 File.Create("fileName");
using System.IO;
             string path = @"D:\Development\OwainCodes_Blogs\testFile.txt";
            var output = new OutputFile(path, text);
https://www.owain.codes/blogs/2021/may/create-a-console-app-that-saves-to-a-file/
(write into file)
https://stackoverflow.com/questions/1890093/converting-a-generic-list-to-a-csv-string
*/
