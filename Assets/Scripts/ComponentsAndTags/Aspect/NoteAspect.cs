using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine.Rendering;

namespace Game
{
    public readonly partial struct NoteAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRO<NoteTag> Tag;
        private readonly RefRW<LocalTransform> Transform;
        private readonly RefRW<NoteAuthoring> NoteAuthoring;

        public float3 Position
        {
            get => Transform.ValueRO.Position;
            set => Transform.ValueRW.Position = value;
        }
    }
}