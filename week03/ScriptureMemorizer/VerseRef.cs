public class VerseRef
{
    private string bookName;
    private int chapterNum;
    private int verseStart;
    private int? verseEnd;

    public VerseRef(string book, int chapter, int verse)
    {
        bookName = book;
        chapterNum = chapter;
        verseStart = verse;
        verseEnd = null;
    }

    public VerseRef(string book, int chapter, int startVerse, int endVerse)
    {
        bookName = book;
        chapterNum = chapter;
        verseStart = startVerse;
        verseEnd = endVerse;
    }

    public string Show()
    {
        return verseEnd.HasValue
            ? $"{bookName} {chapterNum}:{verseStart}-{verseEnd}"
            : $"{bookName} {chapterNum}:{verseStart}";
    }
}
