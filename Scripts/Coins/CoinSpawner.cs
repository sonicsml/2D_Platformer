using System.Collections;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private float _countSpawnCoins = 4;

    private void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    private IEnumerator SpawnCoins()
    {
        yield return null;

        for (var i = 0; i < _countSpawnCoins; i++) 
        {
            SpawnCoin(_spawnPoints[i].position);
        }
    }
    
    private void SpawnCoin(Vector3 position)
    {
        Instantiate(_coinPrefab, position, Quaternion.identity);
    }
}
