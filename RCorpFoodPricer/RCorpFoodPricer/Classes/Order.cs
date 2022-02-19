namespace RCorpFoodPricer.Classes;

public class Order
{
    private Meal _meal;
    private Beverage _beverage;
    private Dessert _dessert;
    private bool _coffee;

    public Order()
    {
        _meal = new Meal();
        _beverage = new Beverage();
        _dessert = new Dessert();
        _coffee = false;
    }

    public Order(Meal meal, Beverage beverage, Dessert dessert, bool coffee)
    {
        _meal = meal;
        _beverage = beverage;
        _dessert = dessert;
        _coffee = coffee;
    }

    public Meal Meal
    {
        get => _meal;
        set => _meal = value;
    }

    public Beverage Beverage
    {
        get => _beverage;
        set => _beverage = value;
    }

    public Dessert Dessert
    {
        get => _dessert;
        set => _dessert = value;
    }

    public bool Cafe
    {
        get => _coffee;
        set => _coffee = value;
    }

    public bool IsStandardFormula()
    {
        return (_beverage.Size == Size.MEDIUM) && (_dessert.DessertType == DessertType.NORMAL);
    }

    public bool IsMaxFormula()
    {
        return (_beverage.Size == Size.LARGE) && (_dessert.DessertType == DessertType.SPECIAL);
    }

    public void PrintBill()
    {
        double total = 0;

        if (_meal.MealType == MealType.Assiette)
        {
            if (IsStandardFormula())
            {
                Console.WriteLine("Prix Formule Standard appliquée !");
                if (_coffee)
                {
                    Console.WriteLine("Avec café offert !");
                }
                total = 18;
            }
            else if (IsMaxFormula())
            {
                Console.WriteLine("Prix Formule Max appliquée !");
                total = 21;
            }
            else
            {
                total = _meal.GetPrice() + _beverage.GetPrice() + _dessert.GetPrice();
                if (_coffee)
                {
                    total += 1;
                }
            }
        }

        if (_meal.MealType == MealType.Sandwich)
        {
            if (IsStandardFormula())
            {
                Console.WriteLine("Prix Formule Standard appliquée !");
                total = 13;
            }
            else if (IsMaxFormula())
            {
                Console.WriteLine("Prix Formule Max appliquée !");
                total = 16;
            }
            else
            {
                total = _meal.GetPrice() + _beverage.GetPrice() + _dessert.GetPrice();
            }

            if (_coffee)
            {
                total += 1;
            }
        }

        Console.WriteLine("Prix total: " + total);
    }
}