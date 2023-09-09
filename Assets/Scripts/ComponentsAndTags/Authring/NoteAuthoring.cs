using Unity.Entities;
using Unity.Mathematics;

namespace Game
{
    public struct SpawnNoteTag : IComponentData {}
    public struct NoteTag : IComponentData {}
    public struct ShortNoteTag : IComponentData {}
    public struct LongNoteTag : IComponentData {}

    public enum NoteType
    {
        Short,
        Long,
    }
    
    public struct NoteAuthoring : IComponentData
    {
        // 기존 방식 ( == Properties)
        public int Id;

        public float Speed;
        //public NoteType NoteType;
        public float3 Position;
        
        // 동우 방식
        // public NoteInfo noteinfo;    ==> 이게 Mono에서 동적할당 하기 때문에 한번 생성하는 Entity에서는 이득일까?
    }
}