using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _countSpawnEnemy = 3;

    private void Start()
    {
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        for (var i = 0; i < _countSpawnEnemy; i++)
        {
            SpawnEnemy(_spawnPoints[i].position);
        }
    }

    private void SpawnEnemy(Vector3 position)
    {
        Instantiate(_enemyPrefab, position, Quaternion.identity);
    }
}
