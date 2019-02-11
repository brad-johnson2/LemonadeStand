using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Game
    {
        Player playerOne;
        Store store;
        List<Customer> customers;
        List<Day> days;
        Recipe recipe;
        Weather weather;
        Inventory inventory;
        Customer customer;
        int dailyCustomers = 0;


        
        public Game()
        {
            customers = new List<Customer>();
            days = new List<Day>();
            recipe = new Recipe();
            weather = new Weather();
            inventory = new Inventory();
            customer = new Customer();
            store = new Store();
        }

        public void RunGame()
        {
            SetUp();
            MainMenu();
            RunDay();
            AdjustInventory();
        }


        private void SetUp()
        {
            Console.WriteLine("How long would you like to run the Lemonade Stand? 1 week? 2 weeks? 3 weeks?");
            int GameWeeks = Int32.Parse(Console.ReadLine());
            int GameDays = GameWeeks * 7;
            for (int i = 1; i <= GameDays; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
        }


        public void MainMenu()
        {
            Console.WriteLine("What would you like to do? 1) View Inventory 2) Go to the Store 3) View Forecast 4) Play Game");
            string displayOption = Console.ReadLine();

            switch (displayOption)
            {
                case "1":
                    ViewInventory();
                    break;
                case "2":
                    StoreMenu();
                    break;
                case "3":
                    Console.WriteLine("It is supposed to be " + weather.temp + " degrees and " + weather.forecast + ".");
                    MainMenu();
                    break;
                case "4":
                    RunDay();
                    AdjustInventory();
                    Console.WriteLine("You have " + inventory.moneyWallet + " dollars.");
                    break;
                default:
                    MainMenu();
                    break;
            }
        }
      
        public int RunDay()
        {

            for (int i = 0; i <= customers.Count; i++)
            {
                if (recipe.dailyPrice < customer.priceHigh
                   && weather.actualTemp > customer.tempLow
                   && weather.actualTemp < customer.tempHigh
                   && recipe.lemonRecipe > customer.lemonsLow
                   && recipe.sugarRecipe > customer.sugarLow
                   && recipe.iceRecipe > customer.iceLow)
                {
                    dailyCustomers += 1;

                    //if (weather.forecast == "rainy" || weather.forecast == "stormy")
                    //{
                    //    dailyCustomers -= 
                    //}
                }
                else
                {
                    dailyCustomers += 0;
                }
            }
                return dailyCustomers;

        }
    

        private void AdjustInventory()
        {
            for (int i = 1; i <= dailyCustomers; i++)
            {
                inventory.lemonCount -= recipe.lemonRecipe;

                if (inventory.lemonCount < 0)
                {
                    inventory.lemonCount = 0;
                    break;
                }

                inventory.sugarCount -= recipe.sugarRecipe;

                if (inventory.sugarCount < 0)
                {
                    inventory.sugarCount = 0;
                    break;
                }

                inventory.iceCount -= recipe.iceRecipe;

                if (inventory.iceCount < 0)
                {
                    inventory.iceCount = 0;
                    break;
                }

                inventory.moneyWallet += recipe.dailyPrice;

            }
            //iceCount = 0 for next day
        }


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
                case "4":
                    MainMenu();
                    break;
                default:
                    break;
            }
        }

        public void BuyLemons()
        {
            Console.WriteLine("Would you like to buy 1)$1 for 30, 2)$2 for 70, 3)$3 for 110?");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    if (inventory.moneyWallet >= 1)
                    {
                        inventory.lemonCount += 30;
                        inventory.moneyWallet -= 1;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "2":
                    if (inventory.moneyWallet >= 2)
                    {
                        inventory.lemonCount += 70;
                        inventory.moneyWallet -= 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "3":
                    if (inventory.moneyWallet >= 3)
                    {
                        inventory.lemonCount += 110;
                        inventory.moneyWallet -= 3;
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


        public void BuySugar()
        {
            Console.WriteLine("Would you like to buy 1)$1 for 15, 2)$2 for 35, 3)$3 for 80?");
            string input3 = Console.ReadLine();
            switch (input3)
            {
                case "1":
                    if (inventory.moneyWallet >= 1)
                    {
                        inventory.sugarCount += 15;
                        inventory.moneyWallet -= 1;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "2":
                    if (inventory.moneyWallet >= 2)
                    {
                        inventory.sugarCount += 35;
                        inventory.moneyWallet -= 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "3":
                    if (inventory.moneyWallet >= 3)
                    {
                        inventory.sugarCount += 80;
                        inventory.moneyWallet -= 3;
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


        public void BuyIce()
        {
            Console.WriteLine("Would you like to buy 1)$1 for 50, 2)$2 for 120, 3)$3 for 250?");
            string input4 = Console.ReadLine();
            switch (input4)
            {
                case "1":
                    if (inventory.moneyWallet >= 1)
                    {
                        inventory.iceCount += 50;
                        inventory.moneyWallet -= 1;
                        Console.WriteLine(inventory.moneyWallet);
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "2":
                    if (inventory.moneyWallet >= 2)
                    {
                        inventory.iceCount += 120;
                        inventory.moneyWallet -= 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money.");
                    }
                    StoreMenu();
                    break;
                case "3":
                    if (inventory.moneyWallet >= 3)
                    {
                        inventory.iceCount += 250;
                        inventory.moneyWallet -= 3;
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
        public void ViewInventory()
        {
            Console.WriteLine($"Lemons: {inventory.lemonCount}, Sugar: {inventory.sugarCount} cups, Ice: {inventory.iceCount} cubes, Money: ${inventory.moneyWallet}");
            MainMenu();
        }
    }

        
    }