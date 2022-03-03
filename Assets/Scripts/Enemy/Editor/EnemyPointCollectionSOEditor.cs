using UnityEditor;
using UnityEngine;

namespace Enemy.Editor
{
    [CustomEditor(typeof(EnemyPointCollectionSO))]
    public class EnemyPointCollectionSOEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawTotalPointsText();

            // base.OnInspectorGUI();
            DrawDefaultInspector();
        }

        private void DrawTotalPointsText()
        {
            var enemyPointCollectionSO = (EnemyPointCollectionSO)target;
            // var enemyPointCollectionSO = target as EnemyPointCollectionSO;

            var totalNumberOfPoints = 0;

            for (var i = 0; i < enemyPointCollectionSO.EnemyPointContainers.Length; i++)
            {
                totalNumberOfPoints += enemyPointCollectionSO.EnemyPointContainers[i].Points;
            }

            GUILayout.Label($"Total points: {totalNumberOfPoints}");
        }
    }
}