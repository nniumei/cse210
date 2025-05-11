using System;
using System.Collections.Generic;
using System.Linq;

public class Passage
{
    private VerseRef reference;
    private List<TextPiece> elements;

    public Passage(VerseRef refInfo, string passageText)
    {
        reference = refInfo;
        elements = passageText.Split(' ')
                              .Select(word => new TextPiece(word))
                              .ToList();
    }

    public void Print()
    {
        Console.WriteLine(reference.Show());
        Console.WriteLine(string.Join(" ", elements.Select(e => e.Render())));
    }

    public bool IsCompletelyHidden()
    {
        return elements.All(e => e.IsConcealed());
    }

    public void MaskRandomItems(int numberToMask)
    {
        var visible = elements.Where(e => !e.IsConcealed()).ToList();
        if (visible.Count == 0) return;

        Random picker = new Random();
        int limit = Math.Min(numberToMask, visible.Count);

        for (int i = 0; i < limit; i++)
        {
            int idx = picker.Next(visible.Count);
            visible[idx].Conceal();
            visible.RemoveAt(idx);
        }
    }
}
