using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Random = System.Random;

namespace Game
{
    public partial struct NotePlaceSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<SpawnNoteTag>();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            //var job = new NotePlaceJob();

            //state.Dependency = job.Schedule(state.Dependency);

            //수정은 불가능
            //var query = SystemAPI.Query<SpawnNoteTag>();
            //state.EntityManager.SetComponentData(query);

            var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);

            
            // LocalTransform을 수정하기 위해서 RW로 참조
            foreach (var(tag, transform, entity) in SystemAPI.Query<SpawnNoteTag,RefRW<LocalTransform>>().WithEntityAccess())
            {
                if(transform.ValueRO.Position.y < 0)    // 그래서 임시 방편으로 system이 돌아가는것을 확인하기 위해서 if문 작성
                    transform.ValueRW.Position = new float3(0, 10000, 0);
                
                
                // 현재 inspector view에서 entity을 확인 할수 있는데 system의 query에서 없어지므로 Entity의 position을 확인할수 없는 문제점 발생
                //ecb.RemoveComponent<SpawnNoteTag>(entity);
            }

            //state.Enabled = false;
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }
    }
}