using Unity.Entities;

namespace Game
{
    public class NoteSpawnerMono : MonoBehaviour
    {
        
    }

    public class NoteSpawnerBaker : Baker<NoteSpawnerMono>
    {
        public override Bake(NoteSpawnerMono authoring)
        {
            
        }
    }
}