using Unity.Entities;

namespace Game
{
    public readonly partial struct NotePadAspect : IAspect
    {
        public readonly Entity Entity;

        private readonly RefRW<LocalTransform> _transform;
        private readonly RefRW<NotePadHealth> _NoteaPadHealth;
    }
}