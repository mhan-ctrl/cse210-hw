// The file containing the fraction class
public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fraction(int numerator)
    {
        _topNumber = numerator;
        _bottomNumber = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _topNumber = numerator;
        _bottomNumber = denominator;
    }

    public int GetTop()
    {
        return _topNumber;
    }

    public void SetTop(int top)
    {
        _topNumber = top;
    }

    public int GetBottom()
    {
        return _bottomNumber;
    }

    public void SetBottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }

    public double GetDecimalValue()
    {
        //casting can be a dangerous power, but going from int to doulbe and vice versa is fairly benign
        return ((double)_topNumber / (double)_bottomNumber);
    }
}