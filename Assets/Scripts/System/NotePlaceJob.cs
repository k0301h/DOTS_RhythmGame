using Unity.Entities;
using Unity.Mathematics;

namespace Game
{
    public partial struct NotePlaceJob : IJobEntity
    {
        private static void Execute(NoteAspect noteAspect)
        {
            noteAspect.Position = new float3(0, 10000, 0);
        }
    }
}