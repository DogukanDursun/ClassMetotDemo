using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Enities;
using GameSimulation.Concrete;
namespace GameSimulation.Abstract
{
    interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Players players);
    }
}
