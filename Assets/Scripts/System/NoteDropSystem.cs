using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

namespace Game
{
    public partial struct NoteDropSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            // job을 실행 시킬려면 스케쥴해야함
            var job = new NoteDropJob();
            
            // state.Dependency는 스케쥴에 넣는 일임
            state.Dependency = job.Schedule(state.Dependency);
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
            
        }
    }
}