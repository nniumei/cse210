public class TextPiece
{
    private string token;
    private bool hidden;

    public TextPiece(string word)
    {
        token = word;
        hidden = false;
    }

    public void Conceal()
    {
        hidden = true;
    }

    public bool IsConcealed()
    {
        return hidden;
    }

    public string Render()
    {
        return hidden ? new string('*', token.Length) : token;
    }
}
