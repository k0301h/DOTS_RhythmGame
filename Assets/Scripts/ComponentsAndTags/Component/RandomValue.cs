using System;
using Unity.Entities;

namespace Game
{
    public struct RandomValue : IComponentData
    {
        public Random Randomizer;
    }
}