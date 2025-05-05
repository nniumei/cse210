using System;

namespace PersonalJournalApp
{
    class JournalEntry
    {
        public DateTime Date { get; }
        public string Prompt { get; }
        public string Response { get; }

        public JournalEntry(DateTime date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        public string FormatEntry()
        {
            return $"\nDate: {Date:yyyy-MM-dd}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }
    }
}
