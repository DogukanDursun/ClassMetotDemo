using GameSimulation.Enities;
using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    class SalesManager : ISalesService
    {
        public void Add(Players players, Games games, Campaign campaign)
        {
            double invoice = (games.Price * campaign.Discount) / 100;
            invoice = games.Price - invoice;
            Console.WriteLine("İndirim Tanımlandı");
            Console.WriteLine("Kullanıcı Adı:" + " " + players.UserName);
            Console.WriteLine("İsim-Soyisim:" + " " + players.FirstName + " " + players.LastName);
            Console.WriteLine("Oyun:" + games.Name + " , " + "Toplam Ödeme:" + " " + invoice);
        }
    }
}
