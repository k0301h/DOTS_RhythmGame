using Unity.Entities;
using Unity.Mathematics;

namespace Game
{
    public partial struct NotePlaceJob : IJobEntity
    {
        private void Execute(NoteAspect noteaspect)
        {
            noteaspect.Position = new float3(0, 100, 0);
        }
    }
}