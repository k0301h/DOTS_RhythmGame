using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Game
{
    public partial struct NoteDropJob : IJobEntity
    {
        private void Execute(NoteAspect noteaspect)
        {
            noteaspect.Position -= new float3(0, 1, 0);
        }
    }
}