using System;

namespace LemonadeStand
{
    public class Recipe
    {
        public int lemonRecipe;
        public int sugarRecipe;
        public int iceRecipe;
        public double dailyPrice;

        public Recipe()
        {
            double[] dailyRecipe = { lemonRecipe, sugarRecipe, iceRecipe, dailyPrice };
            FindLemons();
            FindSugar();
            FindIce();
            FindPrice();
        }


        public int FindLemons()
        {
            Console.WriteLine("How many lemons per cup?");
            lemonRecipe = int.Parse(Console.ReadLine());
            return lemonRecipe;
        }
        public int FindSugar()
        {
            Console.WriteLine("How much sugar per cup?");
            sugarRecipe = int.Parse(Console.ReadLine());
            return sugarRecipe;
        }
        public int FindIce()
        {
            Console.WriteLine("How much ice per cup?");
            iceRecipe = int.Parse(Console.ReadLine());
            return iceRecipe;
        }
        public double FindPrice()
        {
            Console.WriteLine("How much would you like to charge per cup? (.01-1.00)");
            dailyPrice = double.Parse(Console.ReadLine());
            return dailyPrice;
        }
        //TAKE OUT OF INVENTORY

    }
}