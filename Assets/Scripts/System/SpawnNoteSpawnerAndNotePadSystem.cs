using System;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    [BurstCompile]
    public partial struct SpawnNoteSpawnerAndNotePadSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<NoteSpawnerTag>();
            state.RequireForUpdate<BeginSimulationEntityCommandBufferSystem.Singleton>();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            // var NotePadEntity = SystemAPI.GetSingletonEntity<NotePadAuthoring>();
            // var NotePad = SystemAPI.GetAspect<NotePadAspect>(NotePadEntity);
            //
            // var NoteSpawnerEntity = SystemAPI.GetSingletonEntity<NoteSpawnerAuthoring>();
            // var NoteSpawner = SystemAPI.GetAspect<NoteSpawnerAspect>(NoteSpawnerEntity);
            
            var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);
            // ecb는 system에 종속된 작업 ==> state.Enabled = false을 하면 가끔 instance할때도 있고 안할때도 있다.
            // ==>알아봐보자

            var entity = SystemAPI.GetSingletonEntity<NoteSpawnerTag>();
         	var newNodeEntity = ecb.Instantiate(entity);
        }
    }
}