using Unity.Entities;
using UnityEngien;

namespace Game
{
    public class NoteMono : MonoBehavier
    {
        public int NoteType;
    }

    public class NoteBaker : Baker<NoteMono>
    {
        public override void Bake(NoteMono authoring)
        {
            var NoteEntity = GetEntity(authoring.gameObject, TranformUsageFlags.Dynamic);
            AddComponent<NoteTag>(NoteEntity);
        }
    }
}