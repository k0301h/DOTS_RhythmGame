using Unity.Entities;

namespace Game
{
    public readonly partial struct NotePadAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRO<NotePadTag> _Tag;
        private readonly RefRW<LocalTransform> _Transform;
        private readonly RefRW<NotePadHealth> _NoteaPadHealth;
    }
}