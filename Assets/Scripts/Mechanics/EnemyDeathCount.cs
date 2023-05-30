using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    public class EnemyDeathCount : MonoBehaviour
    {
        private int _count = 0;

        public int GetCount()
        {
            return _count;
        }

        public void IncreaseCount()
        {
            _count++;
        }
    }
}
