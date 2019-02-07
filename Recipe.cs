using System;

namespace LemonadeStand
{
    public class Recipe
    {
        public int lemonRecipe;
        public int sugarRecipe;
        public int iceRecipe;

        public Recipe()
        {

        }
        public int FindLemons()
        {
            Console.WriteLine("How many lemons per cup?");
            lemonRecipe = int.Parse(Console.ReadLine());
        }
        public int FindSugar()
        {
            Console.WriteLine("How much sugar per cup?");
            sugarRecipe = int.Parse(Console.ReadLine());
        }
        public int FindIce()
        {
            Console.WriteLine("How much ice per cup?");
            iceRecipe = int.Parse(Console.ReadLine());
        }



    }
}