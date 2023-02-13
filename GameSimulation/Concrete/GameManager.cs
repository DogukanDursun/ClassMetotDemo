using GameSimulation.Enities;
using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.Name + " " + "Başarıyla Eklendi");
        }

        public void Remove(Games games)
        {
            Console.WriteLine(games.Name + " " + "Kaldırıldı");
        }

        public void Update(Games games)
        {
            Console.WriteLine(games.Name + " " + "Adlı Oyunun Fiyatı Güncellendi");
        }
    }
}
