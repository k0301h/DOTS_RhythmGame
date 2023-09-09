using Unity.Entities;
using UnityEngine;

namespace Game
{
    public struct RadomValueAuthoring : MonoBehaviour
    {
        public float randomTime;

        class RandomPositionBaker : Baker<RadomValueAuthoring>
        {
            public override void Bake(RadomValueAuthoring authoring)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}