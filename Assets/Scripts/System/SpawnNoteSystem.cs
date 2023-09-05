using Unity.Burst;
using Unity.Entities;

namespace Game
{
    [BurstCompile]
    public partial struct SpawnNoteSystem : ISystem
    {
        [BustCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<NotePadTag>();
            state.RequireForUpdate<NoteSpawnerTag>();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
            
        }

        [BurstCompie]
        public void OnUpdate(ref SystemState state)
        {
            
        }
    }
}