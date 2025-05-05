using System;

namespace PersonalJournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Journal ---");
                Console.WriteLine("1) Create a new journal entry");
                Console.WriteLine("2) View all journal entries");
                Console.WriteLine("3) Save journal page to a file");
                Console.WriteLine("4) Load journal page from a file");
                Console.WriteLine("5) Exit");
                Console.Write("Select an option (1-5): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        myJournal.NewEntry();
                        break;
                    case "2":
                        myJournal.ShowEntries();
                        break;
                    case "3":
                        Console.Write("Enter filename to save to: ");
                        string savePath = Console.ReadLine();
                        myJournal.Save(savePath);
                        break;
                    case "4":
                        Console.Write("Enter filename to load from: ");
                        string loadPath = Console.ReadLine();
                        myJournal.Load(loadPath);
                        break;
                    case "5":
                        Console.WriteLine("Exiting program. Please take care!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }
            }
        }
    }
}
