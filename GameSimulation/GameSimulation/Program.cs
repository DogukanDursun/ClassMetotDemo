using System;
using GameSimulation.Enities;
using GameSimulation.Abstract;
using GameSimulation.Concrete;


namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Players player1 = new Players() { Id = 1, FirstName = "Doğukan", LastName = "Dursun", UserName = "DDn", CreditCard = "1212", BirthYear = 2000, NationalityId = "22222" };

            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player1);

            GameManager gameManager1 = new GameManager();
            Games game1 = new Games() { Id = 1, Name = "The Elder Scrolls V: Skyrim", Price = 350, Category = "RPG" };
            gameManager1.Add(game1);

            Games game2 = new Games() { Id = 1, Name = "The Witcher 3: Wild Hunt", Price = 250, Category = "RPG" };
            gameManager1.Add(game2);

            Games game3 = new Games() { Id = 1, Name = "Hollow Knight", Price = 150, Category = "Souls-Like" };
            gameManager1.Add(game3);

            CampaingManager campaingManager1 = new CampaingManager();
            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Winter Sale";
            campaign1.Discount = 30;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Winter Sale";
            campaign2.Discount = 20;

            campaingManager1.Add(campaign1);
            campaingManager1.Add(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Add(player1, game1, campaign1);
            salesManager.Add(player1, game2, campaign1);
            salesManager.Add(player1, game3, campaign2);
        }
    }
}
