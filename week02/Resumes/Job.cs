public class Experience
{
    public string _position;
    public string _organization;
    public int _yearStarted;
    public int _yearEnded;

    public void PrintDetails()
    {
        Console.WriteLine($"{_position} at {_organization} ({_yearStarted}-{_yearEnded})");
    }
}
