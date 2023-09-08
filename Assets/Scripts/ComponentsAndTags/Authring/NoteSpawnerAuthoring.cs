using Unity.Entities;
using Unity.Mathematics;

namespace Game
{
    public struct NoteSpawnerTag : IComponentData {}

    public struct NoteSpawnerAuthoring : IComponentData
    {
        public int Id;  // 노래 번호 ==> id에 따라 Note의 패턴을 다르게 생성하게 생각하고 있음
        
        public float Speed;
        public float3 Position;
    }
}