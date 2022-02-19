namespace RCorpFoodPricer;

public class Beverage
{
    private string _name;
    private Size _size;

    public Beverage()
    {
        _name = string.Empty;
        _size = Size.MEDIUM;
    }

    public Beverage(string name, Size size)
    {
        _name = name;
        _size = size;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Size Size
    {
        get => _size;
        set => _size = value;
    }

    public double GetPrice()
    {
        if (_size == Size.SMALL)
        {
            return 2;
        }else if (_size == Size.MEDIUM)
        {
            return 3;
        }else if (_size == Size.LARGE)
        {
            return 4;
        }

        return 0;
    }
}