using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Game
{
    public partial struct NoteDropJob : IJobEntity
    {
        private static void Execute(NoteAspect noteAspect)
        {
            noteAspect.Position -= new float3(0, 1, 0);
        }
    }
}