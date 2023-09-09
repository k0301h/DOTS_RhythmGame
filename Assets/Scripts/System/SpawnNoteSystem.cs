using Unity.Burst;
using Unity.Entities;
using UnityEngine;

namespace Game
{
    [BurstCompile]
    public partial struct SpawnNoteSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<NoteSpawnerTag>();
            // Unity 프로젝트 실행을 했을때 DOTS System이 만들어 준다.
            state.RequireForUpdate<BeginSimulationEntityCommandBufferSystem.Singleton>();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
            
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);
            // NoteSpawnerTag라는 Component를 가지고 있는 객체가 singleton이라면 NoteSpawnerAspect을 받아온다.
            var Entity = SystemAPI.GetAspect<NoteSpawnerAspect>(SystemAPI.GetSingletonEntity<NoteSpawnerTag>());
            
            // Aspect의 Authoring의 RO인 NoteEntity을 받아온다.
            if (Input.GetKeyDown(KeyCode.A))
            {
                ecb.Instantiate(Entity.NoteSpawnerAuthoring.ValueRO.NoteEntity);
            } 
        }
    }
}