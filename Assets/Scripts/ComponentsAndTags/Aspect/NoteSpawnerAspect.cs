using Unity.Collections;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

namespace Game
{
    public readonly partial struct NoteSpawnerAspect : IAspect
    {
        public readonly Entity Entity;

        public readonly RefRO<NoteSpawnerAuthoring> NoteSpawnerAuthoring;
            
        public readonly RefRO<NoteSpawnerTag> Tag;
        public readonly RefRW<LocalTransform> Transform;
    }
}