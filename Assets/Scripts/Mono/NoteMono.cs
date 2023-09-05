using Unity.Entities;
using UnityEngien;

namespace Game
{
    public class NoteMono : MonoBehavier
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
            var NoteEntity = GetEntity(authoring.gameObject, TranformUsageFlags.Dynamic);
            AddComponent<NoteTag>(NoteEntity);
			AddComponent(NoteEntity, new NoteAuthoring()	
			{
				Id = authoring.Id;
				NoteType = authoring.NoteType;
				Position = authoring.Position;
			})
        }
    }
}