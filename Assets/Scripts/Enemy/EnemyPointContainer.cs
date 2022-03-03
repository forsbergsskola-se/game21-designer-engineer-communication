using UnityEngine;

namespace Enemy
{
    public class EnemyPointContainer : MonoBehaviour
    {
        [SerializeField] private int points;
        public int Points => points;
    }
}