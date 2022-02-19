using RCorpFoodPricer.Classes;

namespace RCorpFoodPricer;

public class App
{
    public static Order AskUser()
    {
        Console.WriteLine("************************************************");
        Console.WriteLine("Nom du repas: ");
        string nomRepas = Console.ReadLine();
        
        string typeRepas = string.Empty;
        do
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Assiette [1] ou Sandwich [2] ? : ");
            typeRepas = Console.ReadLine();
        } while ((string.IsNullOrEmpty(typeRepas)) || (typeRepas != "1" && typeRepas != "2"));
        

        Console.WriteLine("************************************************");
        Console.WriteLine("Nom de boisson : ");
        string nomBoisson = Console.ReadLine();
        
        string sizeBoisson = string.Empty;
        do
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Petit [1] / Moyen [2] / Large [3] ? : ");
            sizeBoisson = Console.ReadLine();
        } while ((string.IsNullOrEmpty(sizeBoisson)) || (sizeBoisson != "1" && sizeBoisson != "2" && sizeBoisson != "3"));

        Console.WriteLine("************************************************");
        Console.WriteLine("Nom du dessert: ");
        string nomDessert = Console.ReadLine();
        
        string typeDessert = string.Empty;
        do
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Normal [1] ou Special [2] ? : ");
            typeDessert = Console.ReadLine();
        } while (string.IsNullOrEmpty(typeDessert) || (typeDessert != "1" && typeDessert != "2"));
        
        string coffee = String.Empty;
        do
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Voulez vous un café ? Oui[1] / Non[2] : ");
            coffee = Console.ReadLine();
        } while ((string.IsNullOrEmpty(coffee)) || (coffee != "1" && coffee != "2"));
        
        bool haveCoffee = coffee == "1";

        Meal meal = new Meal();
        meal.Name = nomRepas;
        if (typeRepas == "2")
        {
            meal.MealType = MealType.Sandwich;
        }

        Beverage beverage = new Beverage();
        beverage.Name = nomBoisson;
        if (sizeBoisson == "1")
        {
            beverage.Size = Size.SMALL;
        }
        else if (sizeBoisson == "3")
        {
            beverage.Size = Size.LARGE;
        }

        Dessert dessert = new Dessert();
        dessert.Name = nomDessert;
        if (typeDessert == "2")
        {
            dessert.DessertType = DessertType.SPECIAL;
        }

        Order order = new Order();
        order.Meal = meal;
        order.Beverage = beverage;
        order.Dessert = dessert;
        order.Cafe = haveCoffee;

        return order;
    }
}