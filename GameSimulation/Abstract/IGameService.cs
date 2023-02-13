using GameSimulation.Enities;
using GameSimulation.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstract
{
    interface IGameService
    {
        void Add(Games games);
        void Remove(Games games);
        void Update(Games games); 

    }
}
