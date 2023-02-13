using GameSimulation.Enities;
using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }


        public void Add(Players players)
        {
            if (_playerCheckService.CheckIfRealPerson(players))
            {
                Console.WriteLine(players.UserName + " " + "Kullanıcı Adlı Oyuncu Kaydı Tamamlandı.");
            }
            else
            {
                throw new Exception("Böyle Bir Kişi Bulunamadı");
            }
        }
        public void Delete(Players players)
        {
            Console.WriteLine(players.UserName + " " + "Kullanıcı Adlı Oyuncunun Hesabı Silindi");
        }

        public void Update(Players players)
        {
            Console.WriteLine(players.UserName + " " + "Kullanıcı Adlı Oyuncu Güncellendi");
        }
    }
}
