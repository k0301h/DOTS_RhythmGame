using Unity.Burst;
using Unity.Entities;

namespace Game
{
    public partial struct NotePlaceSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var job = new NotePlaceJob();

            state.Dependency = job.Schedule(state.Dependency);
            state.Enabled = false;
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }
    }
}