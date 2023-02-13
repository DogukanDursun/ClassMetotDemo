using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Enities;
using GameSimulation.Concrete;
namespace GameSimulation.Abstract
{
    interface ISalesService
    {
        void Add(Players players, Games games, Campaign campaign);
    }
}
