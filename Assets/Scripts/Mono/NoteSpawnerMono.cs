using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Game
{
    public class NoteSpawnerMono : MonoBehaviour
    {
        public int Id;
        
        public float Speed;
        public float3 Position;
    }

    public class NoteSpawnerBaker : Baker<NoteSpawnerMono>
    {
        public override void Bake(NoteSpawnerMono authoring)
        {
            var NotespawnerEntity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent<NoteSpawnerTag>(NotespawnerEntity);
            AddComponent(NotespawnerEntity, new NoteSpawnerAuthoring()
            {
                Id = authoring.Id,
                Speed = authoring.Speed,
                Position = authoring.Position
            });
        }
    }
}