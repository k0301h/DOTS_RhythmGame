using Unity.Entities; 

namespace Game
{
    public struct NotePadHealth : IComponentData
    {
        public int Value;
        public int Max;
    }
}