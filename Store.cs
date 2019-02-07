using System;

namespace LemonadeStand
{ i
    class Store : Inventory
    {

        //Get/Set??

        public void StoreMenu()
    {
        Console.WriteLine("Would you like to 1) Buy Lemons, 2) Buy Sugar, 3) Buy Ice or 4) Main Menu?");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                BuyLemons();
                break;
            case "2":
                BuySugar();
                break;
            case "3":
                BuyIce();
                break;
            //case "4":
                //MainMenu();
            default:
                break;
        }
    }


        //Buy Lemons: $1 for 30, $2 for 70, $3 for 110
        public void BuyLemons()
        {
            Console.WriteLine("Would you like to buy 1)$1 for 30, 2)$2 for 70, 3)$3 for 110?");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    if (moneyWallet >= 1)
                    {
                        lemonCount += 30;
                        moneyWallet -= 1;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "2":
                    if (moneyWallet >= 2)
                    {
                        lemonCount += 70;
                        moneyWallet -= 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "3":
                    if (moneyWallet >= 3)
                    {
                        lemonCount += 110;
                        moneyWallet -= 3;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                default:
                    StoreMenu();
                    break;
            }
        }
            


    //Buy Sugar: $1 for 15, $2 for 35, $3 for 80
        public void BuySugar()
        {
            Console.WriteLine("Would you like to buy 1)$1 for 15, 2)$2 for 35, 3)$3 for 80?");
            string input3 = Console.ReadLine();
            switch (input3)
            {
                case "1":
                    if (moneyWallet >= 1)
                    {
                        sugarCount += 15;
                        moneyWallet -= 1;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "2":
                    if (moneyWallet >= 2)
                    {
                        sugarCount += 35;
                        moneyWallet -= 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "3":
                    if (moneyWallet >= 3)
                    {
                        sugarCount += 80;
                        moneyWallet -= 3;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                default:
                    StoreMenu();
                    break;
            }
             
    }



    //Buy Ice: $1 for 50, $2 for 120, $3 for 250
        public void BuyIce()
        {
            Console.WriteLine("Would you like to buy 1)$1 for 50, 2)$2 for 120, 3)$3 for 250?");
            string input4 = Console.ReadLine();
            switch (input4)
            {
                case "1":
                    if (moneyWallet >= 1)
                    {
                        iceCount += 50;
                        moneyWallet -= 1;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "2":
                    if (moneyWallet >= 2)
                    {
                        iceCount += 120;
                        moneyWallet -= 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "3":
                    if (moneyWallet >=3)
                    {
                        iceCount += 250;
                        moneyWallet -= 3;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                default:
                    StoreMenu();
                    break;
            }

    }



}