using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab = null;
    [SerializeField]
    private LevelSpec levelSpec = null;

    private void Awake()
    {
        foreach (Vector3 pos in levelSpec.EnemySpawnPoints)
        {
            GameObject newEnemy = Instantiate(
                enemyPrefab, pos, Quaternion.identity);
        }
    }

}
