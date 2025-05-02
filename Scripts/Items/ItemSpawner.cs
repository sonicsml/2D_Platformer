using UnityEngine;

public class ItemSpawner<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private T _prefabItem;
    [SerializeField] private float _countItemsSpawn = 3;

    private void Start()
    {
        ItemsSpawn();
    }

    private void ItemsSpawn()
    {
        for (var i = 0; i < _countItemsSpawn; i++)
        {
            ItemsSpawn(_spawnPoints[i].position);
        }
    }

    private void ItemsSpawn(Vector3 position)
    {
        Instantiate(_prefabItem, position, Quaternion.identity);
    }
}
