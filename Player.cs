namespace LemonadeStand
{
    public abstract class Player
    {
        public double[] inventory;
        public Recipe recipe = new Recipe();

        public Player()
        {
            //score = 0;
        }

    }
}