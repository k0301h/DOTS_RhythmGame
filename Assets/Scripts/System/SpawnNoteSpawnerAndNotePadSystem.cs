using Unity.Burst;
using Unity.Entities;

namespace Game
{
    [BurstCompile]
    public struct SpawnNoteSpawnerAndNotePadSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.Enabled = false;  // 무슨 의미?
            var NotePadEntity = SystemAPI.GetSingletonEntity<NotePadAuthoring>();
            var NotePad = SystemAPI.GetAspect<NotePadAspect>(NotePadEntity);
            
            var NoteSpawnerEntity = SystemAPI.GetSingletonEntity<NoteSpawnerAuthoring>();
            var NoteSpawner = SystemAPI.GetAspect<NoteSpawnerAspect>(NoteSpawnerEntity);
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