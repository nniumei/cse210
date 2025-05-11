using System;

class Program
{
    static void Main()
    {
        var reference = new VerseReference("Helaman", 5, 12);
        string verseLine = "Remember that it is upon the rock of our Redeemer who is Christ the Son of God";

        var session = new MemoryVerse(reference, verseLine);

        while (!session.FullyMasked())
        {
            Console.Clear();
            session.Reveal();

            Console.Write("\nHit [Enter] to continue or type 'done' to exit: ");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "done")
                break;

            session.ObscureWords(2);
        }

        Console.Clear();
        session.Reveal();
        Console.WriteLine("\nYou’ve completed the memorization round.");
    }
}
