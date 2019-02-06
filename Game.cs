using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Game
    {
        Player playerOne;
        //Store store;
        List<string> forecasts;

        List<Day> days;

        public Game()
        {
            customers = new List<Customers>();
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


        static void MainMenu()
    {
        Console.WriteLine("What would you like to do? 1) View Inventory 2) Go to the Store 3) View Forecast 4) Play Game");
        string displayOption = Console.ReadLine();

        switch (displayOption)
        {
            case "1":
                ViewInventory();
                break;
            case "2":
                StoreTrip();
                break;
            case "3":
                GetForecast();
                GetTemp();
                break;
            case "4":
                RunDay();
                break;
            default:
                MainMenu();
                    break;            
        }
    }
        public void ViewInventory(inventory)
        {
            Console.WriteLine($"Lemons: {inventory[0]}, Sugar: {inventory[1]} cups, Ice: {inventory[2]} cubes, Money: ${inventory[3]}");
        }



        private void RunDay()
        {
            //Prompt for the day's recipe
            //Should show actual weather to affect <Customers>
            //Should update inventory 
            //should show profit 
        }

        private void StoreTrip()
        {
            //"View Inventory, Buy, Play Game"
            //Should display forecast for the day
            //Buy should update Inventory incuding Money

        }
    }

}