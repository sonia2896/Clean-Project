namespace RCorpFoodPricer;

public class Dessert
{
    private string _name;
    private DessertType _dessertType;

    public Dessert()
    {
        _name = string.Empty;
        _dessertType = DessertType.NORMAL;
    }

    public Dessert(string name, DessertType dessertType)
    {
        _name = name;
        _dessertType = dessertType;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DessertType DessertType
    {
        get => _dessertType;
        set => _dessertType = value;
    }

    public double GetPrice()
    {
        if (_dessertType == DessertType.NORMAL)
        {
            return 2;
        }
        if (_dessertType == DessertType.SPECIAL)
        {
            return 4;
        }

        return 0;
    }
}