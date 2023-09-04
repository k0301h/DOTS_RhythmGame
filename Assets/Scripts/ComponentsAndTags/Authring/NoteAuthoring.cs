using Unity.Entities;

namespace Game
{
    public struct NoteTag : IComponentData {}
    public struct NoteAuthoring : IComponentData
    {
        public NoteInfo noteinfo;
    }
}