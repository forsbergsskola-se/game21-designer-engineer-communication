// using System.Collections.Generic;

using UnityEngine;

namespace Enemy
{
    [CreateAssetMenu(menuName = "Enemy/Enemy Point Collection", fileName = "EnemyPointCollectionSO")]
    public class EnemyPointCollectionSO : ScriptableObject
    {
        [SerializeField] private EnemyPointContainer[] enemyPointContainers; //As array
        public EnemyPointContainer[] EnemyPointContainers => enemyPointContainers;

        // [SerializeField] private List<EnemyPointContainer> enemyPointContainersAsList; //As list
    }
}