using Unity.Entities;

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
        public override Bake(NoteSpawnerMono authoring)
        {
            var NotespawnerEntity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent<NoteSpawnerTags>(NotespawnerEntity);
            AddComponent(NotespawnerEntity, new NoteSpawnerAuthoring()
            {
                Id = authoring.Id;
                Speed = authoring.Speed;
                Position = authoring.Position;
            })
        }
    }
}