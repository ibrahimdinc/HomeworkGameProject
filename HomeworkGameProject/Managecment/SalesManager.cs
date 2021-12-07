using HomeworkGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject.Managecment
{
    class SalesManager
    {
        public void PromotionalSale(Gamer gamer, Game game, Campaign campaign)
        {
            decimal newPrice = game.GamePrice - (game.GamePrice * campaign.Rate);

            Console.WriteLine(game.GameName+" oyununu "+campaign.CampaignName+" kampanyasıyla "+newPrice+" TL'ye satın aldınız "+gamer.UserName+"!");
        }

       public void Sale ( Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName+" oyununu "+game.GamePrice+" TL'ye satın aldınız "+gamer.UserName+"!");
        }
    }
}
