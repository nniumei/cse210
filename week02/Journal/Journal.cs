using System;
using System.Collections.Generic;
using System.IO;

namespace PersonalJournalApp
{
    class Journal
    {
        private List<JournalEntry> entries = new List<JournalEntry>();
        private Random randomizer = new Random();

        private List<string> prompts = new List<string>
        {
            "What was a small win you had today?",
            "What made you smile today?",
            "What did you learn about yourself today?",
            "How did you handle a challenge today?",
            "What are you grateful for today?"
        };

        public void NewEntry()
        {
            string selectedPrompt = prompts[randomizer.Next(prompts.Count)];
            Console.WriteLine($"\nPrompt: {selectedPrompt}");
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            DateTime currentDate = DateTime.Now;

            entries.Add(new JournalEntry(currentDate, selectedPrompt, response));
            Console.WriteLine("Your entry has been added.\n");
        }

        public void ShowEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No journal entries yet.");
                return;
            }

            foreach (var entry in entries)
            {
                Console.WriteLine(entry.FormatEntry());
            }
        }

        public void Save(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var entry in entries)
                    {
                        writer.WriteLine($"{entry.Date:O}||{entry.Prompt}||{entry.Response}");
                    }
                }
                Console.WriteLine("Journal successfully saved.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }

        public void Load(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("Error: File not found.");
                return;
            }

            try
            {
                entries.Clear();
                var lines = File.ReadAllLines(filename);

                foreach (var line in lines)
                {
                    var parts = line.Split("||");
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime parsedDate))
                    {
                        entries.Add(new JournalEntry(parsedDate, parts[1], parts[2]));
                    }
                }

                Console.WriteLine("Journal successfully loaded.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
    }
}
