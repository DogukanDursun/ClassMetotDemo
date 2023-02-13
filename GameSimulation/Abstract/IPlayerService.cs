using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Enities;
using GameSimulation.Concrete;
namespace GameSimulation.Abstract

{
    interface IPlayerService
    {
        void Add(Players players);
        void Update(Players players);
        void Delete(Players players);
    }
}
