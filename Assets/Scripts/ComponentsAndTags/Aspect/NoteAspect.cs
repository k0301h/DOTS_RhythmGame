using Unity.Entities;
using Unity.Transforms;

namespace Game
{
    public readonly partial struct NoteAspect : IAspect
    {
        public readonly Entity Entity;

        private readonly RefRW<LocalTransform> _transform;
    }
}