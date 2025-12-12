using System;

public class Fraction
{
    private int _topNumerator;
    private int _bottomDenominator;

    public Fraction()
    {
        // Initialize start values to 1/1
        _topNumerator = 1;
        _bottomDenominator = 1;
    }
	
    public Fraction(int Numerator)
    {
        _topNumerator = Numerator;
        _bottomDenominator = 1;
    }

    public Fraction(int Numerator, int Denominator)
    {
        _topNumerator = Numerator;
        _bottomDenominator = Denominator;
    }
	
	public string GetFractionString()
	{
		// Convert to Fraction to single string variable to return
        string fractionString = $"{_topNumerator}/{_bottomDenominator}";
        return fractionString
	}
	
	public double GetFractionDecimal()
	{
        // Convert to Fraction to single decimal double variable to return
        double fractionDecimal = (double)_topNumerator / (double)_bottomDenominator;
        return fractionDecimal;
	}
	
}