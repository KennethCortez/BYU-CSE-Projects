public class Fraction
{
    private int _Top;
    private int _Bottom;
    public Fraction()
    {
        _Top = 1;
        _Bottom = 1;
    }
    public Fraction(int number)
    {
        _Top = number;
        _Bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _Top = top;
        _Bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_Top}/{_Bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_Top / (double)_Bottom;
    }
}