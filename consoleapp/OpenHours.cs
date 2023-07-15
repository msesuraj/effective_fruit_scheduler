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
        //This defines the opening hours records structure//
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
                MainMenu(); //this opens the menu to input opening hours
                CreateCsv(openHoursRecords,fileLoc );
           }

         void CsvLoad()
            {
                // this function loads the csv data into the programming, if file is not found,
                // it will lead to an error (expected file is OpenHours.csv)
                if (File.Exists(fileLoc)) // tests to see if file exists      
                    {
                    csvData = new StreamReader(File.OpenRead(fileLoc));
                    // Console.WriteLine("located .csv file");
                    // Console.ReadLine();
                    }
                else
                    {
                    Console.WriteLine("Opening Hours Data File not found");
                    Console.ReadLine();
                    return;
                    }    
            }

         void CsvToList ()

            {           
                //This method copies the data into list objects
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
                // Console.WriteLine("Opening Hours in total: " + openHoursRecords.Count);

                csvData.Close();

                // Now loop through to load the data into the list
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
                if you need to exit, you can press "2" to exit the homepage. */
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
                //This shows the menu and accepts the opening hours' data that's inputted
                Console.Clear();
                Console.WriteLine("Effective Fruits and Vegetables");
                Console.Write("Enter Location : ");
                string locationId = Console.ReadLine();
                Console.Write("Enter Day : ");
                string day = Console.ReadLine();
                // checking if the day is valid
                if (day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday")
                    {
                        Console.WriteLine("Invalid Day");
                        Console.ReadLine();
                        return;
                    }
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
            //This copies data from the programming to the csv file
            var sb = new StringBuilder();
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
