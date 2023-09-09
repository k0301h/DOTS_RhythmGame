using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Game
{
    public class NoteSpawnerMono : MonoBehaviour
    {
        public float3 Position;
        public GameObject NoteObject;  
        // Entity로 하면 Unity Inspector View에서 보이지가 않고, Entity는 실행을 했을때 생성이 되므로 prefab으로 넣은수가 없다.
    }

    public class NoteSpawnerBaker : Baker<NoteSpawnerMono>
    {
        public override void Bake(NoteSpawnerMono authoring)
        {
            var NotespawnerEntity = GetEntity(authoring.gameObject,TransformUsageFlags.Dynamic);
            AddComponent<NoteSpawnerTag>(NotespawnerEntity);
            AddComponent(NotespawnerEntity, new NoteSpawnerAuthoring()
            {
                Position = authoring.Position,
                NoteEntity = GetEntity(authoring.NoteObject, TransformUsageFlags.Dynamic)
            });
        }
    }
}