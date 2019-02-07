namespace LemonadeStand
{
    public class Inventory
    {
        public int lemonCount = 0;
        public int sugarCount = 0;
        public int iceCount = 0;
        public double moneyWallet = 20;



        public Inventory()
        {
            double[] inventory = new double[] { lemonCount, sugarCount, iceCount, moneyWallet };
        }


       
    }
}