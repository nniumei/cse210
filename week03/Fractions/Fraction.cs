public class Fraction
{
    private int numerator;
    private int denominator;

    // construct should default to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // constructor for whole number
    public Fraction(int topValue)
    {
        numerator = topValue;
        denominator = 1;
    }

    // constructor for a full fraction
    public Fraction(int topValue, int bottomValue)
    {
        numerator = topValue;
        denominator = bottomValue != 0 ? bottomValue : 1; // divide by zero = no buenis
    }

    // reads that numerator
    public int ReadNumerator()
    {
        return numerator;
    }

    // reads the denominator
    public int ReadDenominator()
    {
        return denominator;
    }

    // updates the numerator
    public void UpdateNumerator(int newTop)
    {
        numerator = newTop;
    }

    // updates the denominator
    public void UpdateDenominator(int newBottom)
    {
        if (newBottom != 0)
        {
            denominator = newBottom;
        }
    }

    // should format as a string like "numerator/denominator"
    public string Display()
    {
        return $"{numerator}/{denominator}";
    }

    // converts the fraction to a decimal value
    public double ToDouble()
    {
        return (double)numerator / denominator;
    }
}
