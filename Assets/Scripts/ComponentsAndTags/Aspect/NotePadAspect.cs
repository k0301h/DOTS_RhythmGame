using Unity.Entities;
using Unity.Transforms;

namespace Game
{
    public readonly partial struct NotePadAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRO<NotePadTag> Tag;
        private readonly RefRW<LocalTransform> Transform;
        private readonly RefRW<NotePadHealth> NoteaPadHealth;
    }
}