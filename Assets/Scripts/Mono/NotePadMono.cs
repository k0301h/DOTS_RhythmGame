using Unity.Entities;

namespace Game
{
    public class NotePadMono : MonoBehaviour
    {

    }

    public class NotePadBaker : Baker<NotePadMono>
    {
        public override void Bake(NotePadMono authoring)
        {
            var NotePadEntity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent<NotePadTags>(NotePadEntity);
        }
    }
}