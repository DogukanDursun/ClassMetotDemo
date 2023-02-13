using GameSimulation.Enities;
using GameSimulation.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Players players)
        {
            return true;
        }
    }
}
 