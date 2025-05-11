using System;
using System.Collections.Generic;
using System.Linq;

public class MemoryVerse
{
    private VerseReference verseInfo;
    private List<PhraseToken> tokens;

    public MemoryVerse(VerseReference refData, string text)
    {
        verseInfo = refData;
        tokens = text.Split(' ')
                     .Select(word => new PhraseToken(word))
                     .ToList();
    }

    public void Reveal()
    {
        Console.WriteLine(verseInfo.Format());
        Console.WriteLine(string.Join(" ", tokens.Select(t => t.Display())));
    }

    public bool FullyMasked()
    {
        return tokens.All(t => t.IsHidden());
    }

    public void ObscureWords(int count)
    {
        var candidates = tokens.Where(t => !t.IsHidden()).ToList();
        Random rng = new Random();
        for (int i = 0; i < count && candidates.Any(); i++)
        {
            int index = rng.Next(candidates.Count);
            candidates[index].Obscure();
            candidates.RemoveAt(index);
        }
    }
}
