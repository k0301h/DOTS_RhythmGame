using Unity.Entities;
using Unity.Transforms;

namespace Game
{
    public readonly partial struct NoteAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRO<NoteTags> _Tag;
        private readonly RefRW<LocalTransform> _Transform;
        private readonly RefRW<NoteAuthoring> _NoteAuthoring;
    }
}