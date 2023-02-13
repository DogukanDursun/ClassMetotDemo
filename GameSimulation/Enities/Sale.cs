using GameSimulation.Enities;
using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entities
{
    class Sale : IEntity
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
    }
}
