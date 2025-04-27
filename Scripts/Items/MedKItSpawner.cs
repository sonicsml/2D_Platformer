using System.Collections;
using UnityEngine;

public class MedKItSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private MedKit _medKitPrefab;

    private void Start()
    {
        SpawnCoins();
    }

    private void SpawnCoins()
    {

        for (var i = 0; i < _spawnPoints.Length; i++)
        {
            SpawnCoin(_spawnPoints[i].position);
        }
    }

    private void SpawnCoin(Vector3 position)
    {
        Instantiate(_medKitPrefab, position, Quaternion.identity);
    }
}
