namespace RCorpFoodPricer;

public class Meal
{
    private string _name;
    private MealType _mealType;

    public Meal()
    {
        _name = string.Empty;
        _mealType = MealType.Assiette;
    }
    
    public Meal(string name, MealType mealType)
    {
        _name = name;
        _mealType = mealType;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public MealType MealType
    {
        get => _mealType;
        set => _mealType = value;
    }

    public double GetPrice()
    {
        if (_mealType == MealType.Assiette)
        {
            return 15;
        }
        if (_mealType == MealType.Sandwich)
        {
            return 10;
        }

        return 0;
    }
}