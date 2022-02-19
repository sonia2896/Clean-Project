using RCorpFoodPricer.Classes;

namespace RCorpFoodPricer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Order order = App.AskUser();
            order.PrintBill();
        }
    }
}