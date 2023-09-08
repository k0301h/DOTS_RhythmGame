using System;
using Unity.Burst;
using Unity.Entities;
using UnityEngine;

// System에서 노트 판정을 관리하는것이 맞을까? Note에서 Component을 만들어서 하는게 아닐까? 한번 생각해 보자.

namespace Game
{
    [BurstCompile]
    public partial struct NoteHitSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<NoteTag>();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
            
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            
        }
    }
}