using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Game
{
    public class NoteMono : MonoBehaviour
    {
        // 기존 방식
        public int Id;
        
        public NoteType NoteType;
        public float3 Position;
    }

    public class NoteBaker : Baker<NoteMono>
    {
        public override void Bake(NoteMono authoring)
        {
            var NoteEntity = GetEntity(TransformUsageFlags.Dynamic);
            // var NoteEntity = GetEntity(authoring.gameObject, TransformUsageFlags.Dynamic);   ==> 두개의 차이점 확실히 알아보기
            AddComponent<NoteTag>(NoteEntity);
            AddComponent(NoteEntity, new NoteAuthoring()
            {
                Id = authoring.Id,
                NoteType = authoring.NoteType,
                Position = authoring.Position
            });
        }
    }
}