using System;
using System.Formats.Asn1;
using System.Net;

// Enhancement:
// Wrote code for checking if a file exists: Meaning it won't break the program if the filename the user
// entered does not exist on the drive of the computer.
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();
        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1: Write");
            Console.WriteLine("2: Display");
            Console.WriteLine("3: Load");
            Console.WriteLine("4: Save");
            Console.WriteLine("5: Quit");
            Console.Write("> ");
            string response = Console.ReadLine();
            int intResponse = int.Parse(response);

            if (intResponse == 1)
            {
                string randomPrompt = prompts.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("Your Response: ");
                string userEntry = Console.ReadLine();

                string todayDate = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = todayDate;
                newEntry._promptText = randomPrompt;
                newEntry._entryText = userEntry;
                myJournal.AddEntry(newEntry);                
            }

            else if (intResponse == 2)
            {
                myJournal.DisplayAll();
            }

            else if (intResponse == 3)
            {
                Console.Write("What is the name of the file? ");
                string file = Console.ReadLine();
                if (System.IO.File.Exists(file))
                {
                    myJournal.LoadFromFile(file);  
                }
                else
                {
                    Console.WriteLine($"Error: The file '{file}' does not exist. Returning to main menu.............");
                }           
            }

            else if (intResponse == 4)
            {
                Console.Write("What is the name of the file you wish to save to? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }

            else if (intResponse == 5)
            {
                break;
            }
        }
    }
}