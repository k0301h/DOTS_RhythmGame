using Unity.Burst;
using Unity.Entities;

namespace Game
{
    [BurstCompile]
    public partial struct SpawnNoteSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<NoteTag>();
            state.RequireForUpdate<BeginSimulationEntityCommandBufferSystem.Singleton>();
            // state.RequireForUpdate<NotePadTag>();
            state.RequireForUpdate<NoteSpawnerTag>();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
            
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            //var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);

            //var entity = SystemAPI.GetSingletonEntity<NoteTag>();
            //var newNodeEntity = ecb.Instantiate(entity);
        }
    }
}