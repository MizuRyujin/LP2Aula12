
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LevelSpec")]
public class LevelSpec : ScriptableObject
{
    [SerializeField]
    private Vector3[] enemySpawnPoints = null;

    public IEnumerable<Vector3> EnemySpawnPoints => enemySpawnPoints;
}
