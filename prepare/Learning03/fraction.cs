public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // the two-parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
    }

    // makes changes to the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // makes changes to the bottom number
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1;
        }
    }

    // gives back the top number
    public int GetTop()
    {
        return _top;
    }

    // gives back the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // gives back the fraction as string?
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // gives decimal
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}