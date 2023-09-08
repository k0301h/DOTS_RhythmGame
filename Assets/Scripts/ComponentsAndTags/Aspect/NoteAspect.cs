using Unity.Entities;
using Unity.Transforms;

namespace Game
{
    public readonly partial struct NoteAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRO<NoteTag> Tag;
        private readonly RefRW<LocalTransform> Transform;
        private readonly RefRW<NoteAuthoring> NoteAuthoring;
    }
}